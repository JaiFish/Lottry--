using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Move : MonoBehaviour {
    public static Move Inst;


    public Dictionary<int, Vector3> InstPos = new Dictionary<int, Vector3>();//產生物件位置
    public Dictionary<int, Vector3> MoveToPos = new Dictionary<int, Vector3>();//移動目標位置
    public Dictionary<Vector2,int > AllOdss = new Dictionary<Vector2, int>();

    private void Awake()
    {
        Inst = this;
        InstPosV3();
        MoveToPosV3();
        Odds();
    }
    public void InstPosV3()
    {
        InstPos.Add(0, new Vector3(-3, 6, 0));
        InstPos.Add(1, new Vector3( 0, 6, 0));
        InstPos.Add(2, new Vector3( 3, 6, 0));
    }
    public void MoveToPosV3()
    {
        MoveToPos.Add(0, new Vector3(-2.5f, 0.5f, -3.5f));
        MoveToPos.Add(1, new Vector3(-2.5f, 0.5f, -1.4f));
        MoveToPos.Add(2, new Vector3(-2.5f, 0.5f,  0.7f));
        MoveToPos.Add(3, new Vector3(    0, 0.5f, -3.5f));
        MoveToPos.Add(4, new Vector3(    0, 0.5f, -1.4f));
        MoveToPos.Add(5, new Vector3(    0, 0.5f,  0.7f));
        MoveToPos.Add(6, new Vector3( 2.5f, 0.5f, -3.5f));
        MoveToPos.Add(7, new Vector3( 2.5f, 0.5f, -1.4f));
        MoveToPos.Add(8, new Vector3( 2.5f, 0.5f,  0.7f));
        //MoveToPos.Add(0, new Vector3(-2, 0.5f, -3.5f));//1
        //MoveToPos.Add(1, new Vector3(0, 0.5f, -3.5f));//2  
        //MoveToPos.Add(2, new Vector3(2, 0.5f, -3.5f));//3  
        //MoveToPos.Add(3, new Vector3(-2, 0.5f, -1.9f));//1  
        //MoveToPos.Add(4, new Vector3(0, 0.5f, -1.9f));//2
        //MoveToPos.Add(5, new Vector3(2, 0.5f, -1.9f));//3   
        //MoveToPos.Add(6, new Vector3(-2, 0.5f, -0.2f));//1  
        //MoveToPos.Add(7, new Vector3(0, 0.5f, -0.2f));//2  
        //MoveToPos.Add(8, new Vector3(2, 0.5f, -0.2f));//3
    }
    public void Odds()
    {
        //(圖示0, 數量) ,賠率
        AllOdss.Add(new Vector2(0, 4) ,100 );
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

        AllOdss.Add(new Vector2(2, 4) ,100 );
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
    //注意!!關閉鋼體的Kinematic的選項後，可以解決抖動問題
    //創立一個物件，給予創立物件位置，創立的物件移動至目標
    public GameObject[] instGob;//創立物件的目標
    //public GameObject[] EndPos;//終點
    public GameObject[] Obj= new GameObject[9];//要移動的物件
    public int[] RuleFace = new int[9];
    public float speed = 0.3f;//移動速度
    private float firstSpeed;//紀錄第一次移動的距離
    public List<Vector2> AllCount = new List<Vector2>();//蒐集了全部連線
    void Start ()
    {
       

    }
    //public int RandomModle()
    //{
    //    int a = 0;
    //    a = Random.Range(0, instGob.Length);
    //    return a;
    //}
    public void RandomModle()
    {
        for (int i = 0; i < RuleFace.Length; i++)
        {
            RuleFace[i] = Random.Range(0, instGob.Length);
        }  



    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            StartCoroutine(EvetInst());
            //if (Obj != null)
            //{
            //    Destroy(Obj);
            //}
            //Obj = Instantiate(instGob);//創立物件
            //Obj.transform.position = new Vector3(0, 5, 0);//給予物件創立的位置

            //StartCoroutine(LoopMove());//執行物件每秒移動

        }
        //if (Input.GetKeyDown(KeyCode.Q))

        //{
        //    Obj.transform.position = new Vector3(0, 5, 0);
        //}
    }
    //public void Test()
    //{
    //    firstSpeed = Vector3.Distance(Obj.transform.position, PathB.transform.position);
    //}
    //public void Moveto()
    //{
    //        Obj.transform.position = Vector3.Lerp(Obj.transform.position, PathB.transform.position, speed);

    //}
    IEnumerator EvetInst()
    {
        foreach (var item in Obj)
        {
            if (item != null)
            {
                Destroy(item);
            }
        }
       // RandomModle();
        Click();
        OddsCount();
        StartCoroutine(Inst01());
        yield return new WaitForSeconds(0.3f);
        StartCoroutine(Inst02());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Inst03()); 
        yield return new WaitForSeconds(0.01f);

    }
    //IEnumerator EvetSpin()
    //{
    //    StartCoroutine(Inst01());
    //    StartCoroutine(Inst02());
    //    StartCoroutine(Inst03());
    //    yield return new WaitForSeconds(0.5f);
    //}
    IEnumerator Inst01()
    {
        for (int i = 0; i < 3; i++)
        {
            Obj[i] = Instantiate(instGob[RuleFace[i]]);//創立物件
            Obj[i].transform.position = InstPos[0];//給予物件創立的位置
            yield return new WaitForSeconds(1f);
            StartCoroutine(LoopMove(i));
            yield return new WaitForSeconds(1f);
           
        }
      
        
    }
    IEnumerator Inst02()
    {
        for (int i = 3; i < 6; i++)
        {
            Obj[i] = Instantiate(instGob[RuleFace[i]]);//創立物件
            Obj[i].transform.position = InstPos[1];//給予物件創立的位置
            yield return new WaitForSeconds(1f);
            StartCoroutine(LoopMove(i));
            yield return new WaitForSeconds(1f);
            
        }
   
    }
    IEnumerator Inst03()
    { 
        for (int i = 6; i < 9; i++)
        {
            Obj[i] = Instantiate(instGob[RuleFace[i]]);//創立物件
            Obj[i].transform.position = InstPos[2];//給予物件創立的位置
            yield return new WaitForSeconds(1f);
            StartCoroutine(LoopMove(i));
            yield return new WaitForSeconds(1f);
          
        }
     
    }
    IEnumerator LoopMove(int i)
    {
        for (int b = 0; b < 25; b ++)//限制運行次數，避免淪陷循環中，下一盤面運行時speed疊加導致速度異常
        {
            //if (Obj[i].transform.position != MoveToPos[i])
            //{
                Obj[i].transform.position = Vector3.Lerp(Obj[i].transform.position, MoveToPos[i], speed);
                yield return new WaitForSeconds(0.01f);
                //b = 0;
                Debug.Log(speed);
            //}
            
            //else
            //{ break; }
           
        }
   
    }
    public void OddsCount()
    {
        double sum=0;
        foreach (var item in AllCount)
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
    public void Click()//數量 // 圖示
    {
        int temp=0;
        int Symbole = 0;
        int SymbolCount = 0;
       
        for (int a = 0; a <9 ; a++)//拿每個Symbol圖片去檢查盤面
        {
            for (int b = 0; b < RuleFace.Length; b++)//被檢查的盤面
            {
                if (a == RuleFace[b])
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
                AllCount.Add(Malady);
                temp = 0;
                Symbole = 0;

            }
            else
            {
                temp = 0;
            }
        }
        foreach (var item in AllCount)
        {
            Debug.Log(item);
        }
        
    }
}
