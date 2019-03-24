using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
static class Player_B
{
    public static string[] Deck_Play = new string[9] { "A01", "A02", "A03", "B01", "B02", "B03", "C01", "C02", "C03" };  //原有
    public static string[] Deck_Fight = new string[9] { "A01", "A02", "A03", "B01", "B02", "B03", "C01", "C02", "C03" }; //對戰
    public static string[] Deck_Use = new string[9] { "EEE", "EEE", "EEE", "EEE", "EEE", "EEE", "EEE", "EEE", "EEE" }; //已使用

    public static string[] Hand = new string[3]; //手牌

    public static int Hand_Num = 3;   // 手牌
    public static int Graveyard = 0; //墓地

    public static int Deck_Num = 6; //牌庫
    public static int Card_Use_Num = 0; //已使用的牌
    public static void Init()
    {
        Text Temp;

        Temp = GameObject.Find("Text_Deck_B_Num").GetComponent<Text>();
        Temp.text = Deck_Num.ToString();

    }

    public static void Refresh()
    {

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
}