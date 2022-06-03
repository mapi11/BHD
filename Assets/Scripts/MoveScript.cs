using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public GameObject Camera;
    public Transform target;
    public float speed;

    DoorScript _doorScript;

    void Start()
    {
        _doorScript = FindObjectOfType<DoorScript>();
    }

    private void FixedUpdate()
    {
        MoveLeft();
    }

    public void MoveLeft()
    {

        Camera.transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
    }
}
