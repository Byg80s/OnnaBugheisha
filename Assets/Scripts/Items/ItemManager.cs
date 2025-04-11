using Assets.Scripts.Items;
using Assets.Scripts.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using static UnityEditor.Progress;
using static UnityEngine.Rendering.DebugUI;

public class ItemManager : MonoBehaviour
{

    GameObject GameObject;
    ItemsConsumibles Abalone, Bold;
    WeaponsItems makibishi;
    int recoveryHp;
    public uint idValue;
    public string newname, newType;

    public readonly List<WeaponsItems> weapons = new List<WeaponsItems>();
    public readonly List<ItemsConsumibles> consumibles = new List<ItemsConsumibles>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //CALL METHODS

        ItemsWeapons();
        ItemsConsumibles();

        //ADD TO LIST
        consumibles.Add(Abalone);
        consumibles.Add(Bold);


        /*
        var NewConsumible = new List<ItemsConsumibles>();

        idValue = NewConsumible.iD;
        newname = NewConsumible.name;
        newType = NewConsumible.type;
         */

        //Check value in list
        var NewConsumible = (ItemsConsumibles)consumibles[0]; // var NewConsumible = (ItemsPropierties)consumibles[0];
        idValue = NewConsumible.iD;
        newname = NewConsumible.name;
        newType = NewConsumible.type;

        Debug.Log("Id of first element is: " + idValue);
        Debug.Log("Name of first element is: " + name);
        Debug.Log("Type is: "+ newType);
      




        //CHECK FOR NUMBERS ELEMENTS ARE ADD IN THE LIST CONSUMABLES
        Debug.Log("En la lista hay: " + consumibles.Count);

          if (NewConsumible != null)

              Debug.Log(" HAY CONTENIDO EN LA LISTA: ");

          else
              Debug.Log("ESTA VACIA");
        



    }

  
    void Update()
    {
        foreach (var items in consumibles)
        {
            Debug.Log(idValue + " " + newname + " " + newType);

        }


    }
    private void OnTriggerEnter(Collider other)

    {
        if (GameObject == gameObject.CompareTag("Abalone"))
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
