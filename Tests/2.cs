using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript1
{

    public GameObject Text_hp;
    public GameObject Text_hp_M;
    public GameObject Text_level;
    public GameObject Text_sword;
    public GameObject Text_mana;
    public int HP = 100;
    public int HP_M = 1;
    public int Level = 0;
    public int damg = 10;
    public int scoreS = 1;
    public int scoreH = 1;
    public int mana = 0;
    public int Monstr = 100;
    bool a = false;

    [Test]
    public void SimplePasses()
    {
    }
    [UnityTest]
    public IEnumerator WithEnumeratorPasses()
    {
        void qq()
        {
            Debug.Log("Damadge");
            HP_M -= damg;
            HP -= 1;
        }

        qq();

        if (HP_M <= 0)
        {
            mana += 10;
            Level += 1;
            HP_M = Monstr;
            Monstr += 10;
        }


        if (Level>0)
        {
            a = true;
        }

        Assert.IsTrue(a);

        yield return null;
    }
}
