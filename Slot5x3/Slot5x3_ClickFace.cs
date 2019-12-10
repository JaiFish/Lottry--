using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot5x3_ClickFace : MonoBehaviour {
    public static Slot5x3_ClickFace Inst;
    private void Awake()
    {
        Inst = this;
    }
    public void Click()//數量 // 圖示
    {
        int temp = 0;
        int Symbole = 0;
        int SymbolCount = 0;

        for (int a = 0; a < Slot5x3_Dic.Inst.ModleNum.Length; a++)//拿每個Symbol圖片去檢查盤面
        {
            for (int b = 0; b < Slot5x3_Dic.Inst.RuleFace.Length; b++)//被檢查的盤面
            {
                if (a == Slot5x3_Dic.Inst.RuleFace[b])
                {
                    temp++;
                    Debug.Log(temp);
                }
            }
            if (temp > 3)
            {
                SymbolCount = temp;//數量
                Debug.Log(SymbolCount);
                Symbole = a;//Symbol編號
                Debug.Log(Symbole);
                Vector2 Malady = new Vector2(Symbole, SymbolCount);
                Slot5x3_Dic.Inst.CountModle.Add(Malady);
                temp = 0;
                Symbole = 0;

            }
            else
            {
                temp = 0;
            }
        }
        foreach (var item in Slot5x3_Dic.Inst.CountModle)
        {
            Debug.Log(item);
        }

    }
}
