using Assets.Scripts.Interfaces;
using Assets.Scripts.Items;
using Assets.Scripts.World;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using static UnityEditor.Progress;



namespace Assets.Scripts.Enemies
{
    internal class Samurai: Enemies 
    {
      

        internal override int BasicAtack(int Damage)
        {
         
           return hp =hp- Damage;                    
        }
        internal override int DamageDone(int Damage)
        {
            return hp = hp - Damage;
        }
      

    }

}
