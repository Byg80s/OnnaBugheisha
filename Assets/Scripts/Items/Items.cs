using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Assets.Scripts.Items
{
    
    public enum BaseItems{
        Weapon,Armor, Consumibles,PowerUps

    }
    public  class ItemsPropierties
    {
        //Variables
     
        public uint iD;
        public string name;
        
        public  string type;

        public  bool placeable;
        public  bool isWeapon;
        public  bool isConsumbale;
        public  bool isPowerUp;

        public  int damage;
        public  int recoveryHp;
        public  int durability;

        public  int price;
        public  int amount;

        /// <summary>If item is a consumibe recovery health</summary>
     
        public virtual void CreateItem (uint id, int recoveryHp, string type, string name, bool isConsumble, int amount)
        {
            this.iD = id;
            this.recoveryHp = recoveryHp;
            this.type = type;
            this.name = name;
            this.isConsumbale = isConsumble;
            this.amount=amount;
        }
    
    }   
   
}

