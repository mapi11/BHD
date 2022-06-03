using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    DoorScript _doorScript;
    GlobalScript _globalScript;

    Image TimerFull;
    //public float Timer = 20f;
    public float TimeLeft;

    void Start()
    {
        _doorScript = FindObjectOfType<DoorScript>();
        _globalScript = FindObjectOfType<GlobalScript>();

        TimerFull = GetComponent<Image>();
        TimeLeft = _globalScript.GlobalTimer;
    }

    void Update()
    {
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
            TimerFull.fillAmount = TimeLeft / _globalScript.GlobalTimer;
        }
        else
        {
            _doorScript.LoosePanel.SetActive(true);
        }
    }

}
