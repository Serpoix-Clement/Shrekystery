using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hache;
    public bool glacon;
    public bool cleFinal;
    public GameObject hacheEnMain;
    public static PlayerController Instance;

    void Start()
    {
        hache = false;
        glacon = false;
        cleFinal = false;
        hacheEnMain.SetActive(false);
        Instance = this;
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
