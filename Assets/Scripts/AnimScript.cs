using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour
{
    DoorScript _doorScript;

    Animator anim;

    private void Start()
    {
        _doorScript = FindObjectOfType<DoorScript>();

        anim = GetComponent<Animator>();
    }

    //private void Update()
    //{
    //    if (_doorScript.DoorLeftIsOpen == true) //true
    //    {
    //        anim.SetBool("DoorLeftOpen", true);
    //    }
    //    if (_doorScript.DoorMidIsOpen == true)
    //    {
    //        anim.SetBool("DoorMidOpen", true);
    //    }
    //    if (_doorScript.DoorRightIsOpen == true)
    //    {
    //        anim.SetBool("DoorRightOpen", true);
    //    }

    //    if (_doorScript.DoorLeftIsOpen == false) //false
    //    {
    //        anim.SetBool("DoorRightOpen", false);
    //    }
    //    if (_doorScript.DoorMidIsOpen == false)
    //    {
    //        anim.SetBool("DoorMidOpen", false);
    //    }
    //    if (_doorScript.DoorRightIsOpen == false)
    //    {
    //        anim.SetBool("DoorRightOpen", false);
    //    }
    //}
}
