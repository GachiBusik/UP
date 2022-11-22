using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript5
{
    public GameObject Text_hp;
    public GameObject Text_hp_M;
    public GameObject Text_level;
    public GameObject Text_sword;
    public GameObject Text_mana;
    public int HP = 100;
    public int HP_M = 100;
    public int Level = 0;
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
        void rr()
        {
            Debug.Log("Sword+");
            if (Level >= scoreS)
            {
                Level -= scoreS;
                scoreS += 1;
                damg += 5;
            }
        }

        rr();

        if (damg == 10)
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