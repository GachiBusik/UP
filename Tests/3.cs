using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript2
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
        int HP_M_old = HP_M;

        void qq()
        {
            Debug.Log("Damadge");
            HP_M -= damg;
            HP -= 1;
        }

        qq();

        if (HP_M_old>HP_M)
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
