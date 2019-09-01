using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lottery : MonoBehaviour {
    //抽獎練習
    // public int[] AllNumber = new int[] {-100,-20,-80,-70,-60,10,30,70,50,100};
    List<int> AllNumber = new List<int>();
    void Start()
    {
       
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandonOut(); 
        }
    }
    public void AddNum()
    {
        AllNumber.Add(-100);
        AllNumber.Add(-20);
        AllNumber.Add(-80);
        AllNumber.Add(-70);
        AllNumber.Add(-50);
        AllNumber.Add(10);
        AllNumber.Add(30);
        AllNumber.Add(70);
        AllNumber.Add(50);
        AllNumber.Add(100);
    }
    public void RandonOut()
    {
        AddNum();
        int TakeNum=0;//從List中拿到的數字
        int sum = 0;//+數總和
        int Order = 0;//拿到+的次數
        int AllOrder = 0;//執行次數總共幾次
        
        for (int take = 0; take < AllNumber.Count; take++)
        {
            TakeNum = AllNumber[Random.Range(0, AllNumber.Count)];
            if (TakeNum > 0)
            {
                sum += TakeNum;
                Order++;
                AllNumber.Remove(TakeNum);
                if (Order == 5)
                {
                    Debug.Log("運氣超好五次就全拿到");
                    AllNumber.Clear();//清除所有List內東西
                    break;
                }

            }
            if (TakeNum < 0)
            {
                // AllNumber.Remove(TakeNum);
                //Debug.Log(AllNumber.Remove(TakeNum) + "被移除了");
                Order = 0;
                sum = 0;
                take = 0;
                AllOrder++;//重製次數++
                AllNumber.Clear();//清除所有List內東西
                AddNum();//重新將全部的值放入
                Debug.Log("我被重製了" + AllOrder + "次");
                
            }
            //if (take == 4 && Order<5)
            //{
            //    Order = 0;
            //    sum = 0;
            //    take = 0;
            //    AllOrder++;
            //    AddNum();
            //    Debug.Log("我被重製了" + AllOrder + "次");
            //}
        }
        Debug.Log("總共在第" + (AllOrder + 1) + "次才獲得天選之人運氣");
        Debug.Log("總共獲得" + sum);

    }
    
}
