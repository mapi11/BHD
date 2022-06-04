using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DoorScript : MonoBehaviour
{
    private GameObject CameraMove;
    public GameObject LoosePanel;

    [SerializeField] private GameObject PrefabRoom;
    [SerializeField] private GameObject ActiveRoom;

    [SerializeField] private GameObject DoorLeft;
    [SerializeField] private GameObject DoorMid;
    [SerializeField] private GameObject DoorRight;


    [SerializeField] private TextMeshProUGUI RoomText;

    GlobalScript _globalScript;
    TimerScript _timerScript;
    MoveScript _moveScript;


    public int RandomInt;
    public int _int; // Random Room 

    public bool DoorLeftIsDanger; //Danger room
    public bool DoorMidIsDanger;
    public bool DoorRightIsDanger;

    //public bool DoorLeftIsOpen; //Door is open?
    //public bool DoorMidIsOpen;
    //public bool DoorRightIsOpen;

    private void Start()
    {
        CameraMove = GameObject.Find("CameraMove");

        _globalScript = FindObjectOfType<GlobalScript>();
        _timerScript = FindObjectOfType<TimerScript>();
        _moveScript = FindObjectOfType<MoveScript>();

        RandomInt = Random.Range(0, 3); // Random danger door

        //_int = Random.Range(0, PrefabRoom.Length);

        if (RandomInt == 0)
        {
            DoorLeftIsDanger = true;
            DoorMidIsDanger = false;
            DoorRightIsDanger = false;

        }
        if (RandomInt == 1)
        {
            DoorLeftIsDanger = false;
            DoorMidIsDanger = true;
            DoorRightIsDanger = false;
        }
        if (RandomInt == 2)
        {
            DoorLeftIsDanger = false;
            DoorMidIsDanger = false;
            DoorRightIsDanger = true;
        }

        RoomText.text = _globalScript.GlobalRoomInt.ToString();
    }

    //private void Update()
    //{
    //    if (RandomInt == 0)
    //    {
    //        DoorLeftIsDanger = true;
    //        DoorMidIsDanger = false;
    //        DoorRightIsDanger = false;

    //    }
    //    if (RandomInt == 1)
    //    {
    //        DoorLeftIsDanger = false;
    //        DoorMidIsDanger = true;
    //        DoorRightIsDanger = false;
    //    }
    //    if (RandomInt == 2)
    //    {
    //        DoorLeftIsDanger = false;
    //        DoorMidIsDanger = false;
    //        DoorRightIsDanger = true;
    //    }

    //    RoomText.text = _globalScript.GlobalRoomInt.ToString();

    //}

    void DestroyRoom()
    {
        Destroy(ActiveRoom);
    }

    public void DoorClickLeft()                           //Left
    {
        if (DoorLeftIsDanger == false)
        {
            Debug.Log("Left");


            Instantiate(PrefabRoom/*[_int]*/, new Vector3(0, 0, _globalScript.GlobaZ), Quaternion.identity);
            CameraMove.transform.position = DoorLeft.transform.position;

            _globalScript.GlobaZ += 10;

            //Destroy(ActiveRoom);
            Invoke("DestroyRoom", 1.5f);
        }
        else if (DoorLeftIsDanger == true)
        {
            LoosePanel.SetActive(true);
        }

        _globalScript.GlobalRoomInt++;
        _globalScript.GlobalTimer -= 0.25f;
    }
    public void DoorClickMid()                           //mid
    {
        if (DoorMidIsDanger == false)
        {
            Debug.Log("Mid");


            Instantiate(PrefabRoom/*[_int]*/, new Vector3(0, 0, _globalScript.GlobaZ), Quaternion.identity);
            CameraMove.transform.position = DoorMid.transform.position;

            _globalScript.GlobaZ += 10;

            //Destroy(ActiveRoom);
            Invoke("DestroyRoom", 1.5f);
        }
        else if (DoorMidIsDanger == true)
        {
            LoosePanel.SetActive(true);
        }

        _globalScript.GlobalRoomInt++;
        _globalScript.GlobalTimer -= 0.25f;
    }
    public void DoorClickRight()                           //Right
    {
        if (DoorRightIsDanger == false)
        {
            Debug.Log("Right");


            Instantiate(PrefabRoom/*[_int]*/, new Vector3(0, 0, _globalScript.GlobaZ), Quaternion.identity);
            CameraMove.transform.position = DoorRight.transform.position;

            _globalScript.GlobaZ += 10;

            //Destroy(ActiveRoom);
            Invoke("DestroyRoom", 1.5f);
        }
        else if (DoorRightIsDanger == true)
        {
            LoosePanel.SetActive(true);
        }

        _globalScript.GlobalRoomInt++;
        _globalScript.GlobalTimer -= 0.25f;
    }
}
