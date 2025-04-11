using System;
using System.Collections.Generic;
using Assets.Scripts.Items;
using Assets.Scripts.World;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

namespace Assets.Scripts.Items
{


    /// <summary>Id items consumibles</summary>
    public struct Consumibles
    {
        //VARIABLES 100100

        public const uint boiledChikuzen = 100100;
        public const uint boiledFlatfish = 100101;
        public const uint boiledRape = 100102;
        public const uint boiledWakatake = 100103;
        public const uint chickenBreast = 100104;
        public const uint deepFriedChicken = 100105;
        public const uint deepFriedJinkasa = 100106;
        public const uint deepFriedTofu = 100107;
        public const uint friedSpringRoll = 100108;
        public const uint mackerelMiso = 100109;
        public const uint meatAndPotato = 100110;
        public const uint misoDengaku = 100111;
        public const uint misoSoup = 100112;
        public const uint natto = 100113;
        public const uint okara = 100114;
        public const uint oshinko = 100115;
        public const uint rawEgg = 100116;
        public const uint saltedGrilled = 100117;
        public const uint stewedChickenWings = 100118;
        public const uint tororo = 100119;
        public const uint udoNuta = 100120;
        public const uint ankoro = 100121;
        public const uint assortedSashimi = 100122;
        public const uint deepFriedBlowfish = 100123;
        public const uint deepFriedChickens = 100124;
        public const uint eelLiverSoup = 100125;
        public const uint eelTempura = 100126;
        public const uint fuguPorridge = 100127;
        public const uint grilledBlowfishMilt = 100128;
        public const uint grilledEel = 100129;
        public const uint horseMeatSashimi = 100130;
        public const uint iseLobsterMiso = 100131;
        public const uint mitarashiDango = 100132;
        public const uint pufferfishSavoryEggCustard = 100133;
        public const uint rawOyster = 100134;
        public const uint roastedEel = 100135;
        public const uint savoryEggCustard = 100136;
        public const uint skewersALaCarte = 100137;
        public const uint squidInkSoup = 100138;
        public const uint supponHotPot = 100139;
        public const uint tecchiri = 100140;
        public const uint tessa = 100141;
        public const uint tessaAndTeckchiri = 100142;


        //VARIABLES 100200

        public const uint aimedSetMeal = 100200;
        public const uint BeefBowlExtraLarge = 100201;
        public const uint beefBowlLarge = 100202;
        public const uint beefBowlMedium = 100203;
        public const uint cookedRice = 100204;
        public const uint croquetteSetMeal = 100205;
        public const uint croquetteSetMelOk = 100206;
        public const uint dashimakiSetMeal = 100207;
        public const uint eelChazuke = 100208;
        public const uint frielSardineSetMeal = 100209;
        public const uint grilledMackerelSetMeal = 100210;
        public const uint grilledSalmonSetMeal = 100211;
        public const uint katsuDon = 100212;
        public const uint lunchSetMealJibuNiSetMeal = 100213;
        public const uint lunchSetMealSeasonalVegetableJapanese = 100214;
        public const uint makerelMisoSetMeal = 100215;
        public const uint ochazukeSalmon = 100216;
        public const uint oyakoDon = 100217;
        public const uint rice = 100218;
        public const uint riceLarge = 100219;
        public const uint unajyuMatsu = 100220;
        public const uint unajyuTake = 100221;
        public const uint unajyuUme = 100222;

        //VARIABLES 100300

        public const uint abalone = 100300;
        public const uint battera = 100301;
        public const uint coldYellowtail = 100302;
        public const uint cucumberRoll = 100303;
        public const uint driedGourd = 100304;
        public const uint fattyTunaMeat = 100305;
        public const uint flounder = 100306;
        public const uint flounderEdge = 100307;
        public const uint handFormedSushiAmberJack = 100308;
        public const uint handFormedSushiCongerEel = 100309;
        public const uint handFormedSushiEgg = 100310;
        public const uint handFormedSushiHorseMackerel = 100311;
        public const uint handFormedSushiMediumTuna = 100312;
        public const uint handFormedSushiOctopus = 100313;
        public const uint handFormedSushiSalmon = 100314;
        public const uint handFormedSushiShrimp = 100315;
        public const uint handFormedSushiSquid = 100316;
        public const uint handFormedSushiTuna = 100317;
        public const uint handFormedSushiVinegaredMackerel = 100318;
        public const uint homemadeEggRoll = 100319;
        public const uint inariSushi = 100320;
        public const uint kohada = 100321;
        public const uint liveSquid = 100322;
        public const uint mediumFattyTuna = 100323;
        public const uint milt = 100324;
        public const uint nattoRoll = 100325;
        public const uint oneCongerEel = 100326;
        public const uint oneKingCrab = 100327;
        public const uint peonyShrimp = 100328;
        public const uint pickledRadishRoll = 100329;
        public const uint redSeaBream = 100330;
        public const uint saladRoll = 100331;
        public const uint salmonRoe = 100332;
        public const uint salmonRoeWarshipWinding = 100333;
        public const uint seaChickenRoll = 100334;
        public const uint seaUrchin = 100335;
        public const uint seaUrchinWarshipWinding = 100336;
        public const uint stripedJack = 100337;
        public const uint superFattyTuna = 100338;
        public const uint tuna = 100339;

    }


    public class ItemsConsumibles // : ItemsPropierties
    {
        //Variables Generales






        /// <summary>Propierties of consumibles items Class</summary>
        internal ItemsConsumibles(uint id, int recoveryHp, string type, string name, bool isConsumble, int amount)
        {
            var ConsumibleIts = new ItemsPropierties();
            ConsumibleIts.iD = id;
            ConsumibleIts.recoveryHp = recoveryHp;
            ConsumibleIts.type = type;
            ConsumibleIts.name = name;
            ConsumibleIts.isConsumbale = isConsumble;
            ConsumibleIts.amount = amount;


        }
        /*      

               internal ItemsConsumibles(uint id, int recoveryHp, string type, string name, bool isConsumble, int amount)
                       {

                           this.iD = id;
                           this.recoveryHp = recoveryHp;
                           this.type = type;
                           this.name = name;
                           this.isConsumbale = isConsumble;
                           this.amount = amount;



                       }
     
        public override void CreateItem(uint id, int recoveryHp, string type, string name, bool isConsumble, int amount)
        {

        }
            */

    }

}

