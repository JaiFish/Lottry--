using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot5x3_Delegate : MonoBehaviour {
    public Button Spin;
    public Button Stop;
    

    public void Start()
    {
        Spin.onClick.AddListener(delegate ()
        {
            Slot5x3_Dic.Inst.StarSpin();
            Slot5x3_ControllTureOrFlas.Inst.StarSpin();
        }
        );
        Stop.onClick.AddListener(delegate ()
        {

            Slot5x3_ControllTureOrFlas.Inst.StopSpin();
        }
        );
        
    }


}
