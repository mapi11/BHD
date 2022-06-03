using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerDoorScript : MonoBehaviour
{
    DoorScript _doorScript;
    TimerScript _timerScript;
    GlobalScript _globalScript;

    public float RandomTime;

    public GameObject _doorLeft;
    public GameObject _doorMid;
    public GameObject _doorRight;


    void Start()
    {
        _globalScript = FindObjectOfType<GlobalScript>();
        _timerScript = FindObjectOfType<TimerScript>();
        _doorScript = FindObjectOfType<DoorScript>();

        RandomTime = Random.Range(0.5f, _globalScript.GlobalTimer);
        Debug.Log("RandomTime" + RandomTime);

    }
    private void Update()
    {
        Debug.Log(_timerScript.TimeLeft);

        if (_timerScript.TimeLeft <= RandomTime)
        {
            if (_doorScript.DoorLeftIsDanger == true)
            {
                _doorLeft.SetActive(true);
            }
            if (_doorScript.DoorMidIsDanger == true)
            {
                _doorMid.SetActive(true);
            }
            if (_doorScript.DoorRightIsDanger == true)
            {
                _doorRight.SetActive(true);
            }
        }

    }


    private void FixedUpdate()
    {
        _doorLeft.SetActive(false);
        _doorMid.SetActive(false);
        _doorRight.SetActive(false);
    }

}
