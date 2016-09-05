using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CoPlayV2.Models
{

    public class Suburb
    {
        public SuburbEnum SuburbName { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

    }
    public enum SuburbEnum
    {
        //CURRENT,
        // ABBOTSFORD,
        // ABERFELDIE,

        // [Display(Name = "AIRLEYS INLET")]
        // AIRLEYSINLET,

        // [Display(Name = "AIRPORT WEST")]
        // AIRPORTWEST,

        // ALBANVALE,

        // [Display(Name = "ALBERT PARK")]
        // ALBERTPARK,

        // [Display(Name = "ALBERTON WEST")]
        // ALBERTONWEST,

        // ALBION,
        // ALEXANDRA,
        // ALFREDTON,

        // [Display(Name = "ALLANS FLAT")]
        // ALLANSFLAT,

        // ALLANSFORD,
        // ALPHINGTON,
        // ALTONA,

        // [Display(Name = "ALTONA MEADOWS")]
        // ALTONAMEADOWS,

        // [Display(Name = "ALTONA NORTH")]
        // ALTONANORTH,

        // ALVIE,
        // AMPHITHEATRE,
        // ANAKIE,
        // ANGLESEA,

        // [Display(Name = "APOLLO BAY")]
        // APOLLOBAY,

        // APSLEY,
        // ARARAT,
        // ARDEER,
        // ARDMONA,
        // ARMADALE,

        // [Display(Name = "ARTHURS CREEK")]
        // ARTHURSCREEK,

        // [Display(Name = "ASCOT VALE")]
        // ASCOTVALE,

        // ASHBURTON,
        ASHWOOD,
        // ASPENDALE,
        // ATHLONE,
        // AVENEL,
        // AVOCA,

        // [Display(Name = "AVONDALE HEIGHTS")]
        // AVONDALEHEIGHTS,

        // AVONSLEIGH,
        // AXEDALE,

        // [Display(Name = "BACCHUS MARSH")]
        // BACCHUSMARSH,

        // BAGSHOT,
        // BAIRNSDALE,
        // BAKER,
        // BALLAN,
        // BALLARAT,

        // [Display(Name = "BALLARAT EAST")]
        // BALLARATEAST,

        // [Display(Name = "BALLARAT NORTH")]
        // BALLARATNORTH,

        // BALLIANG,
        // BALMORAL,
        BALNARRING,

        [Display(Name = "BALNARRING BEACH")]
        BALNARRINGBEACH,

        // BALWYN,

        // [Display(Name = "BALWYN NORTH")]
        // BALWYNNORTH,

        // BAMAWM,
        // BAMBRA,

        // [Display(Name = "BANDIANA MILPO")]
        // BANDIANAMILPO,

        // BANGHOLME,
        // BANNOCKBURN,
        // BANYENA,
        // BARANDUDA,
        // BARINGHUP,
        // BARINHUP,
        // BARMAH,
        // BARNAWARTHA,
        // BARONGAROOK,
        // BARRABOOL,

        // [Display(Name = "BARUNAH PARK")]
        // BARUNAHPARK,

        // [Display(Name = "BARWON DOWNS")]
        // BARWONDOWNS,

        // [Display(Name = "BARWON HEADS")]
        // BARWONHEADS,

        // BASS,
        // BATESFORD,
        // BAYSWATER,

        // [Display(Name = "BAYSWATER NORTH")]
        // BAYSWATERNORTH,

        // BEACONSFIELD,
        // BEALIBA,
        // BEARII,

        // [Display(Name = "BEARS LAGOON")]
        // BEARSLAGOON,

        // BEAUCHAMP,
        // BEAUFORT,
        // BEAUMARIS,
        // BEEAC,

        // [Display(Name = "BEECH FOREST")]
        // BEECHFOREST,

        // BEECHWORTH,
        // BELBRIDGE,
        // BELGRAVE,

        // [Display(Name = "BELGRAVE SOUTH")]
        // BELGRAVESOUTH,

        // [Display(Name = "BELL PARK")]
        // BELLPARK,

        // [Display(Name = "BELL POST HILL")]
        // BELLPOSTHILL,

        // BELLBRAE,
        // BELMONT,
        // BENA,
        // BENALLA,
        // BENAMBRA,
        // BENDIGO,

        // [Display(Name = "BENDIGO EAST")]
        // BENDIGOEAST,

        // BENNETTSWOOD,
        // BENNISON,
        BENTLEIGH,

        [Display(Name = "BENTLEIGH EAST")]
        BENTLEIGHEAST,

        // BERRIWILLOCK,
        BERWICK,
        // BETHANGA,
        // BEULAH,
        // BEVERIDGE,
        // BINGINWARRI,
        // BIRCHIP,
        // BIRREGURRA,
        BITTERN,

        // [Display(Name = "BLACK HILL")]
        // BLACKHILL,

        // [Display(Name = "BLACK ROCK")]
        // BLACKROCK,

        // BLACKBURN,

        // [Display(Name = "BLACKBURN NORTH")]
        // BLACKBURNNORTH,

        // [Display(Name = "BLACKBURN SOUTH")]
        // BLACKBURNSOUTH,

        // BLACKWOOD,
        BLAIRGOWRIE,
        // BOISDALE,
        // BOLWARRA,
        // BONBEACH,
        // BONEGILLA,
        BONEO,

        // [Display(Name = "BONNIE DOON")]
        // BONNIEDOON,

        // BOOLARRA,
        // BOORHAMAN,
        // BOORT,
        // BORONIA,
        // BOWENVALE,

        // [Display(Name = "BOX HILL")]
        // BOXHILL,

        // [Display(Name = "BOX HILL NORTH")]
        // BOXHILLNORTH,

        // [Display(Name = "BOX HILL SOUTH")]
        // BOXHILLSOUTH,

        // BRAESIDE,
        // BRANXHOLME,
        // BRAYBROOK,
        // BREAKWATER,
        // BREAMLEA,
        // BREMLEA,
        // BRIAGOLONG,

        // [Display(Name = "BRIDGEWATER ON LODDON")]
        // BRIDGEWATERONLODDON,

        // BRIGHT,
        // BRIGHTON,

        // [Display(Name = "BRIGHTON EAST")]
        // BRIGHTONEAST,

        // BRIM,
        // BROADFORD,
        // BROADLANDS,
        // BROADMEADOWS,
        // BROOKLYN,

        // [Display(Name = "BROWN HILL")]
        // BROWNHILL,

        // BRUNSWICK,

        // [Display(Name = "BRUNSWICK EAST")]
        // BRUNSWICKEAST,

        // [Display(Name = "BRUNSWICK WEST")]
        // BRUNSWICKWEST,

        // BRUTHEN,
        // BUANGOR,
        // BUCHAN,
        // BUCKLEY,
        // BUFFALO,
        // BULLA,
        // BULLAROOK,
        // BULLEEN,
        // BULLENGAROOK,

        // [Display(Name = "BULN BULN")]
        // BULNBULN,

        // BUNBARTHA,
        // BUNDALONG,
        // BUNDOORA,
        // BUNGAREE,
        // BUNINYONG,
        // BUNYIP,
        // BURNLEY,

        // [Display(Name = "BURNSIDE HEIGHTS")]
        // BURNSIDEHEIGHTS,

        // BURRUMBEET,
        // BURWOOD,

        // [Display(Name = "BURWOOD EAST")]
        // BURWOODEAST,

        // BUXTON,
        // BYADUK,
        // BYAWARTHA,
        // CAIRNLEA,

        // [Display(Name = "CALIFORNIA GULLY")]
        // CALIFORNIAGULLY,

        // CALIVIL,
        // CAMBERWELL,
        // CAMPBELLFIELD,

        // [Display(Name = "CAMPBELLS BRIDGE")]
        // CAMPBELLSBRIDGE,

        // [Display(Name = "CAMPBELLS CREEK")]
        // CAMPBELLSCREEK,

        // CAMPERDOWN,
        // CANIAMBO,

        // [Display(Name = "CANN RIVER")]
        // CANNRIVER,

        // CANTERBURY,

        // [Display(Name = "CAPE BRIDGEWATER")]
        // CAPEBRIDGEWATER,

        // [Display(Name = "CAPE CLEAR")]
        // CAPECLEAR,

        // [Display(Name = "CAPE PATERSON")]
        // CAPEPATERSON,

        [Display(Name = "CAPE SCHANCK")]
        CAPESCHANCK,

        // [Display(Name = "CAPE SCHANK")]
        // CAPESCHANK,

        // [Display(Name = "CAPE WOOLAMAI")]
        // CAPEWOOLAMAI,

        // CARAMUT,
        // CARBOOR,
        // CARDINIA,
        // CARDROSS,
        // CARISBROOK,

        // [Display(Name = "CARLISLE RIVER")]
        // CARLISLERIVER,

        // CARLSRUSHE,
        CARLTON,

        // [Display(Name = "CARNBOURNE EAST")]
        // CARNBOURNEEAST,

        CARNEGIE,

        // [Display(Name = "CAROLINE SPRINGS")]
        // CAROLINESPRINGS,

        // CARRANBALLAC,
        // CARRUM,

        // [Display(Name = "CARRUM DOWNS")]
        // CARRUMDOWNS,

        // CASHMORE,
        // CASTERTON,
        // CASTLEMAINE,
        // CATANI,
        // CATHCART,
        CAULFIELD,

        [Display(Name = "CAULFIELD EAST")]
        CAULFIELDEAST,

        [Display(Name = "CAULFIELD NORTH")]
        CAULFIELDNORTH,

        [Display(Name = "CAULFIELD SOUTH")]
        CAULFIELDSOUTH,

        // CAVENDISH,
        // CERES,
        CHADSTONE,
        // CHARLTON,
        // CHELSEA,

        // [Display(Name = "CHELSEA HEIGHTS")]
        // CHELSEAHEIGHTS,

        // CHELTENHAM,
        // CHEWTON,
        // CHILTERN,

        // [Display(Name = "CHIRNSIDE PARK")]
        // CHIRNSIDEPARK,

        // [Display(Name = "CHRISTMAS HILLS")]
        // CHRISTMASHILLS,

        // CHURCHILL,
        // CLARENDON,
        // CLARINDA,
        // CLARKEFIELD,
        CLAYTON,

        // [Display(Name = "CLAYTON SOUTH")]
        // CLAYTONSOUTH,

        // [Display(Name = "CLIFTON HILL")]
        // CLIFTONHILL,

        // [Display(Name = "CLIFTON SPRINGS")]
        // CLIFTONSPRINGS,

        // CLOVERLEA,
        // CLUNES,
        CLYDE,

        [Display(Name = "CLYDE NORTH")]
        CLYDENORTH,

        // CLYDEBANK,
        // COBDEN,
        // COBRAM,
        // COBRICO,
        // COBURG,

        // [Display(Name = "COBURG NORTH")]
        // COBURGNORTH,

        // [Display(Name = "COBURG WEST")]
        // COBURGWEST,

        // COCKATOO,
        // COHUNA,
        // COLAC,
        // COLBINABBIN,
        // COLDSTREAM,
        // COLERAINE,
        // COLIGNAN,
        // COLLIGNEE,
        // COLLINGWOOD,
        // CONGUPNA,
        // CONNEWARRE,
        // CONNEWIRRICOO,
        // COOLAROO,
        // COOMA,
        // COORIEMUNGLE,

        // [Display(Name = "CORA LYNNE")]
        // CORALYNNE,

        // CORINDHAP,
        // CORINELLA,
        // CORIO,

        // [Display(Name = "CORONET BAY")]
        // CORONETBAY,

        // COROROOKE,
        // CORRYONG,
        // COSGROVE,
        // COWES,
        // COWWARR,
        // CRAIGIEBURN,
        CRANBOURNE,

        [Display(Name = "CRANBOURNE EAST")]
        CRANBOURNEEAST,

        [Display(Name = "CRANBOURNE NORTH")]
        CRANBOURNENORTH,

        [Display(Name = "CRANBOURNE SOUTH")]
        CRANBOURNESOUTH,

        // CREMORNE,
        // CRESWICK,

        [Display(Name = "CRIB POINT")]
        CRIBPOINT,

        // CROYDEN,
        // CROYDON,

        // [Display(Name = "CROYDON HILLS")]
        // CROYDONHILLS,

        // [Display(Name = "CROYDON NORTH")]
        // CROYDONNORTH,

        // [Display(Name = "CROYDON SOUTH")]
        // CROYDONSOUTH,

        // CUDGEWA,
        // CULGOA,
        // CULLULLERAINE,

        // [Display(Name = "DAISY HILL")]
        // DAISYHILL,

        // DALLAS,
        // DALYSTON,
        // DANDENONG,

        // [Display(Name = "DANDENONG NORTH")]
        // DANDENONGNORTH,

        // [Display(Name = "DANDENONG SOUTH")]
        // DANDENONGSOUTH,

        // DARLEY,
        // DARNUM,
        // DARTMOOR,
        // DARTMOUTH,
        // DAYLESFORD,
        // DEAN,

        // [Display(Name = "DEANS MARSH")]
        // DEANSMARSH,

        // [Display(Name = "DEAVON MEADOWS")]
        // DEAVONMEADOWS,

        // DEDERANG,

        // [Display(Name = "DEER PARK")]
        // DEERPARK,

        // DELACOMBE,
        // DELAHEY,
        // DENNINGTON,
        // DERGHOLM,
        // DERRIMUT,
        // DERRINALLUM,
        // DEVENISH,
        // DHURRINGILE,

        // [Display(Name = "DIAMOND CREEK")]
        // DIAMONDCREEK,

        // DIGBY,

        // [Display(Name = "DIGGERS REST")]
        // DIGGERSREST,

        // DIMBOOLA,
        // DINGEE,

        // [Display(Name = "DINGLEY VILLAGE")]
        // DINGLEYVILLAGE,

        // [Display(Name = "DIXONS CREEK")]
        // DIXONSCREEK,

        // DOCKLANDS,
        // DONALD,
        // DONCASTER,
        // DONNYBROOK,
        // DONVALE,
        // DOOKIE,
        // DOREEN,
        // DOUGLAS,
        DOVETON,
        DROMANA,
        // DROUIN,

        // [Display(Name = "DROUIN WEST")]
        // DROUINWEST,

        // DRUMBORG,
        // DRUMCONDRA,
        // DRUNG,
        // DRYSDALE,
        // DUMBALK,

        // [Display(Name = "DUMBALK NORTH")]
        // DUMBALKNORTH,

        // DUNKELD,
        // DUNLUCE,
        // DUNNSTOWN,
        // DUNOLLY,
        // DUNSTOWN,

        // [Display(Name = "EAGLE POINT")]
        // EAGLEPOINT,

        // EAGLEHAWK,

        // [Display(Name = "EAST DONCASTER")]
        // EASTDONCASTER,

        // [Display(Name = "EAST GEELONG")]
        // EASTGEELONG,

        // [Display(Name = "EAST IVANHOE VIC")]
        // EASTIVANHOEVIC,

        // [Display(Name = "EAST KEILOR")]
        // EASTKEILOR,

        // [Display(Name = "EAST MALVERN")]
        // EASTMALVERN,

        // ECHUCA,

        // [Display(Name = "ECKLIN SOUTH")]
        // ECKLINSOUTH,

        // EDENHOPE,

        // [Display(Name = "EDI UPPER")]
        // EDIUPPER,

        // EDITHVALE,
        // EILDON,
        // ELAINE,
        // ELDORADO,
        // ELLIMINYT,
        // ELLINBANK,
        // ELMHURST,
        // ELMORE,
        // ELPHINSTONE,
        ELSTERNWICK,
        // ELTHAM,

        // [Display(Name = "ELTHAM NORTH")]
        // ELTHAMNORTH,

        // ELWOOD,
        // EMERALD,

        // [Display(Name = "EMU CREEK")]
        // EMUCREEK,

        [Display(Name = "ENDEAVOUR HILLS")]
        ENDEAVOURHILLS,

        // ENFIELD,
        // ENSAY,
        // EPPING,
        // EPSOM,
        // ESKDALE,
        // ESSENDON,
        EUMEMMERRING,
        // EUROA,
        // EVERTON,
        // EYNESBURY,
        // FAIRFIELD,
        // FAIRHAVEN,
        // FAWKNER,
        // FERGUSON,
        // FERNBANK,

        // [Display(Name = "FERNTREE GULLY")]
        // FERNTREEGULLY,

        // [Display(Name = "FERNY CREEK")]
        // FERNYCREEK,

        // FINGAL,

        // [Display(Name = "FISH CREEK")]
        // FISHCREEK,

        // FITZROY,

        // [Display(Name = "FITZROY NORTH")]
        // FITZROYNORTH,

        FLEMINGTON,
        FLINDERS,

        // [Display(Name = "FLORA HILL")]
        // FLORAHILL,

        // FLOWERDALE,
        // FLYNN,
        // FOOTSCRAY,

        // [Display(Name = "FOREST HILL")]
        // FORESTHILL,

        // FORREST,
        // FOSTER,
        // FRAMLINGHAM,

        // [Display(Name = "FRAMLINGHAM EAST")]
        // FRAMLINGHAMEAST,

        // FRANKSTON,

        // [Display(Name = "FRANKSTON NORTH")]
        // FRANKSTONNORTH,

        // [Display(Name = "FRANKSTON SOUTH")]
        // FRANKSTONSOUTH,

        // [Display(Name = "FRESHWATER CREEK")]
        // FRESHWATERCREEK,

        // GANNAWARRA,
        // GAPSTED,
        // GARFIELD,

        // [Display(Name = "GARFIELD NORTH")]
        // GARFIELDNORTH,

        // GEELONG,

        // [Display(Name = "GEELONG SOUTH")]
        // GEELONGSOUTH,

        // [Display(Name = "GEELONG WEST")]
        // GEELONGWEST,

        // GELLIBRAND,
        // GEMBROOK,
        // GERANGAMETE,
        // GHERINGHAP,
        // GIRGARRE,
        // GISBORNE,

        // [Display(Name = "GISBORNE SOUTH")]
        // GISBORNESOUTH,

        // [Display(Name = "GLADSTONE PARK")]
        // GLADSTONEPARK,

        // GLADYSDALE,

        // [Display(Name = "GLEN ALVIE")]
        // GLENALVIE,

        // [Display(Name = "GLEN FORBES")]
        // GLENFORBES,

        [Display(Name = "GLEN HUNTLY")]
        GLENHUNTLY,

        // [Display(Name = "GLEN IRIS")]
        // GLENIRIS,

        [Display(Name = "GLEN WAVERLEY")]
        GLENWAVERLEY,

        // GLENALADALE,
        // GLENGARRY,
        // GLENLYON,
        // GLENORCHY,
        // GLENROWAN,
        // GLENROY,
        // GLENTHOMPSON,
        // GNARWARRE,
        // GOBUR,

        // [Display(Name = "GOLDEN BEACH")]
        // GOLDENBEACH,

        // [Display(Name = "GOLDEN SQUARE")]
        // GOLDENSQUARE,

        // GOORAMBAT,
        // GOORNONG,
        // GORDON,
        // GORMANDALE,
        // GOROKE,
        // GOWANBRAE,
        // GRANTVILLE,

        // [Display(Name = "GREAT WESTERN")]
        // GREATWESTERN,

        // GREENDALE,
        // GREENSBOROUGH,
        // GREENVALE,
        // GRENVILLE,
        // GRETA,

        // [Display(Name = "GRETA SOUTH")]
        // GRETASOUTH,

        // GROVEDALE,
        // GRUYERE,
        // GUILDFORD,
        // GUNBOWER,
        // GUNDOWRING,

        // [Display(Name = "GUYS HILL")]
        // GUYSHILL,

        // HADDON,
        // HADFIELD,
        HALLAM,
        // HALLORA,

        // [Display(Name = "HALLS GAP")]
        // HALLSGAP,

        // HAMILTON,

        // [Display(Name = "HAMLYN HEIGHTS")]
        // HAMLYNHEIGHTS,

        // HAMPTON,

        // [Display(Name = "HAMPTON EAST")]
        // HAMPTONEAST,

        [Display(Name = "HAMPTON PARK")]
        HAMPTONPARK,

        // HANSNVILLE,
        // HARCOURT,
        HARKAWAY,
        // HARRIETVILLE,
        // HARROW,
        HASTINGS,
        // HAVEN,
        // HAWKESDALE,
        // HAWTHORN,

        // [Display(Name = "HAWTHORN EAST")]
        // HAWTHORNEAST,

        // HEALESVILLE,
        // HEATHCOTE,
        // HEATHERTON,
        // HEATHMERE,
        // HEATHMONT,
        // HEIDELBERG,

        // [Display(Name = "HEIDELBERG HEIGHTS")]
        // HEIDELBERGHEIGHTS,

        // [Display(Name = "HEPBURN SPRINGS ")]
        // HEPBURNSPRINGS,

        // [Display(Name = "HERNE HILL")]
        // HERNEHILL,

        // HEXHAM,
        // HEYFIELD,
        // HEYWOOD,
        // HIGHETT,
        // HIGHTON,
        // HILLSIDE,

        [Display(Name = "HMAS CERBERUS")]
        HMASCERBERUS,

        // [Display(Name = "HODDLES CREEK")]
        // HODDLESCREEK,

        // HOPETOUN,

        // [Display(Name = "HOPPERS CROSSING")]
        // HOPPERSCROSSING,

        // HORSHAM,
        // HUMEVALE,
        // HUNTINGDALE,
        // HUNTLY,

        // [Display(Name = "HUNTLY NORTH")]
        // HUNTLYNORTH,

        // HURSTBRIDGE,

        // [Display(Name = "INDENTED HEAD")]
        // INDENTEDHEAD,

        // INGLEWOOD,
        // INVERGORDON,
        // INVERLEIGH,
        // INVERLOCH,
        // INVERMAY,
        // IRONBARK,
        // IRREWARRA,
        // IRREWILLIPE,
        // IRYMPLE,
        // IVANHOE,

        // [Display(Name = "IVANHOE EAST")]
        // IVANHOEEAST,

        // JACANA,

        // [Display(Name = "JAN JUC")]
        // JANJUC,

        // JARKLIN,
        // JEPARIT,
        // JINDIVICK,
        // JOHANNA,

        [Display(Name = "JUNCTION VILLAGE")]
        JUNCTIONVILLAGE,

        // JUNORTOUN,
        // KAARIMBA,
        // KALORAMA,

        // [Display(Name = "KANGAROO FLAT")]
        // KANGAROOFLAT,

        // [Display(Name = "KANGAROO GROUND")]
        // KANGAROOGROUND,

        // KANIVA,
        // KARRAMOMUS,
        // KATAMATITE,

        // [Display(Name = "KATANDRA WEST")]
        // KATANDRAWEST,

        // KATUNGA,
        // KAWARREN,
        // KEALBA,
        // KEILOR,

        // [Display(Name = "KEILOR DOWNS")]
        // KEILORDOWNS,

        // [Display(Name = "KEILOR EAST")]
        // KEILOREAST,

        // [Display(Name = "KEILOR PARK")]
        // KEILORPARK,

        // KELBA,

        // [Display(Name = "KENNETT RIVER")]
        // KENNETTRIVER,

        // KENNINGTON,

        // [Display(Name = "KEON PARK")]
        // KEONPARK,

        // KERANG,
        // KERNOT,
        // KERRRIMUIR,
        // KEW,

        // [Display(Name = "KEW EAST")]
        // KEWEAST,

        // KEYSBOROUGH,
        // KIALLA,

        // [Display(Name = "KIALLA WEST")]
        // KIALLAWEST,

        // KIEWA,
        // KILLARA,
        // KILLARNEY,
        // KILLAWARRA,
        // KILMANY,
        // KILMORE,


        // [Display(Name = "KILMORE EAST")]
        // KILMOREEAST,

        // KILSYTH,
        // KIMBOLTON,
        // KINGLAKE,


        // [Display(Name = "KINGLAKE WEST")]
        // KINGLAKEWEST,

        // KINGOWER,
        // KINGSBURY,
        // KINGSTON,
        // KNOWSLEY,
        // KNOXFIELD,
        // KONGWAK,


        // [Display(Name = "KOO WEE RUP")]
        // KOOWEERUP,

        // KOONDROOK,
        // KOONOOMOO,
        // KOONWARRA,
        // KOORLONG,
        // KOOYONG,
        // KORIOT,


        // [Display(Name = "KORONG VALE")]
        // KORONGVALE,

        // KORUMBURRA,
        // KORWEINGUBOORA,
        // KOYUGA,


        // [Display(Name = "KY VALLEY")]
        // KYVALLEY,

        // KYABRAM,
        // KYBRAM,
        // KYNETON,
        // KYOUGA,
        // LAHARUM,

        // [Display(Name = "LAKE BOGA")]
        // LAKEBOGA,

        // [Display(Name = "LAKE BOLAC")]
        // LAKEBOLAC,

        // [Display(Name = "LAKE CHARM")]
        // LAKECHARM,

        // [Display(Name = "LAKE GARDENS")]
        // LAKEGARDENS,

        // [Display(Name = "LAKE MERAN")]
        // LAKEMERAN,

        // [Display(Name = "LAKES ENTRANCE")]
        // LAKESENTRANCE,

        // LALBERT,
        // LALOR,
        // LANCASTER,
        // LANCEFIELD,
        // LANDSBOROUGH,

        // [Display(Name = "LANG LANG")]
        // LANGLANG,

        // LANGWARRIN,
        // LARA,
        // LARDNER,
        // LARPENT,

        // [Display(Name = "LAUCHING PLACE")]
        // LAUCHINGPLACE,

        // [Display(Name = "LAVERS HILL")]
        // LAVERSHILL,

        // LAVERTON,

        // [Display(Name = "LAVERTON NORTH")]
        // LAVERTONNORTH,

        // LEARMONTH,
        // LEICHARDT,
        // LEITCHVILLE,
        // LEMNOS,
        // LEONGATHA,

        // [Display(Name = "LEONGATHA NORTH")]
        // LEONGATHANORTH,

        // LEOPOLD,
        // LETHBRIDGE,
        // LEXTON,
        // LILLICO,
        // LILYDALE,
        // LINDENOW,

        // [Display(Name = "LINDENOW SOUTH")]
        // LINDENOWSOUTH,

        // LINTON,
        // LISMORE,

        // [Display(Name = "LITTLE RIVER")]
        // LITTLERIVER,

        // LOCH,

        // [Display(Name = "LOCH SPORT")]
        // LOCHSPORT,

        // LOCKINGTON,
        // LOCKWOOD,

        // [Display(Name = "LOCKWOOD SOUTH")]
        // LOCKWOODSOUTH,

        // [Display(Name = "LONG GULLY")]
        // LONGGULLY,

        // LONGFORD,
        // LONGLEA,
        // LONGWARRY,
        // LONGWOOD,
        // LORNE,

        // [Display(Name = "LOWER PLENTY")]
        // LOWERPLENTY,

        // [Display(Name = "LOWER TEMPLESTOWE")]
        // LOWERTEMPLESTOWE,

        // LUBECK,
        // LUCKNOW,
        LYNBROOK,
        // LYSTERFIELD,
        // MACARTHUR,
        // MACCLESFIELD,
        // MACEDON,
        // MACLEOD,
        // MACORNA,
        // MAFFRA,
        // MAGPIE,

        // [Display(Name = "MAIDEN GULLY")]
        // MAIDENGULLY,

        // MAIDSTONE,

        [Display(Name = "MAIN RIDGE")]
        MAINRIDGE,

        // MALDON,
        // MALLACOOTA,
        // MALMSBURY,
        // MALVERN,

        // [Display(Name = "MALVERN EAST")]
        // MALVERNEAST,

        // MANANGATANG,

        // [Display(Name = "MANDURANG SOUTH")]
        // MANDURANGSOUTH,

        // [Display(Name = "MANIFOLD HEIGHTS")]
        // MANIFOLDHEIGHTS,

        // MANNIBADAR,
        // MANSFIELD,

        // [Display(Name = "MARCUS HILL")]
        // MARCUSHILL,

        // MARDEN,
        // MARIBYRNONG,
        // MARKWOOD,
        // MARLO,
        // MARNOO,
        // MARONG,
        // MAROONA,
        // MARSHALL,
        // MARYBOROUGH,
        // MARYKNOLL,
        // MARYSVILLE,
        // MARYVALE,
        // MAUDE,
        // MCCRAE,
        MCKINNON,

        // [Display(Name = "MEADOW HEIGHTS")]
        // MEADOWHEIGHTS,

        // MEENIYAN,
        MELBOURNE,
        // MELTON,

        // [Display(Name = "MELTON SOUTH")]
        // MELTONSOUTH,

        // [Display(Name = "MELTON WEST")]
        // MELTONWEST,

        // MENTONE,

        // [Display(Name = "MENZIES CREEK")]
        // MENZIESCREEK,

        // MERBEIN,
        // MEREDITH,
        // MERINO,
        // MERNDA,
        MERRICKS,

        [Display(Name = "MERRICKS BEACH")]
        MERRICKSBEACH,

        // MERRIGUM,
        // MERRIJIG,
        // MERTON,
        // METCALFE,
        // METUNG,

        // [Display(Name = "MIA MIA")]
        // MIAMIA,

        // [Display(Name = "MIDDLE PARK")]
        // MIDDLEPARK,

        // MILAWA,
        // MILDURA,

        // [Display(Name = "MILL PARK")]
        // MILLPARK,

        // MILLGROVE,

        // [Display(Name = "MINERS REST")]
        // MINERSREST,

        // MINIMAY,
        // MININERA,
        // MINYIP,
        // MIRBOO,

        // [Display(Name = "MIRBOO NORTH")]
        // MIRBOONORTH,

        // MIRRANATWA,
        // MITCHAM,
        // MITIAMO,

        // [Display(Name = "MITTA MITTA")]
        // MITTAMITTA,

        // MODELLA,
        // MODEWARRE,
        // MOE,
        // MOLESWORTH,
        // MOLIAGUL,
        // MONBULK,

        // [Display(Name = "MONT ALBERT")]
        // MONTALBERT,

        // [Display(Name = "MONT ALBERT NORTH")]
        // MONTALBERTNORTH,

        // MONTMORENCY,
        // MONTROSE,
        // MOOLAP,
        // MOONAMBEL,

        // [Display(Name = "MOONEE PONDS")]
        // MOONEEPONDS,

        // MOORABBIN,
        // MOORALLA,
        MOOROODUC,
        // MOOROOLBARK,
        // MOOROOPNA,
        // MORDIALLOC,
        // MORIAC,
        MORNINGTON,
        // MORTLAKE,
        // MORWELL,

        // [Display(Name = "MOUNT BEAUTY")]
        // MOUNTBEAUTY,

        // [Display(Name = "MOUNT CLEAR")]
        // MOUNTCLEAR,

        // [Display(Name = "MOUNT DUNEED")]
        // MOUNTDUNEED,

        // [Display(Name = "MOUNT EGERTON")]
        // MOUNTEGERTON,

        [Display(Name = "MOUNT ELIZA")]
        MOUNTELIZA,

        // [Display(Name = "MOUNT EVELYN")]
        // MOUNTEVELYN,

        // [Display(Name = "MOUNT HELEN")]
        // MOUNTHELEN,

        // [Display(Name = "MOUNT MACEDON")]
        // MOUNTMACEDON,

        [Display(Name = "MOUNT MARTHA")]
        MOUNTMARTHA,

        // [Display(Name = "MOUNT PLEASANT")]
        // MOUNTPLEASANT,

        // [Display(Name = "MOUNT RICHMOND")]
        // MOUNTRICHMOND,

        // [Display(Name = "MOUNT ROWAN")]
        // MOUNTROWAN,

        [Display(Name = "MOUNT WAVERLEY")]
        MOUNTWAVERLEY,

        // MOYHU,
        // MOYSTON,

        // [Display(Name = "MT BULLER")]
        // MTBULLER,

        // [Display(Name = "MT DUNEED")]
        // MTDUNEED,

        // [Display(Name = "MT ELIZA")]
        // MTELIZA,

        // [Display(Name = "MT MORIAC")]
        // MTMORIAC,

        // [Display(Name = "MT ROWAN")]
        // MTROWAN,

        // [Display(Name = "MT WAVERLEY")]
        // MTWAVERLEY,

        // MUCKATAH,
        // MUCKLEFORD,

        // [Display(Name = "MUCKLEFORD SOUTH")]
        // MUCKLEFORDSOUTH,

        MULGRAVE,
        // MURCHISON,

        // [Display(Name = "MURCHISON EAST")]
        // MURCHISONEAST,

        // MURMUNGEE,
        // MURRABIT,
        // MURRAYVILLE,
        MURRUMBEENA,
        // MURTOA,
        // MYAMYN,
        // MYRNIONG,
        // MYRRHEE,
        // MYRTLEFORD,

        // [Display(Name = "MYSTIC PARK")]
        // MYSTICPARK,

        // NAGAMBIE,
        // NANDALY,
        // NANGILOC,
        // NANNEELLA,
        // NAPOLEONS,

        // [Display(Name = "NAR NAR GOON")]
        // NARNARGOON,

        // [Display(Name = "NAR NAR GOON NORTH")]
        // NARNARGOONNORTH,

        [Display(Name = "NARRE WARREN")]
        NARREWARREN,

        // [Display(Name = "NARRE WARREN EAST")]
        // NARREWARRENEAST,

        [Display(Name = "NARRE WARREN NORTH")]
        NARREWARRENNORTH,

        [Display(Name = "NARRE WARREN SOUTH")]
        NARREWARRENSOUTH,

        // NATHALIA,
        // NATIMUK,

        // [Display(Name = "NATTE YALLOCK")]
        // NATTEYALLOCK,

        // NAVARRE,
        // NAVIGATORS,
        // NEERIM,

        // [Display(Name = "NEERIM JUNCTION")]
        // NEERIMJUNCTION,

        // [Display(Name = "NEERIM SOUTH")]
        // NEERIMSOUTH,

        // NELSON,
        // NERRENA,

        // [Display(Name = "NEW GISBORNE")]
        // NEWGISBORNE,

        // NEWBOROUGH,
        // NEWBRIDGE,
        // NEWBURY,
        // NEWCOMB,
        // NEWHAM,
        // NEWHAVEN,
        // NEWLYN,
        // NEWMERELLA,
        // NEWPORT,
        // NEWRY,
        // NEWSTEAD,
        // NEWTOWN,
        // NHILL,

        // [Display(Name = "NICHOLS POINT")]
        // NICHOLSPOINT,

        // NIDDRIE,
        // NIRRANDA,

        // [Display(Name = "NOBLE PARK")]
        // NOBLEPARK,

        // [Display(Name = "NOBLE PARK NORTH")]
        // NOBLEPARKNORTH,

        // NOOJEE,
        // NOORAT,
        // NOORINBEE,
        // NORLANE,

        // [Display(Name = "NORTH BALWYN")]
        // NORTHBALWYN,

        // [Display(Name = "NORTH BENDIGO")]
        // NORTHBENDIGO,

        // [Display(Name = "NORTH BRIGHTON")]
        // NORTHBRIGHTON,


        // [Display(Name = "NORTH ESSENDON")]
        // NORTHESSENDON,


        // [Display(Name = "NORTH GEELONG")]
        // NORTHGEELONG,


        [Display(Name = "NORTH MELBOURNE")]
        NORTHMELBOURNE,

        // NORTHCOTE,


        [Display(Name = "NOTTING HILL")]
        NOTTINGHILL,


        // [Display(Name = "NOWA NOWA")]
        // NOWANOWA,

        // NULLAWIL,
        // NUMURKAH,
        // NUNAWADING,
        // NYAH,


        // [Display(Name = "NYAH WEST")]
        // NYAHWEST,

        // NYORA,


        // [Display(Name = "OAK PARK")]
        // OAKPARK,

        OAKLEIGH,


        [Display(Name = "OAKLEIGH SOUTH")]
        OAKLEIGHSOUTH,


        // [Display(Name = "OCEAN GROVE")]
        // OCEANGROVE,

        // OFFICER,
        // OLINDA,
        // OMEO,
        // ORBOST,
        ORMOND,
        // OUTRIM,
        // OUTTRIM,
        // OUYEN,
        // OXLEY,
        // PAKENHAM,


        // [Display(Name = "PAKENHAM SOUTH")]
        // PAKENHAMSOUTH,


        // [Display(Name = "PAKENHAM UPPER")]
        // PAKENHAMUPPER,

        // PANMURE,


        // [Display(Name = "PANTON HILL ")]
        // PANTONHILL,

        // PARAPARAP,


        // [Display(Name = "PARK ORCHARDS")]
        // PARKORCHARDS,

        // PARKDALE,
        PARKVILLE,


        // [Display(Name = "PASCOE VALE")]
        // PASCOEVALE,


        // [Display(Name = "PASCOE VALE SOUTH")]
        // PASCOEVALESOUTH,

        // PATCHEWOLLOCK,


        // [Display(Name = "PATTERSON LAKES")]
        // PATTERSONLAKES,

        // PAYNESVILLE,
        PEARCEDALE,
        // PEECHELBA,
        // PENNYROYAL,
        // PENSHURST,
        // PETERBOROUGH,


        // [Display(Name = "PHEASANT CREEK")]
        // PHEASANTCREEK,

        // PICOLA,


        // [Display(Name = "PIGEON PONDS")]
        // PIGEONPONDS,


        // [Display(Name = "PINE LODGE")]
        // PINELODGE,


        // [Display(Name = "PIRRON YALLOCK")]
        // PIRRONYALLOCK,

        // PLENTY,


        // [Display(Name = "POINT COOK")]
        // POINTCOOK,


        [Display(Name = "POINT LEO")]
        POINTLEO,


        // [Display(Name = "POINT LONSDALE")]
        // POINTLONSDALE,


        // [Display(Name = "POINT WILSON")]
        // POINTWILSON,

        // POMONAL,
        // POOWONG,
        // POREPUNKAH,


        // [Display(Name = "PORT CAMPBELL")]
        // PORTCAMPBELL,


        // [Display(Name = "PORT FAIRY")]
        // PORTFAIRY,


        [Display(Name = "PORT MELBOURNE")]
        PORTMELBOURNE,


        // [Display(Name = "PORT WELSHPOOL")]
        // PORTWELSHPOOL,

        // PORTARLINGTON,
        // PORTLAND,
        PORTSEA,
        // POWELLTOWN,


        // [Display(Name = "POWLETT PLAINS")]
        // POWLETTPLAINS,

        // PRAHRAN,
        // PRESTON,


        // [Display(Name = "PRINCES HILL")]
        // PRINCESHILL,


        // [Display(Name = "PRINCESS HILL")]
        // PRINCESSHILL,

        // PRINCETOWN,
        // PURNIM,
        // PYALONG,


        // [Display(Name = "PYRAMID HILLS")]
        // PYRAMIDHILLS,

        // QUAMBATOOK,
        // QUANTONG,


        // [Display(Name = "QUARRY HILL")]
        // QUARRYHILL,

        // QUEENSCLIFF,
        // QUEENSCLIFFE,
        // RAGLAN,
        // RAINBOW,
        // RAVENHALL,
        // RAVENSWOOD,
        // RAWSON,
        // RAYWOOD,


        // [Display(Name = "RED CLIFFS")]
        // REDCLIFFS,


        [Display(Name = "RED HILL")]
        REDHILL,

        // REDAN,
        // REDESDALE,
        // RESEARCH,
        // RESERVOIR,
        // RHYLL,


        // [Display(Name = "RICH AVON WEST")]
        // RICHAVONWEST,

        // RICHMOND,


        // [Display(Name = "RIDDELLS CREEK")]
        // RIDDELLSCREEK,

        // RINGWOOD,


        // [Display(Name = "RINGWOOD EAST")]
        // RINGWOODEAST,


        // [Display(Name = "RINGWOOD NORTH")]
        // RINGWOODNORTH,

        // ROBINVALE,
        // ROCHESTER,
        // ROCKBANK,
        // ROCKWOOD,
        // ROKEBY,
        // ROKEWOOD,
        // ROMSEY,
        // ROSANNA,
        ROSEBUD,


        [Display(Name = "ROSEBUD WEST")]
        ROSEBUDWEST,

        // ROSEDALE,


        // [Display(Name = "ROSS CREEK")]
        // ROSSCREEK,

        // ROWVILLE,


        // [Display(Name = "ROXBURGH PARK")]
        // ROXBURGHPARK,

        // RUFFY,
        // RUPANYUP,
        // RUSHWORTH,
        // RUTHERGLEN,
        RYE,


        [Display(Name = "SAFETY BEACH")]
        SAFETYBEACH,

        // SALE,


        // [Display(Name = "SAN REMO")]
        // SANREMO,

        // SANDFORD,


        // [Display(Name = "SANDHILL LAKE")]
        // SANDHILLLAKE,

        // SANDHURST,
        // SANDRINGHAM,


        // [Display(Name = "SANDY CREEK")]
        // SANDYCREEK,


        // [Display(Name = "SANDY POINT")]
        // SANDYPOINT,


        // [Display(Name = "SANY POINT")]
        // SANYPOINT,

        // SARSFIELD,
        // SCORESBY,


        // [Display(Name = "SCOTTS CREEK")]
        // SCOTTSCREEK,


        // [Display(Name = "SEA LAKE")]
        // SEALAKE,

        // SEABROOK,
        // SEAFORD,
        // SEAHOLME,
        // SEASPRAY,
        // SEBASTIAN,
        // SEBASTOPOL,
        // SELBY,
        // SERPENTINE,
        // SERVICETON,
        // SEVILLE,
        // SEYMOUR,


        // [Display(Name = "SHADY CREEK")]
        // SHADYCREEK,

        // SHELFORD,


        // [Display(Name = "SHEPHERDS FLAT")]
        // SHEPHERDSFLAT,

        // SHEPPARTON,


        // [Display(Name = "SHEPPARTON EAST")]
        // SHEPPARTONEAST,

        SHOREHAM,
        // SILVAN,
        // SIMPSON,
        // SKIPTON,
        // SKYE,
        // SMEATON,


        // [Display(Name = "SMITHS BEACH")]
        // SMITHSBEACH,

        // SMYTHESDALE,


        // [Display(Name = "SNAKE VALLEY")]
        // SNAKEVALLEY,

        SOMERS,
        // SOMERTON,
        SOMERVILLE,
        // SOMMERVILLE,
        SORRENTO,


        // [Display(Name = "SOUTH GEELONG")]
        // SOUTHGEELONG,


        [Display(Name = "SOUTH KENSINGTON")]
        SOUTHKENSINGTON,


        // [Display(Name = "SOUTH KINGSVILLE")]
        // SOUTHKINGSVILLE,


        // [Display(Name = "SOUTH MELBOURNE")]
        // SOUTHMELBOURNE,


        // [Display(Name = "SOUTH MORANG")]
        // SOUTHMORANG,


        // [Display(Name = "SOUTH WARRANDYTE")]
        // SOUTHWARRANDYTE,


        [Display(Name = "SOUTH YARRA")]
        SOUTHYARRA,

        SOUTHBANK,
        // SPEED,
        // SPOTSWOOD,


        // [Display(Name = "SPRING GULLY")]
        // SPRINGGULLY,

        // SPRINGHURST,
        // SPRINGVALE,


        // [Display(Name = "ST ALBANS")]
        // STALBANS,


        // [Display(Name = "ST ANDREWS")]
        // STANDREWS,


        // [Display(Name = "ST ANDREWS BEACH")]
        // STANDREWSBEACH,


        // [Display(Name = "ST ARNAUD")]
        // STARNAUD,


        // [Display(Name = "ST HELENA")]
        // STHELENA,


        // [Display(Name = "ST JAMES")]
        // STJAMES,


        // [Display(Name = "ST KILDA")]
        // STKILDA,


        // [Display(Name = "ST KILDA EAST")]
        // STKILDAEAST,


        // [Display(Name = "ST LEONARDS")]
        // STLEONARDS,



        // STANHOPE,
        // STANLEY,
        // STAWELL,
        // STOCKDALE,


        // [Display(Name = "STONY CREEK")]
        // STONYCREEK,

        // STRATFORD,


        // [Display(Name = "STRATH CREEK")]
        // STRATHCREEK,

        // STRATHBOGIE,
        // STRATHDALE,
        // STRATHEWEN,
        // STRATHFIELDSAYE,
        // STRATHMERTON,
        // STRATHMORE,


        // [Display(Name = "STRATHMORE HEIGHTS")]
        // STRATHMOREHEIGHTS,

        // STREATHAM,


        // [Display(Name = "STUART MILL")]
        // STUARTMILL,

        // SUNBURY,
        // SUNSHINE,


        // [Display(Name = "UNSHINE WEST")]
        // SUNSHINEWEST,


        // [Display(Name = "SURREY HILLS")]
        // SURREYHILLS,


        // [Display(Name = "SUTHERLANDS CREEK")]
        // SUTHERLANDSCREEK,


        // [Display(Name = "SUTTON GRANGE")]
        // SUTTONGRANGE,


        // [Display(Name = "SWAN HILL")]
        // SWANHILL,


        // [Display(Name = "SWAN MARSH")]
        // SWANMARSH,


        // [Display(Name = "SWAN REACH")]
        // SWANREACH,

        // SWANPOOL,


        // [Display(Name = "SWIFT CREEK")]
        // SWIFTCREEK,

        // SYDENHAM,
        // TAHARA,
        // TALAROOK,
        // TALBOT,
        // TALLANGATTA,
        // TALLAROOK,
        // TALLYGAROOPNA,
        // TANGAMBALANGA,
        // TARADALE,
        // TARNAGULLA,
        // TARNEIT,
        // TARRAGAL,
        // TARRAVILLE,
        // TARRAWINGEE,
        // TARRINGTON,
        // TARRONE,


        // [Display(Name = "TARWIN LOWER")]
        // TARWINLOWER,

        // TATONG,
        // TATURA,
        // TATYOON,
        // TAWONGA,


        // [Display(Name = "TAYLORS LAKES")]
        // TAYLORSLAKES,

        // TEESDALE,


        // [Display(Name = "TELANGATUK EAST")]
        // TELANGATUKEAST,

        // TEMPLESTOWE,
        // TEMPY,
        // TENNYSON,
        // TERANG,


        // [Display(Name = "TERIP TERIP")]
        // TERIPTERIP,

        // THALLOO,


        // [Display(Name = "THE BASIN")]
        // THEBASIN,

        // THOMASTOWN,
        // THOMSON,
        // THORNBURY,
        // THORNTON,
        // THORPDALE,
        // TIMBOON,
        // TINAMBA,
        // TINTALDRA,
        // TOLMIE,
        // TONGALA,
        // TONGIO,
        // TOOBORAC,
        // TOOLAMBA,
        // TOOLANGI,
        // TOOLLEEN,
        // TOOLONDO,
        // TOONGABBIE,
        // TOORA,
        TOORADIN,
        // TOORAK,


        // [Display(Name = "TOORLERN VALE")]
        // TOORLERNVALE,

        TOOTGAROOK,
        // TORQUAY,
        // TORRITA,
        // TRAFALGAR,
        // TRARALGON,


        // [Display(Name = "TRARALGON SOUTH")]
        // TRARALGONSOUTH,

        // TRENTHAM,
        // TRUGANINA,
        // TUERONG,
        // TULLAMARINE,
        // TUNGAMAH,
        TYABB,
        // TYERS,
        // TYLDEN,
        // TYNONG,


        // [Display(Name = "TYNTYNDER SOUTH")]
        // TYNTYNDERSOUTH,

        // TYRENDARRA,
        // ULTIMA,
        // UNDERA,
        // UNDERBOOL,


        // [Display(Name = "UPPER BEACONSFIELD")]
        // UPPERBEACONSFIELD,


        // [Display(Name = "UPPER FERNTREE GULLY")]
        // UPPERFERNTREEGULLY,

        // UPWEY,
        // VENTNOR,


        // [Display(Name = "VENUS BAY")]
        // VENUSBAY,

        // VERMONT,


        // [Display(Name = "VERMONT SOUTH")]
        // VERMONTSOUTH,

        // VIEWBANK,
        // VINIFERA,


        // [Display(Name = "VIOLET TOWN")]
        // VIOLETTOWN,

        // WAAIA,
        // WAHGUNYA,
        // WALLACE,
        // WALLACEDALE,
        // WALLALOO,
        // WALLAN,
        // WALLINGTON,
        // WALPEUP,
        // WALWA,


        // [Display(Name = "WANDANA HEIGHTS")]
        // WANDANAHEIGHTS,

        // WANDELLA,
        // WANDILIGONG,


        // [Display(Name = "WANDIN EAST")]
        // WANDINEAST,


        // [Display(Name = "WANDIN NORTH")]
        // WANDINNORTH,


        // [Display(Name = "WANDO VALE")]
        // WANDOVALE,

        // WANDONG,
        // WANGANDARY,
        // WANGARATTA,
        // WANGARTTA,
        // WANGOOM,
        // WANTIRNA,


        // [Display(Name = "WANTIRNA SOUTH")]
        // WANTIRNASOUTH,

        // WARBURTON,
        // WARNCOORT,
        WARNEET,
        // WARRACKNABEAL,
        // WARRAGUL,


        // [Display(Name = "WARRAGUL NORTH")]
        // WARRAGULNORTH,


        // [Display(Name = "WARRAGUL SOUTH")]
        // WARRAGULSOUTH,

        // WARRAK,
        // WARRANDYTE,
        // WARRENBAYNE,
        // WARRION,
        // WARRNAMBOOL,
        // WATCHEM,
        // WATSONIA,


        // [Display(Name = "WATTLE GLEN")]
        // WATTLEGLEN,

        // WAUBRA,


        // [Display(Name = "WAURN PONDS")]
        // WAURNPONDS,

        // WEDDERBURN,
        // WELSHPOOL,
        // WENDOUREE,


        // [Display(Name = "WENDOUREE WEST")]
        // WENDOUREEWEST,

        // WERRIBEE,
        // WESBURN,


        // [Display(Name = "WEST FOOTSCRAY")]
        // WESTFOOTSCRAY,


        // [Display(Name = "WEST HEIDELBERG")]
        // WESTHEIDELBERG,


        [Display(Name = "WEST MELBOURNE")]
        WESTMELBOURNE,


        // [Display(Name = "WEST PRESTON")]
        // WESTPRESTON,

        // WESTMEADOWS,


        // [Display(Name = "WHEELERS HILL")]
        // WHEELERSHILL,


        // [Display(Name = "WHITE HILLS")]
        // WHITEHILLS,

        // WHITFIELD,
        // WHITTINGTON,
        // WHITTLESEA,
        // WHOROULY,
        // WICKLIFFE,
        // WILBY,
        // WILLIAMSTOWN,


        // [Display(Name = "WILLIAMSTOWN NORTH")]
        // WILLIAMSTOWNNORTH,

        // WILLLAURA,


        // [Display(Name = "WILLOW GROVE")]
        // WILLOWGROVE,

        // WINCHELSEA,
        // WINDSOR,
        // WINSLOW,
        // WINTON,
        // WODONGA,
        // WOLLERT,
        // WONDONGA,


        // [Display(Name = "WONGA PARK")]
        // WONGAPARK,

        // WONTHAGGI,
        // WONTHAGGIE,
        // WOODEND,
        // WOODFORD,


        // [Display(Name = "WOODS POINT")]
        // WOODSPOINT,

        // WOODSIDE,


        // [Display(Name = "WOODSIDE BEACH")]
        // WOODSIDEBEACH,

        // WOODVALE,
        // WOOLAMAI,
        // WOOLSTHORPE,
        // WOOMELANG,


        // [Display(Name = "WOORI YALLOCK")]
        // WOORIYALLOCK,

        // WOORINEN,
        // WOORNDOO,


        // [Display(Name = "WOOTONG VALE")]
        // WOOTONGVALE,

        // WORAGEE,
        // WUNGHNU,
        // WURRUK,


        // [Display(Name = "WY YUNG")]
        // WYYUNG,

        // WYCHEPROOF,


        // [Display(Name = "WYE RIVER")]
        // WYERIVER,


        // [Display(Name = "WYNDHAM VALE")]
        // WYNDHAMVALE,

        // WYUNA,
        // YAAPEET,
        // YACKANDANDAH,
        // YALLAMBIE,
        // YALLOURN,


        // [Display(Name = "YALLOURN NORTH")]
        // YALLOURNNORTH,

        // YAMBUK,


        // [Display(Name = "YAN YEAN")]
        // YANYEAN,

        // YANAC,
        // YANAKIE,
        // YANNATHAN,
        // YAPEEN,
        // YARCK,


        // [Display(Name = "YARRA GLEN")]
        // YARRAGLEN,


        // [Display(Name = "YARRA JUNCTION")]
        // YARRAJUNCTION,

        // YARRAGON,
        // YARRAGOON,
        // YARRAM,
        // YARRAMBAT,
        // YARRAVILLE,
        // YARRAWONGA,
        // YARROWEYAH,
        // YEA,
        // YELLINGBO,
        // YENDON,
        // YEO,
        // YERING,
        // YINNAR,


        // [Display(Name = "YINNAR SOUTH")]
        // YINNARSOUTH,

        // YULECART,

    }
}