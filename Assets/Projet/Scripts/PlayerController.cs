using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hache;
    public bool glacon;
    public bool cleFinal;
    public GameObject hacheEnMainGO;
    public GameObject cleGO;
    public GameObject glaconGO;
    public static PlayerController Instance;

    void Start()
    {
        hache = false;
        glacon = false;
        cleFinal = false;
        hacheEnMainGO.SetActive(false);
        Instance = this;
    }

    void Update()
    {
        if (hache)
        {
            hacheEnMainGO.SetActive(true);
        }
        else if (glacon)
        {
            cleGO.SetActive(true);
            glaconGO.SetActive(true);
        }
        if (cleFinal && glacon)
        {
            cleGO.SetActive(true);
            glaconGO.SetActive(false);
        }
        else
        {
            hacheEnMainGO.SetActive(false);
        }
    }
}
