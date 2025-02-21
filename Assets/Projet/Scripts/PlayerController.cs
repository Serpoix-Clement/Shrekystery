using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hache;
    public GameObject hacheEnMain;

    void Start()
    {
        hache = false;
        hacheEnMain.SetActive(false);
    }

    void Update()
    {
        if (hache == true)
        {
            hacheEnMain.SetActive(true);
        }
        else
        {
            hacheEnMain.SetActive(false);
        }
    }
}
