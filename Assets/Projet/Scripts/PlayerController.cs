using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hache;
    public bool glacon;
    public bool cleFinal;
    public bool scie;
    public GameObject hacheEnMainGO;
    public GameObject cleGO;
    public GameObject glaconGO;
    public GameObject scieGO;
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
        else if (cleFinal)
        {
            cleGO.SetActive(true);
            glaconGO.SetActive(false);
        }
        else if (scie)
        {
            cleGO.SetActive(false);
            scieGO.SetActive(true);
        }
        else
        {
            hacheEnMainGO.SetActive(false);
            cleGO.SetActive(false);
            glaconGO.SetActive(false);
            scieGO.SetActive(false);
        }
    }
}
