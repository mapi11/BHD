using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject DoorExit;
    [SerializeField] private GameObject DoorPlay;
    [SerializeField] private GameObject Door_;

    MoveScript _moveScript;

    private GameObject CameraMove;

    private void Start()
    {
        CameraMove = GameObject.Find("CameraMove");
    }

    public void ExitDoor()
    {
        CameraMove.transform.position = DoorExit.transform.position;

        Invoke("ExitGame", 0.5f);
    }
    void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void PlayDoor()
    {
        CameraMove.transform.position = DoorPlay.transform.position;

        Invoke("LoadGame", 1.8f);
    }

    void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
