using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnerScript : MonoBehaviour
{
    GlobalScript _globalScript;

    [SerializeField] private GameObject[] _prefab;
    private int _int;

    private void Start()
    {
        _globalScript = FindObjectOfType<GlobalScript>();

        _int = Random.Range(0, _prefab.Length);
        Instantiate(_prefab[_int], new Vector3(0, 0, _globalScript.GlobaZ), Quaternion.identity);

        Destroy(gameObject);
    }
}
