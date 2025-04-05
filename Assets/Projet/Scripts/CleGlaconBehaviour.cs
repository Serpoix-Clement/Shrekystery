using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CleGlaconBehaviour : MonoBehaviour
{
    public Canvas canvas;
    public Canvas canvasInventaire;

    public bool glaconRamasse;

    void Start()
    {
        canvas.enabled = false;
        canvasInventaire.enabled = false;
        glaconRamasse = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(!glaconRamasse)
            {
                canvas.enabled = true;
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                glaconRamasse = true;
                canvas.enabled = false;
                canvasInventaire.enabled = true;
                gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            canvas.enabled = false;
        }
    }
}
