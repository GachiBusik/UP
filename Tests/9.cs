using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript8
{
    public GameObject Text_hp;
    public GameObject Text_hp_M;
    public GameObject Text_level;
    public GameObject Text_sword;
    public GameObject Text_mana;
    public int HP = 100;
    public int HP_M = 100;
    public int Level = 1;
    public int damg = 10;
    public int scoreS = 1;
    public int scoreH = 1;
    public int mana = 50;
    public int Monstr = 100;
    bool a = false;


    [Test]
    public void SimplePasses()
    {
    }

    [UnityTest]
    public IEnumerator WithEnumeratorPasses()
    {
        void aptech()
        {
            Debug.Log("HP+");
            if (Level >= scoreH)
            {
                Level -= scoreH;
                HP += 10;
            }
        }

        aptech();

        if (HP > 100)
        {
            a = true;
        }
        else
        {
            a = false;
        }

        Assert.IsTrue(a);

        yield return null;
    }
}