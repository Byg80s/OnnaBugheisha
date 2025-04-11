using Assets.Scripts.Enemies;
using Assets.Scripts.Interfaces;
using System.Collections.Generic;
using UnityEngine;

public class EnemieManager : MonoBehaviour
{
    int actualHp;
    int newHp;
    int newDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var enemie = new List<Enemies>();
        enemie.Add(new Ronin());
        enemie.Add(new Samurai());
        enemie.Add(new Shinsengumi());
        var Samurai = (Samurai)enemie[1];

        Samurai.hp = 100;
        actualHp = Samurai.hp;
        newDamage = Samurai.BasicAtack(10);

        newHp = Samurai.hp;




    }

    // Update is called once per frame
    void Update()
    {

        //    SamuraiAtack();
        //    ShinsengumiAtack();
        Debug.Log("The initial hp is: " + actualHp);
        Debug.Log(" the hp of samurai is: " + newHp);


    }

    void SamuraiAtack()
    {
        var Samurai = new Samurai();
        Samurai.hp = 100;
        Samurai.BasicAtack(10);
        Debug.Log("The actual hp is:" + Samurai.hp);

    }
    void ShinsengumiAtack()
    {
        var Shinsengumi = new Shinsengumi();
        Shinsengumi.hp = 100;
        Shinsengumi.BasicAtack(30);
        Debug.Log("The actual hp on Shinsengumi is: " + Shinsengumi.hp);
    }


}
