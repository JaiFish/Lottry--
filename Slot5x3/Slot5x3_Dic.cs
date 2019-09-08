using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slot5x3_Dic : MonoBehaviour
{
    public static Slot5x3_Dic Inst;
    public Dictionary<int, Vector3> InstPos = new Dictionary<int, Vector3>();//產生物件位置
    public Dictionary<int, Vector3> ModlePos = new Dictionary<int, Vector3>();
    public void InstPosV3()
    {
        InstPos.Add(0, new Vector3(-3.5f, 6, 0));
        InstPos.Add(1, new Vector3(3.5f, 6, 0));
        InstPos.Add(2, new Vector3(0, 6, 0));
    }//創立物件位置資料庫
    public void ModlePosAdd()
    {
        ModlePos.Add(0, new Vector3(-3.5f, 0.5f, -6f));
        ModlePos.Add(1, new Vector3(0f, 0.5f, -6f));
        ModlePos.Add(2, new Vector3(3.5f, 0.5f, -6f));
        ModlePos.Add(3, new Vector3(-3.5f, 0.5f, -3f));
        ModlePos.Add(4, new Vector3(3.5f, 0.5f, -3f));
        ModlePos.Add(5, new Vector3(-3.5f, 0.5f, 0f));
        ModlePos.Add(6, new Vector3(3.5f, 0.5f, 0f));
        ModlePos.Add(7, new Vector3(-3.5f, 0.5f, 3f));
        ModlePos.Add(8, new Vector3(3.5f, 0.5f, 3f));
        ModlePos.Add(9, new Vector3(-3.5f, 0.5f, 6f));
        ModlePos.Add(10, new Vector3(0f, 0.5f, 6f));
        ModlePos.Add(11, new Vector3(3.5f, 0.5f, 6f));
        ModlePos.Add(12, new Vector3(0f, 0.5f, 0f));//中央symbol位置

    }//modle移動到的最後位置(盤面位置)
    public GameObject[] Modle = new GameObject[13];//盤面
    public int[] RuleFace = new int[13];//盤面編號
    public GameObject[] ModleNum;//Modle庫
    public GameObject[] SpecalModle;//Modle庫
    public List<Vector2> CountModle = new List<Vector2>();//蒐集了全部連線
    public float speed = 0.3f;//移動速度
    
   
    public int DecidePosNum =0 ;
    //記住使用LocalPosition抓準本地座標(引擎內座標)才可以精準抓到你想要的位置

    private void Awake()
    {
        Inst = this;
        InstPosV3();
        ModlePosAdd();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(EventSpin());

        }
    }
    public void StarSpin()
    {
        StartCoroutine(EventSpin());
    }

    public void RandomModle()
    {
        for (int i = 0; i < RuleFace.Length; i++)
        {
            RuleFace[i] = Random.Range(0, ModleNum.Length);
        }

    }
   
    IEnumerator EventSpin()
    {
        foreach (var item in Modle)
        {
            if (item != null)
            {
                Destroy(item);
            }
        }
       
        RandomModle();
        Slot5x3_ClickFace.Inst.Click();
        DecidePosNum = 0;
        StartCoroutine(InsPos());
        yield return new WaitForSeconds(0.1f);
    }
    IEnumerator InsPos()
    {
        for (int i = 0; i < 13; i++)
        {
            if (Slot5x3_ControllTureOrFlas.Inst.EndSpin == true)
            {
                //如果啟動停止轉輪，進入停止轉輪方法
                StartCoroutine(StopSpin(i));
                break;    
            }
           // if (i > 12) break;
            Modle[i] = Instantiate(ModleNum[RuleFace[i]]);
            Modle[i].transform.localPosition = DecidePos(i);
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(LoopMove(i));
          
            yield return new WaitForSeconds(0.001f);
            if (i == 10)
            {
                Slot5x3_ControllTureOrFlas.Inst.Stop.GetComponent<Button>().interactable = false;
            }
        }

        yield return new WaitForSeconds(0.1f);
    }
    IEnumerator StopSpin(int i)
    {
         while(i<13)
        { 

         Modle[i] = Instantiate(ModleNum[RuleFace[i]]);
        Modle[i].transform.localPosition = DecidePos(i);
        StartCoroutine(LoopMove(i));
         i++;
            if (i > 12) break;
        yield return new WaitForSeconds(0.001f);
        }
    }

    IEnumerator LoopMove(int i)
    {
        //將物件移動到台座上
        for (int b = 0; b < 25; b++)//限制運行次數，避免淪陷循環中，下一盤面運行時speed疊加導致速度異常
        {

            if (Modle[i].name == "Karate Warrior(Clone)")
            {
                //修正模型的原中心位置，避免模型超出台座
                Vector3 temp;
                temp = ModlePos[i];
                temp.z += 0.15f;
                Modle[i].transform.localPosition = Vector3.Lerp(Modle[i].transform.localPosition, temp, speed);
            }
            if (Modle[i].name == "Ninja Warrior(Clone)")
            {
                //修正模型的原中心位置，避免模型超出台座
                Vector3 temp;
                temp = ModlePos[i];
                temp.z += 0.41f;
                Modle[i].transform.localPosition = Vector3.Lerp(Modle[i].transform.localPosition, temp, speed);
            }
            else
            {
                Modle[i].transform.localPosition = Vector3.Lerp(Modle[i].transform.localPosition, ModlePos[i], speed);
            }
            yield return new WaitForSeconds(0.01f);

            //Debug.Log(speed);
            if (i == 12 && b == 24)
            {
              //  Debug.Log("有值型媽?");
                Slot5x3_ControllTureOrFlas.Inst.Spin.SetActive(true);
            }

            if(i ==12)
            { 
               
            StartCoroutine(AttackAnis(i));
            }
            //    Modle[i].transform.localPosition = Vector3.Lerp(Modle[i].transform.localPosition, ModlePos[i], speed);

            //yield return new WaitForSeconds(0.01f);
        }

    }

    IEnumerator AttackAnis(int i)
    {

         yield return new WaitForSeconds(1f);



    }
    public Vector3 DecidePos(int i) //判斷位置
    {
        Vector3 temp;

        if (DecidePosNum > 1)
        {
            DecidePosNum = 0;
        }
        if (i == 1 || i == 10 || i == 12)
        {
            DecidePosNum = 2;

        }
        //Debug.Log(DecidePosNum);
        temp = InstPos[DecidePosNum];

        DecidePosNum++;
        if (DecidePosNum == 3)
        {
            DecidePosNum = 1;
        }
        //Debug.Log(i);
        //Debug.Log(DecidePosNum);
        //Debug.Log(temp);
        return temp;

    }
}
