﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using CoPlayV2.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CoPlayV2.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ManageController()
        {
        }

        public ManageController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set 
            { 
                _signInManager = value; 
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private SportLevelEnum parseLevelEnum(string str)
        {
            SportLevelEnum result;
            try
            {
                result = (SportLevelEnum)Enum.Parse(typeof(SportLevelEnum), str.Trim());
            }
            catch (Exception ex)
            {
                result = SportLevelEnum.NotSelected;
            }
            return result;
        }

        //DBcontext to tables except usertables
        private readonly CoPlayDBModel _db = new CoPlayDBModel();

        public async Task<ActionResult> MyIndex()
        {
            var resultModel = new MyManageIndexViewModels();
            var userId = User.Identity.GetUserId();
            var user = await UserManager.FindByIdAsync(userId);
            var myUser = new MyUser {user = user};
            resultModel.CurrentUser = myUser;
            var performances = _db.UserSportPerformances.Where(s => s.UserID.Equals(userId));
            foreach (var pf in performances)
            {

                switch (pf.Sport)
                {
                    case "badminton":
                        resultModel.BadmintonPf = parseLevelEnum(pf.Level);
                        break;
                    case "TableTennis":
                        resultModel.TabletennisPf = parseLevelEnum(pf.Level);
                        break;
                    case "TennisIndoor":
                        resultModel.TennisIdpf = parseLevelEnum(pf.Level);
                        break;
                    case "FitnessGymnasiumWorkouts":
                        resultModel.FitnessPf = parseLevelEnum(pf.Level);
                        break;
                    case "SquashRacquetball":
                        resultModel.SquashPf = parseLevelEnum(pf.Level);
                        break;
                    case "Swimming"://
                        resultModel.SwimmingPf = parseLevelEnum(pf.Level);
                        break;
                    case "TennisOutdoor"://
                        resultModel.TennisOdpf = parseLevelEnum(pf.Level);
                        break;
                    default:
                        Console.WriteLine("Sport type error: " + pf.Sport);
                        break;
                }
            }
            return View("MyManageIndex", resultModel);
        }

        public async Task<ActionResult> UpdateUserInfoTask(MyManageIndexViewModels model)
        {

            var userId = User.Identity.GetUserId();
            var currentUser = await UserManager.FindByIdAsync(userId);//find
            var apu  = (ApplicationUser) currentUser;
            if (!model.CurrentUser.user.FirstName.Equals(currentUser.FirstName))//Modify Firstname
            {
                apu.FirstName = model.CurrentUser.user.FirstName;
            }
            if (!model.CurrentUser.user.Email.Equals(currentUser.Email))//Modify Email
            {
                apu.Email = model.CurrentUser.user.Email;
            }
            if (!model.CurrentUser.user.UserName.Equals(currentUser.UserName))//Modify Username
            {
                apu.UserName = model.CurrentUser.user.UserName;
            }
            if (!model.CurrentUser.user.LastName.Equals(currentUser.LastName))//Modify Lastname
            {
                apu.LastName = model.CurrentUser.user.LastName;
            }
            if (!model.CurrentUser.user.Gender.Equals(currentUser.Gender))//Modify Gender
            {
                apu.Gender = model.CurrentUser.user.Gender;
            }
            if (!model.CurrentUser.user.Age.Equals(currentUser.Age))//Modify Age
            {
                apu.Age = model.CurrentUser.user.Age;
            }
            try
            {
                var result = await UserManager.UpdateAsync(apu);
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                         validationError.PropertyName,
                                         validationError.ErrorMessage);
                    }
                }
            }
            return RedirectToAction("MyIndex");
            
        }

        
        public async Task<ActionResult> CheckMessages(MyManageIndexViewModels model)
        {
            var resultModel = new MyManageIndexViewModels();
            var userId = User.Identity.GetUserId();
            var user = await UserManager.FindByIdAsync(userId);
            //Get all messages sent to this user or sent by this user
            var messages = _db.InternalMessages.Where(s => s.SenderID.Equals(userId) || s.ReceiverID.Equals(userId));
            resultModel.sentMessages = new List<MyMessage>();
            resultModel.receivedMessages = new List<MyMessage>();
            foreach (var msg in messages)
            {
                // mails sent to this user
                if (msg.ReceiverID.Equals(userId))
                {
                    var sender =  await UserManager.FindByIdAsync(msg.SenderID);
                    resultModel.receivedMessages.Add(new MyMessage{ message = msg, sender = sender });
                }
                else if (msg.SenderID.Equals(userId))
                {//mails sent by this user
                    var receiver = await UserManager.FindByIdAsync(msg.ReceiverID);
                    resultModel.sentMessages.Add(new MyMessage { message = msg, receiver = receiver });
                }

            }

            return View("CheckMessegsView",resultModel);
        }

        public async Task<ActionResult> UpdateUserSportLevel(MyManageIndexViewModels model)
        {
            var userId = User.Identity.GetUserId();
            var pfs = _db.UserSportPerformances.Where(s => s.UserID.Equals(userId));
            SportLevelEnum? newPf = null;
            
            foreach (var pf in pfs)
            {
                switch (pf.Sport)
                {
                    case "badminton":
                        newPf =  model.BadmintonPf;
                        break;
                    case "TableTennis":
                        newPf = model.TabletennisPf;
                        break;
                    case "TennisIndoor":
                        newPf = model.TennisIdpf;
                        break;
                    case "FitnessGymnasiumWorkouts":
                        newPf = model.FitnessPf;
                        break;
                    case "SquashRacquetball":
                        newPf = model.SquashPf;
                        break;
                    case "Swimming":
                        newPf = model.SwimmingPf;
                        break;
                    case "TennisOutdoor":
                        newPf = model.TennisOdpf;
                        break;
                    default:
                        Console.WriteLine("Sport type error: " + pf.Sport);
                        break;
                }
                if (newPf.HasValue)
                {
                    pf.Level = newPf.ToString();
                    
                }
            }

            try
            {

                _db.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException dex)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.)
                ModelState.AddModelError("",
                    "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }

            return RedirectToAction("MyIndex");

        }



        //
        // GET: /Manage/Index
        public async Task<ActionResult> Index(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageMessageId.SetTwoFactorSuccess ? "Your two-factor authentication provider has been set."
                : message == ManageMessageId.Error ? "An error has occurred."
                : message == ManageMessageId.AddPhoneSuccess ? "Your phone number was added."
                : message == ManageMessageId.RemovePhoneSuccess ? "Your phone number was removed."
                : "";

            var userId = User.Identity.GetUserId();
            var model = new IndexViewModel
            {
                HasPassword = HasPassword(),
                PhoneNumber = await UserManager.GetPhoneNumberAsync(userId),
                TwoFactor = await UserManager.GetTwoFactorEnabledAsync(userId),
                Logins = await UserManager.GetLoginsAsync(userId),
                BrowserRemembered = await AuthenticationManager.TwoFactorBrowserRememberedAsync(userId)
            };
            return View(model);
        }

        //
        // POST: /Manage/RemoveLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemoveLogin(string loginProvider, string providerKey)
        {
            ManageMessageId? message;
            var result = await UserManager.RemoveLoginAsync(User.Identity.GetUserId(), new UserLoginInfo(loginProvider, providerKey));
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                message = ManageMessageId.RemoveLoginSuccess;
            }
            else
            {
                message = ManageMessageId.Error;
            }
            return RedirectToAction("ManageLogins", new { Message = message });
        }

        //
        // GET: /Manage/AddPhoneNumber
        public ActionResult AddPhoneNumber()
        {
            return View();
        }

        //
        // POST: /Manage/AddPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddPhoneNumber(AddPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Generate the token and send it
            var code = await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), model.Number);
            if (UserManager.SmsService != null)
            {
                var message = new IdentityMessage
                {
                    Destination = model.Number,
                    Body = "Your security code is: " + code
                };
                await UserManager.SmsService.SendAsync(message);
            }
            return RedirectToAction("VerifyPhoneNumber", new { PhoneNumber = model.Number });
        }

        //
        // POST: /Manage/EnableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EnableTwoFactorAuthentication()
        {
            await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), true);
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", "Manage");
        }

        //
        // POST: /Manage/DisableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DisableTwoFactorAuthentication()
        {
            await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), false);
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", "Manage");
        }

        //
        // GET: /Manage/VerifyPhoneNumber
        public async Task<ActionResult> VerifyPhoneNumber(string phoneNumber)
        {
            var code = await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), phoneNumber);
            // Send an SMS through the SMS provider to verify the phone number
            return phoneNumber == null ? View("Error") : View(new VerifyPhoneNumberViewModel { PhoneNumber = phoneNumber });
        }

        //
        // POST: /Manage/VerifyPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyPhoneNumber(VerifyPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await UserManager.ChangePhoneNumberAsync(User.Identity.GetUserId(), model.PhoneNumber, model.Code);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.AddPhoneSuccess });
            }
            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "Failed to verify phone");
            return View(model);
        }

        //
        // POST: /Manage/RemovePhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemovePhoneNumber()
        {
            var result = await UserManager.SetPhoneNumberAsync(User.Identity.GetUserId(), null);
            if (!result.Succeeded)
            {
                return RedirectToAction("Index", new { Message = ManageMessageId.Error });
            }
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", new { Message = ManageMessageId.RemovePhoneSuccess });
        }

        //
        // GET: /Manage/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Manage/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.ChangePasswordSuccess });
            }
            AddErrors(result);
            return View(model);
        }

        //
        // GET: /Manage/SetPassword
        public ActionResult SetPassword()
        {
            return View();
        }

        //
        // POST: /Manage/SetPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SetPassword(SetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword);
                if (result.Succeeded)
                {
                    var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                    if (user != null)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                    }
                    return RedirectToAction("Index", new { Message = ManageMessageId.SetPasswordSuccess });
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Manage/ManageLogins
        public async Task<ActionResult> ManageLogins(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
                : message == ManageMessageId.Error ? "An error has occurred."
                : "";
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user == null)
            {
                return View("Error");
            }
            var userLogins = await UserManager.GetLoginsAsync(User.Identity.GetUserId());
            var otherLogins = AuthenticationManager.GetExternalAuthenticationTypes().Where(auth => userLogins.All(ul => auth.AuthenticationType != ul.LoginProvider)).ToList();
            ViewBag.ShowRemoveButton = user.PasswordHash != null || userLogins.Count > 1;
            return View(new ManageLoginsViewModel
            {
                CurrentLogins = userLogins,
                OtherLogins = otherLogins
            });
        }

        //
        // POST: /Manage/LinkLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LinkLogin(string provider)
        {
            // Request a redirect to the external login provider to link a login for the current user
            return new AccountController.ChallengeResult(provider, Url.Action("LinkLoginCallback", "Manage"), User.Identity.GetUserId());
        }

        //
        // GET: /Manage/LinkLoginCallback
        public async Task<ActionResult> LinkLoginCallback()
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync(XsrfKey, User.Identity.GetUserId());
            if (loginInfo == null)
            {
                return RedirectToAction("ManageLogins", new { Message = ManageMessageId.Error });
            }
            var result = await UserManager.AddLoginAsync(User.Identity.GetUserId(), loginInfo.Login);
            return result.Succeeded ? RedirectToAction("ManageLogins") : RedirectToAction("ManageLogins", new { Message = ManageMessageId.Error });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _userManager != null)
            {
                _userManager.Dispose();
                _userManager = null;
            }

            base.Dispose(disposing);
        }


#region Helpers
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private bool HasPassword()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        private bool HasPhoneNumber()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PhoneNumber != null;
            }
            return false;
        }

        public enum ManageMessageId
        {
            AddPhoneSuccess,
            ChangePasswordSuccess,
            SetTwoFactorSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            RemovePhoneSuccess,
            Error
        }

#endregion
    }
}