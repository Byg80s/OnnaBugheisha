using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Items
{
    public struct Weapons
    {
        //VARIABLES 200100
        public const uint makibishi = 200100;
        public const uint kunaiKnife = 200101;
        public const uint sai = 200102;
        public const uint kama = 200103;
        public const uint kusarigama = 200104;
        public const uint nekoTe = 200105;
        public const uint tetsubokanabo = 200106;
        public const uint nunchaku = 200107;
        public const uint chigiriki = 200108;
        public const uint kusariFundo = 200109;
        public const uint shobo = 200110;
        public const uint suntetsu = 200111;
        public const uint kuoketsuShoge = 200112;
        public const uint shuriken = 200113;
        public const uint tekko = 200114;
        public const uint tekagiShuko = 200115;
        public const uint jitte = 200116;
        public const uint tonfa = 200117;
        public const uint ono = 200118;
        public const uint kuwa = 200119;
        public const uint masakari = 200120;
        public const uint eku = 200121;
        public const uint nagamaki = 200122;
        public const uint naginata = 200123;
        public const uint suYari = 200124;
        public const uint tsukiNariYari = 200125;
        public const uint yajiriNariYari = 200126;
        public const uint bishamonYari = 200127;
        public const uint kagiYari = 200128;
        public const uint kamaYari = 200129;
        public const uint kataKamaYari = 200130;
        public const uint juMonjiYari = 200131;
        public const uint kikichiYari = 200132;
        public const uint sasumata = 200133;
        public const uint otsuchi = 200134;
        public const uint tanto = 200135;
        public const uint wakizashi = 200136;
        public const uint ninjato = 200137;
        public const uint daito = 200138;
        public const uint odachi = 200139;
        public const uint tsukubo = 200140;
        public const uint gunsen = 200141;
        public const uint tessen = 200142;
        public const uint saihai = 200143;
        public const uint uchiwa = 200144;
        public const uint dansenUchiwa = 200145;


    }

public class WeaponsItems
    {
    
        internal WeaponsItems(uint id, int durability, int amount, int damage, string name, int price)
        {
            var WeaponsPropierties= new ItemsPropierties();
            WeaponsPropierties.iD=id;
            WeaponsPropierties.durability=durability;
            WeaponsPropierties.amount=amount; 
            WeaponsPropierties.damage=damage;
            WeaponsPropierties.name=name;
            WeaponsPropierties.price = price;


        }

    }
}

