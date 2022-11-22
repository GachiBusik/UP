using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    public GameObject Text_hp;
    public GameObject Text_hp_M;
    public int HP = 1;
    public int HP_M = 20;
    bool a = true;

    [Test]
    public void NewTestScriptSimplePasses()
    {
    }

    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        HP -= 1;

        if (HP <= 0)
        {
            HP_M = 100;
            HP = 100;
        }

        if ((HP_M == 100)&&(HP ==100))
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
