
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CoPlayV2.Models
{
    public class SportTypeModel
    {
        public SportTypesEnum SportsName { get; set; }
    }

    public class SportLevelModel
    {
        public SportLevelEnum SportsLevel { get; set; }
    }



    public enum SportLevelEnum
    {

        Low,

        Middle,

        High
    }


    public enum SportTypesEnum
    {
        //Aerobics,

        //[Display(Name = "AFL (Indoor)")]
        //AFLIndoor,

        //Archery,
        //Athletics,

        //[Display(Name = "Australian Rules Football")]
        //AustralianRulesFootball
        //    ,
        Badminton,
        //Baseball,
        //Basketball,

        //[Display(Name = "Beach Volleyball")]
        //BeachVolleyball,

        //BMX,
        //Bocce,

        //[Display(Name = "Body Building")]
        //BodyBuilding,

        //Boxing,
        //Callisthenics,

        //[Display(Name = "Canoe Polo")]
        //CanoePolo,

        //Canoeing,

        //[Display(Name = "Carpet Bowls")]
        //CarpetBowls,

        //Cricket,

        //[Display(Name = "Cricket (Indoor)")]
        //CricketIndoor,

        //Croquet,
        //Cycling,
        //Dancing,

        //[Display(Name = "Disk Golf")]
        //DiskGolf,

        //Diving,
        //Equestrian,
        //Fencing,

        [Display(Name = "Fitness / Gymnasium Workouts")]
        FitnessGymnasiumWorkouts,

        //[Display(Name = "Flying Disk")]
        //FlyingDisk,

        //[Display(Name = "Gaelic Football")]
        //GaelicFootball,

        //[Display(Name = "Go Karting")]
        //GoKarting,

        //Golf,
        //Gridiron,
        //Gymnastics,
        //Hockey,

        //[Display(Name = "Ice Hockey")]
        //IceHockey,

        //[Display(Name = "Inline Hockey")]
        //InlineHockey,

        //[Display(Name = "Jet Skiing")]
        //JetSkiing,

        //Judo,
        //Karate,
        //Lacrosse,

        //[Display(Name = "Lawn Bowls")]
        //LawnBowls,

        //[Display(Name = "Martial Arts")]
        //MartialArts,

        //[Display(Name = "Modern Pentathlon")]
        //ModernPentathlon,

        //[Display(Name = "Motor Cycling")]
        //MotorCycling,

        //[Display(Name = "Motor SportsName")]
        //MotorSports,

        //Netball,

        //[Display(Name = "Netball (Indoor)")]
        //NetballIndoor,

        //[Display(Name = "Open Space")]
        //OpenSpace,

        //Orienteering,
        //Polo,
        //Polocrosse,

        //[Display(Name = "Power Boating")]
        //PowerBoating,

        //[Display(Name = "Rock Climbing / Abseiling (Indoor)")]
        //RockClimbingAbseilingIndoor,

        //Rodeo,

        //[Display(Name = "Roller SportsName - Other")]
        //RollerSportsOther,

        //Rowing,

        //[Display(Name = "Rugby League")]
        //RugbyLeague,

        //[Display(Name = "Rugby Union")]
        //RugbyUnion,

        //Sailing,

        //[Display(Name = "Shooting SportsName")]
        //ShootingSports,

        //Skating,

        //[Display(Name = "Snooker / Billiards / Pool")]
        //SnookerBilliardsPool,

        //Soccer,

        //[Display(Name = "Soccer (Indoor Soccer / Futsal)")]
        //SoccerIndoorSoccerFutsal,

        //Softball,

        [Display(Name = "Squash / Racquetball")]
        SquashRacquetball,

        //[Display(Name = "Surf Life Saving")]
        //SurfLifeSaving,

        Swimming,

        [Display(Name = "Table Tennis")]
        TableTennis,

        //[Display(Name = "Tae Kwon Do")]
        //TaeKwonDo,

        //[Display(Name = "Team Handball")]
        //TeamHandball,

        //[Display(Name = "Ten Pin Bowling")]
        //TenPinBowling,

        [Display(Name = "Tennis (Indoor)")]
        TennisIndoor,

        [Display(Name = "Tennis (Outdoor)")]
        TennisOutdoor,

        //[Display(Name = "Touch Football")]
        //TouchFootball,

        //[Display(Name = "Underwater Hockey")]
        //UnderwaterHockey,

        //Volleyball,

        //[Display(Name = "Water Polo")]
        //WaterPolo,

        //[Display(Name = "Water Skiing")]
        //WaterSkiing,

        //[Display(Name = "Wheelchair SportsName")]
        //WheelchairSports

    }
}