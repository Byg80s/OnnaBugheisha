using Assets.Scripts.Items;
using Assets.Scripts.World;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

public class ItemManager : MonoBehaviour
{

    GameObject GameObject;
    ItemsConsumibles Abalone, Bold;
    WeaponsItems makibishi;
    int recoveryHp;


    public readonly List<WeaponsItems>weapons = new List<WeaponsItems>();
    public readonly List<ItemsConsumibles> consumibles = new List<ItemsConsumibles>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       ItemsWeapons();
       ItemsConsumibles();
        consumibles.Add(Abalone);
        consumibles.Add(Bold);


      //  Debug.Log(consumibles.Count);
      

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var items in consumibles)
        {
        //    Debug.Log(consumibles);
        }

    }
    private void OnTriggerEnter(Collider other)

    {
        if(GameObject== gameObject.CompareTag("Abalone"))
        {
         
        }
       

    }

    protected void ItemsConsumibles()
    {
        Abalone = new ItemsConsumibles(Consumibles.abalone, 10, "Consumible", "Abalone", true, 1);
        Bold = new ItemsConsumibles(Consumibles.ankoro, 20, "Consumible", "Bold", false, 1);
    }
    protected void ItemsWeapons()
    {
        makibishi = new WeaponsItems(Weapons.makibishi, 5, 1, 5, "Makibishi", 1);
    }

}
