﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Shapes;

namespace Magitek.Utilities
{
    internal static class Auras
    {
        public const int
            Stun = 2,
            Doom = 1769,
            Raise = 148,
            Feint = 1195,
            BattleVoice = 141,
            Swiftcast = 167,
            Aero = 143,
            Aero2 = 144,
            Medica2 = 150,
            Freecure = 155,
            Regen = 158,
            Regen2 = 627,
            AsylumEmitter = 1911,
            AsylumReceiver = 1912,
            DivineSeal = 159,
            ShroudOfSaints = 154,
            PresenceOfMind = 157,
            Bio2 = 189,
            Miasma = 180,
            Bio = 179,
            Aetherflow = 304,
            AetherialAttunement = 807,
            RadiantAegis = 2702,
            Rekindle = 2704,
            IfritsFavor = 2724,
            TitansFavor = 2853,
            GarudasFavor = 2725,
            EmergencyTactics = 792,
            Dissipation = 791,
            Galvanize = 297,
            SacredSoilEmitter = 1944,
            SacredSoilReceiver = 299,
            WhisperingDawn = 315,
            AngelsWhisper = 1874,
            Catalyze = 1918,
            Combust = 838,
            Combust2 = 843,
            Combust3 = 1881,
            EnhancedBenefic2 = 815,
            AspectedBenefic = 835,
            AspectedHelios = 836,
            DiurnalSect = 839,
            NocturnalSect = 840,
            EyesOpen = 1252,
            NocturnalField = 837,
            SynastrySource = 845,
            LeyLines = 737,
            SynastryDestination = 846,
            NeutralSect = 1892,
            NeutralSectShield = 1921,
            Lightspeed = 841,
            WheelOfFortune = 956,
            CollectiveUnconsciousMitigation = 849,
            DiurnalIntersection = 1888,
            Opposition = 1879,
            Horoscope = 1890,
            HoroscopeHelios = 1891,
            TheBalance = 1882,
            TheBole = 1883,
            TheArrow = 1884,
            TheSpear = 1885,
            TheEwer = 1886,
            TheSpire = 1887,
            LordofCrowns = 1451,
            LordofCrowns2 = 1876,
            LordOfCrownsDrawn = 2054,
            LadyofCrowns = 1452,
            LadyofCrowns2 = 1877,
            LadyOfCrownsDrawn = 2055,
            ClarifyingDraw = 2713,
            Exaltation = 2717,
            CelestialIntersection = 1887,
            Macrocosmos = 2718,
            Disembowel = 1914,
            SharperFangandClaw = 802,
            EnhancedWheelingThrust = 803,
            RightEye = 1453,
            LeftEye = 1454,
            Medicated = 49,
            HawksEye = 3861,
            VenomousBite = 124,
            RagingStrikes = 125,
            RadiantFinale = 2722,
            Barrage = 128,
            Windbite = 129,
            Foresight = 83,
            HallowedGround = 82,
            IronWill = 79,
            Rampart = 1191,
            Sentinel = 74,
            GoringBlade = 725,
            BladeOfValor = 2721,
            Shadowskin = 740,
            BloodWeapon = 742,
            Grit = 743,
            DarkDance = 744,
            DarkMind = 746,
            ShadowWall = 747,
            SaltedEarth = 749,
            Darkside = 751,
            Reprisal = 1193,
            LivingDead = 810,
            WalkingDead = 811,
            DragonKick = 98,
            TwinSnakes = 101,
            DisciplinedFist = 3001,
            FistsofFire = 103,
            FistsofEarth = 104,
            FistsofWind = 105,
            OpoOpoForm = 107,
            RaptorForm = 108,
            CoeurlForm = 109,
            PerfectBalance = 110,
            Demolish = 246,
            Brotherhood = 1185,
            MeikyoShisui = 1233,
            Jinpu = 1298,
            Shifu = 1299,
            Requiescat = 1368,
            Higanbana = 1228,
            EnhancedEnpi = 1236,
            ThinAir = 1217,
            CausticBite = 1200,
            Stormbite = 1201,
            Bio3 = 1214,
            Miasma3 = 1215,
            Confession = 1219,
            Aquaveil = 2708,
            VerfireReady = 1234,
            VerstoneReady = 1235,
            Dualcast = 1249,
            Manafication = 1971,
            StormsEye = 90,
            Deliverance = 729,
            Defiance = 91,
            InnerRelease = 1177,
            RawIntuition = 735,
            Vengeance = 89,
            Holmgang = 409,
            Suiton = 507,
            Duality = 790,
            TenChiJin = 1186,
            Thunder = 161,
            Thunder2 = 162,
            Thunder3 = 163,
            FireStarter = 165,
            ThunderCloud = 164,
            Sharpcast = 867,
            Thunder4 = 1210,
            FeyUnion = 1222,
            FeyUnion2 = 1223,
            SeraphicVeil = 1917,
            DiveReady = 1243,
            BlackestNight = 1178,
            Excogitation = 1220,
            Protraction = 2710,
            Expedience = 2712,
            DesperateMeasures = 2711,
            DivineBenison = 1218,
            DivineBenison2 = 1404,
            Peloton = 1199,
            Kaiten = 1229,
            Triplecast = 1211,
            LucidDreaming = 1204,
            EarthlyDominance = 1224,
            GiantDominance = 1248,
            HotShot = 855,
            Wildfire = 861,
            Flamethrower = 1205,
            TrueNorth = 1250,
            Doton = 501,
            FurtherRuin = 2701,
            MountedPvp = 1420,
            RegenPvp = 1330,
            DivineBenisonPvp = 1404,
            MagicResistance = 942,
            TrickAttack = 3254,
            VulnerabilityUp = 638,
            FlourshingCascade = 1814,
            FlourishingFountain = 1815,
            FlourshingWindmill = 1816,
            FlourshingShower = 1817,
            SilkenFlow = 2694,
            StandardStep = 1818,
            TechnicalStep = 1819,
            FlourishingFanDance = 1820,
            StandardFinish = 1821,
            RaidenReady = 1863,
            TechnicalFinish = 1822,
            ClosedPosition = 1823,
            DancePartner = 1824,
            Devilment = 1825,
            ShieldSamba = 1826,
            AtonementReady = 1902,
            FightOrFlight = 76,
            Ruination = 1291,
            Dia = 1871,
            Biolysis = 1895,
            Bioblaster = 1866,
            HellishConduit = 1867,
            Troubadour = 1934,
            WildfireBuff = 1946,
            Mudra = 496,
            Recitation = 1896,
            LeadenFist = 1861,
            Kassatsu = 497,
            AssassinateReady = 1955,
            Camouflage = 1832,
            Nebula = 1834,
            Aurora = 1835,
            Superbolide = 1836,
            HeartofLight = 1839,
            HeartofStone = 1840,
            NoMercy = 1831,
            ReadytoRip = 1842,
            ReadytoTear = 1843,
            ReadytoGouge = 1844,
            Reassembled = 851,
            NascentChaos = 1897,
            NascentGlint = 1858,
            StemTheFlow = 2679,
            StemTheTide = 2680,
            RoyalGuard = 1833,
            DarkMissionary = 1894,
            Delirium = 1972,
            PassageOfArms = 1175,
            RiddleOfEarth = 1179,
            Anatman = 1862,
            EverlastingFlight = 2030,
            Acceleration = 1238,
            Divination = 1878,
            Embolden = 1239,
            MeditationSAM = 2176,
            OffGuard = 1717,
            Bleeding = 1714,
            Boost = 1716,
            Temperance = 1872,
            FormlessFist = 2513,
            RiddleOfFire = 1181,
            WaxingNocturne = 1718,
            WaningNocturne = 1727,
            PeculiarLight = 1721,
            PhantomFlurry = 2502,
            Harmonized = 2118,
            Tingle = 2492,
            AetherialMimicryHealer = 2126,
            AetherialMimicryDps = 2125,
            AetherialMimicryTank = 2124,
            CriticalStrikes = 1797,
            BlastArrowReady = 2692,
            OgiReady = 2959,
            ShadowBiteReady = 3002,
            PrimalRendReady = 2624,
            ArmysPaeon = 2218,
            MagesBallad = 2217,
            TheWanderersMinuet = 2216,
            BattleLitany = 786,
            ArcaneCircle = 2599,
            SearingLight = 2703,
            ChainStratagem = 1406,
            DeathsDesign = 2586,
            SoulReaver = 2587,
            EnhancedGibbet = 2588,
            EnhancedGallows = 2589,
            EnhancedHarpe = 2845,
            EnhancedFlare = 2960,
            Kardion = 2605,
            Kardia = 2604,
            Soteria = 2610,
            Taurochole = 2619,
            Krasis = 2622,
            Zoe = 2611,
            Eukrasia = 2606,
            EukrasianDosis = 2614,
            EukrasianDosisII = 2615,
            EukrasianDosisIII = 2616,
            EukrasianDiagnosis = 2607,
            Kerachole = 2618,
            Kerakeia = 2938,
            Physis = 2617,
            PhysisII = 2620,
            Autophysis = 2621,
            Haimatinon = 2642,
            Haima = 2612,
            Panhaimatinon = 2643,
            Panhaima = 2613,
            EukrasianPrognosis = 2609,
            Holos = 3003,
            SurgingTempest = 2677,
            ThrillOfBattle = 87,
            Bloodwhetting = 2678,
            EnhancedVoidReaping = 2590,
            EnhancedCrossReaping = 2591,
            ImmortalSacrifice = 2592,
            Enshrouded = 2593,
            Soulsow = 2594,
            BloodsownCircle = 2601,
            CrestOfTimeReturned = 2598,
            CrestOfTimeBorrowed = 2597,
            FlourishingSymmetry = 3017,
            SilkenSymmetry = 2693,
            FlourishingFlow = 3018,
            FlourishingFinish = 2698,
            ThreefoldFanDance = 1820,
            FourfoldFanDance = 2699,
            FlourishingStarfall = 2700,
            HeartOfCorundum = 2683,
            CatharsisOfCorundum = 2685,
            ClarityOfCorundum = 2684,
            ShakeItOff = 1993,
            ReadytoBlast = 2686,
            SonicBreak = 1837,
            BowShock = 1838,
            DraconianFire = 1863,
            PowerSurge = 2720,
            ChaoticSpring = 2719,
            ChaosThrust = 118,
            LanceCharge = 1864,
            Equilibrium = 2681,
            Oblation = 2682,
            RaijuReady = 2690,
            Meisui = 2689,
            Weakness = 43,
            ArmysMuse = 1932,
            ConfiteorReady = 3019,
            DivineMight = 2673,
            CircleofScorn = 248,
            Bunshin = 1954,
            PhantomKamaitachiReady = 2723,
            SupplicationReady = 3827,
            SepulchreReady = 3828,
            ImpactImminent = 3882;
        
        private const int
            Invincibility0 = 981,
            Invincibility1 = 969,
            Invincibility2 = 895,
            Invincibility3 = 776,
            Invincibility4 = 775,
            Invincibility5 = 671,
            Invincibility6 = 656,
            Invincibility7 = 529,
            Invincibility8 = 325;

        public const int

        #region PVP Specific

            PvpSynastrySource = 1336,
            PvpSynastryDestination = 1337,
            PvpAbridged = 1335,
            PvpLightspeed = 1403,
            PvpFireResonance = 3170,
            PvpEarthResonance = 3171,
            PvpWindResonance = 2007,
            PvpPressurePoint = 3172,
            DrillPrimed = 3150,
            BioPrimed = 3151,
            AirAnchorPrimed = 3152,
            ChainSawPrimed = 3153,
            Analysis = 3158,
            Overheated = 3149,
            Guard = 3054,
            CureIIIReady = 3083,
            PvpAquaveil = 3086,
            Mummification = 3091,
            PvpExpedience = 3092,
            PvpGalvanize = 3087,
            DiurnalBenefic = 3099,
            PvpMacrocosmos = 3104,
            BalanceDrawn = 3101,
            BoleDrawn = 3403,
            ArrowDrawn = 3404,
            PvpKardia = 2871,
            PvpKardion = 2872,
            PvpEukrasias = 2867,
            Addersting = 3115,
            AstralFireIII = 3381,
            PvpSwiftcast = 1987,
            PvpMagickBarrier = 3240,
            WhiteShift = 3245,
            BlackShift = 3246,
            VermilionRadiance = 3233,
            AstralWarmth = 3216,
            UmbralFreeze = 3217,
            DeepFreeze = 3219,
            PvpBiolytic = 3090,
            PvpCatalyze = 3088,
            PvpHidden = 1316,
            PvpThreeMudra = 1317,
            FleetingRaijuReady = 3211,
            PvpLifeoftheDragon = 3177,
            PvpHeavensent = 3176,
            PvpFirstmindsFocus = 3178,
            PvpOgiNamikiri = 3199,
            PvpMidare = 3203,
            PvpKuzushi = 3202,
            PvpKaiten = 3201,
            PvpSoulsow = 2750, 
            PvpEnshrouded = 2863,
            PvpRipeforReaping = 2858,
            PvpImmortalSacrifice = 3204,
            PvpNoMercy  = 3042,
            PvpRelentlessRush = 3052,
            PvpBlackblood = 3033,
            PvpDarkArts = 3034,
            PvpSwordOath = 1991, 
            PvpHallowedGround  = 1302,
            PvpOnslaught = 3029,
            PvpOrogeny = 3256;


        #endregion

        public static readonly List<uint> Invincibility = new List<uint>
        {
            Invincibility0,
            Invincibility1,
            Invincibility2,
            Invincibility3,
            Invincibility4,
            Invincibility5,
            Invincibility6,
            Invincibility7,
            Invincibility8
        };
    }
}
