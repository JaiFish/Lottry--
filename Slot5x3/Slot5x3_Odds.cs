using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot5x3_Odds : MonoBehaviour {
    public static Slot5x3_Odds Inst;
    private void Awake()
    {
        Inst = this;
    }

    public Dictionary<Vector2, int> AllOdss = new Dictionary<Vector2, int>();
    public void Odds()
    {
        //(圖示0, 數量) ,賠率
        AllOdss.Add(new Vector2(0, 4), 100);
        AllOdss.Add(new Vector2(0, 5), 1000);
        AllOdss.Add(new Vector2(0, 6), 1500);
        AllOdss.Add(new Vector2(0, 7), 2000);
        AllOdss.Add(new Vector2(0, 8), 5000);
        AllOdss.Add(new Vector2(0, 9), 10000);

        AllOdss.Add(new Vector2(1, 4), 100);
        AllOdss.Add(new Vector2(1, 5), 1000);
        AllOdss.Add(new Vector2(1, 6), 1500);
        AllOdss.Add(new Vector2(1, 7), 2000);
        AllOdss.Add(new Vector2(1, 8), 5000);
        AllOdss.Add(new Vector2(1, 9), 10000);

        AllOdss.Add(new Vector2(2, 4), 100);
        AllOdss.Add(new Vector2(2, 5), 1000);
        AllOdss.Add(new Vector2(2, 6), 1500);
        AllOdss.Add(new Vector2(2, 7), 2000);
        AllOdss.Add(new Vector2(2, 8), 5000);
        AllOdss.Add(new Vector2(2, 9), 10000);

        AllOdss.Add(new Vector2(3, 4), 100);
        AllOdss.Add(new Vector2(3, 5), 1000);
        AllOdss.Add(new Vector2(3, 6), 1500);
        AllOdss.Add(new Vector2(3, 7), 2000);
        AllOdss.Add(new Vector2(3, 8), 5000);
        AllOdss.Add(new Vector2(3, 9), 10000);

        AllOdss.Add(new Vector2(4, 4), 100);
        AllOdss.Add(new Vector2(4, 5), 1000);
        AllOdss.Add(new Vector2(4, 6), 1500);
        AllOdss.Add(new Vector2(4, 7), 2000);
        AllOdss.Add(new Vector2(4, 8), 5000);
        AllOdss.Add(new Vector2(4, 9), 10000);

        AllOdss.Add(new Vector2(5, 4), 100);
        AllOdss.Add(new Vector2(5, 5), 1000);
        AllOdss.Add(new Vector2(5, 6), 1500);
        AllOdss.Add(new Vector2(5, 7), 2000);
        AllOdss.Add(new Vector2(5, 8), 5000);
        AllOdss.Add(new Vector2(5, 9), 10000);

        AllOdss.Add(new Vector2(6, 4), 100);
        AllOdss.Add(new Vector2(6, 5), 1000);
        AllOdss.Add(new Vector2(6, 6), 1500);
        AllOdss.Add(new Vector2(6, 7), 2000);
        AllOdss.Add(new Vector2(6, 8), 5000);
        AllOdss.Add(new Vector2(6, 9), 10000);

        AllOdss.Add(new Vector2(7, 4), 100);
        AllOdss.Add(new Vector2(7, 5), 1000);
        AllOdss.Add(new Vector2(7, 6), 1500);
        AllOdss.Add(new Vector2(7, 7), 2000);
        AllOdss.Add(new Vector2(7, 8), 5000);
        AllOdss.Add(new Vector2(7, 9), 10000);

        AllOdss.Add(new Vector2(8, 4), 100);
        AllOdss.Add(new Vector2(8, 5), 1000);
        AllOdss.Add(new Vector2(8, 6), 1500);
        AllOdss.Add(new Vector2(8, 7), 2000);
        AllOdss.Add(new Vector2(8, 8), 5000);
        AllOdss.Add(new Vector2(8, 9), 10000);
        //MoveToPos.Add(8, new Vector3(2, 0.5f, -0.2f));//3
    }
    public void OddsCount() //計算分數
    {
        double sum = 0;
        foreach (var item in Slot5x3_Dic.Inst.CountModle)
        {
            foreach (var a in AllOdss.Keys)
            {
                if (item == a)
                {
                    sum += item.y * 1000 * AllOdss[a];
                }
            }

        }
        Debug.Log("總共獲得多少分" + sum);

    }


}
