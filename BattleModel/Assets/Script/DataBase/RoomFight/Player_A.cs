using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class Player_A
{
    public static string[] Deck_Play = new string[9] { "A", "A", "A", "B", "B", "B", "C", "C", "C" };  //原有 A:剪刀 B:石頭 C:布
    public static string[] Deck_Fight = new string[9] { "A", "A", "A", "B", "B", "B", "C", "C", "C" }; //對戰
    public static string[] Deck_Use = new string[9] { "E", "E", "E", "E", "E", "E", "E", "E", "E" }; //已使用

    public static string[] Hand = new string[3]; //手牌

    public static int Hand_Num = 3;   // 手牌
    public static int Hand_Choose = 3; //選擇 

    public static int Graveyard = 0; //墓地

    public static int Deck_Num = 6; //牌庫
    public static int Deck_Draw = 0; //已抽取牌數
    public static int Card_Use_Num = 0; //已使用的牌

    public static void Init()
    {
        Text T_Temp;

        T_Temp = GameObject.Find("Text_Deck_A_Num").GetComponent<Text>();
        T_Temp.text = Deck_Num.ToString();

        /*Image I_Temp;

        I_Temp = GameObject.Find("Image_Show_A").GetComponent<Image>();
        I_Temp.sprite = Resources.Load("Image/f1", typeof(Sprite)) as Sprite;
        */

        Deck_Fight=RandomSortDeck(Deck_Play,9);

        for(int i = 0; i < 3; i++)
        {
            Hand[i] = Deck_Fight[i];
            Deck_Draw++;
        }
        Update_Hand();
    }
    public static void Refresh()
    {

    }

    public static void Update_Hand()
    {
        Image I_Temp;


        for(int i = 0; i < 3; i++)
        {
            I_Temp = GameObject.Find("Image_Hand_A_0" + (i+1).ToString()).GetComponent<Image>();

            switch (Hand[i])
            {
                case "A":
                    I_Temp.sprite = Resources.Load("Image/f1", typeof(Sprite)) as Sprite;
                    break;
                case "B":
                    I_Temp.sprite = Resources.Load("Image/f2", typeof(Sprite)) as Sprite;
                    break;
                case "C":
                    I_Temp.sprite = Resources.Load("Image/f3", typeof(Sprite)) as Sprite;
                    break;
                default:
                    break;
            }
        }

    }

    public static int[] GetRandomSequence(int total)
    {
        int r;
        int[] output = new int[total];
        for (int i = 0; i < total; i++)
        {
            output[i] = i;
        }
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            int temp = 0;
            temp = output[i];
            output[i] = output[r];
            output[r] = temp;
        }
        return output;
    }
    public static string[] RandomSortDeck(string[] s,int total)
    {
        int r;
        string[] output = new string[total];
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            string temp;
            temp = s[i];
            s[i] = s[r];
            s[r] = temp;
        }
        return s;
    }

}

