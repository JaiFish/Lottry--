
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot5x3_ControllTureOrFlas : MonoBehaviour {
    public static Slot5x3_ControllTureOrFlas Inst;
    public GameObject Spin;
    public GameObject Stop;
    public bool EndSpin;
    private void Awake()
    {
        Inst = this;
        FirstControll();
    }
    public void StarSpin()
    {
        EndSpin = false;
        Spin.SetActive(false);
        Stop.GetComponent<Button>().interactable = false;
        StartCoroutine(TrueStop());
       
    }
    public void StopSpin()
    {
        EndSpin = true;
        Stop.GetComponent<Button>().interactable = false;
        StartCoroutine(TrueSpin());

    }

    public void FirstControll()
    {
        Spin.SetActive(true);
        Stop.SetActive(true);
        EndSpin = false;
        Stop.GetComponent<Button>().interactable = true;
    }
    IEnumerator TrueStop()
    {
        yield return new WaitForSeconds(1f);
        Stop.GetComponent<Button>().interactable = true;

    }
    IEnumerator TrueSpin()
    {
        yield return new WaitForSeconds(1f);
        Spin.SetActive(true);
        EndSpin = false;
    }


}
