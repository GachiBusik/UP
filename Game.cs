using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    //���������� ���������� � �� ��������
    public GameObject Text_hp;
    public GameObject Text_hp_M;
    public GameObject Text_level;
    public GameObject Text_sword;
    public GameObject Text_mana;
    public int HP = 100;//�������� ���������
    public int HP_M = 100;//�������� ����������
    public int Level = 0;//����
    public int damg = 10;//���� 
    public int scoreS = 1;//���� ����� ���������� �����
    public int scoreH = 1;//���� ����� ���������� ��������
    public int mana = 0;//��������� ������� �����
    public int Monstr = 100;//�������� ���������� �� ���������
    // Start is called before the first frame update
    void Start()
    {
        Text_hp.GetComponent<Text>().text = "100";
        Text_hp_M.GetComponent<Text>().text = "100";
        Text_level.GetComponent<Text>().text = "0";
        Text_sword.GetComponent<Text>().text = "10";
        Text_mana.GetComponent<Text>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)//��������(����������� ����������� �������� ����������)
        {
            HP_M = 100;
            Text_hp_M.GetComponent<Text>().text = $"{HP_M}";
            HP = 100;
            Text_hp.GetComponent<Text>().text = $"{HP}";
            Level = 0;
            Text_level.GetComponent<Text>().text = $"{Level}";
            damg = 10;
            Text_sword.GetComponent<Text>().text = "10";
            scoreS = 1;
            scoreH = 1;
            mana = 0;
            Text_mana.GetComponent<Text>().text = "0";
            Monstr = 100;
        }
        if (HP_M <= 0)//������ ��� �����������
        {
            mana += 10;
            Text_mana.GetComponent<Text>().text = $"{mana}";
            Level += 1;
            Text_level.GetComponent<Text>().text = $"{Level}";
            HP_M = Monstr;
            Monstr += 10;
            Text_hp_M.GetComponent<Text>().text = $"{HP_M}";
        }
    }

    void qq()
    {
        Debug.Log("Damadge");//��������� �����
        HP_M -= damg;
        Text_hp_M.GetComponent<Text>().text = $"{HP_M}";
        HP -= 1;
        Text_hp.GetComponent<Text>().text = $"{HP}";
    }

    void ww()//������
    {
        Debug.Log("Defense");
        HP_M -= 0;
        Text_hp_M.GetComponent<Text>().text = $"{HP_M}";
        HP -= 0;
        Text_hp.GetComponent<Text>().text = $"{HP}";
    }
    void tt()//������ ����
    {
        Debug.Log("Magic");
        if (mana >= 50)
        {
            HP_M -= 50;
            Text_hp_M.GetComponent<Text>().text = $"{HP_M}";
            mana -= 50;
            HP -= 1;
            Text_hp.GetComponent<Text>().text = $"{HP}";
        }
    }

    void rr()//���������� �����
    {
        Debug.Log("Sword+");
        if (Level >= scoreS)
        {
            Level -= scoreS;
            scoreS += 1;
            Text_level.GetComponent<Text>().text = $"{Level}";
            damg += 5;
            Text_sword.GetComponent<Text>().text = $"{damg}";
        }
    }
    void aptech()//���������� ��������
    {
        Debug.Log("HP+");
        if (Level >= scoreH)
        {
            Level -= scoreH;
            Text_level.GetComponent<Text>().text = $"{Level}";
            HP += 10;
            Text_hp.GetComponent<Text>().text = $"{HP}";
        }
    }
}
