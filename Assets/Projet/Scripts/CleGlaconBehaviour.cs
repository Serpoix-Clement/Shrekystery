using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CleGlaconBehaviour : MonoBehaviour
{
    public Canvas canvas;
    private Collider coll;

    public bool glaconRamasse;
    private bool dansZoneDeGlacon;

    void Start()
    {
        canvas.enabled = false;
        glaconRamasse = false;
        dansZoneDeGlacon = false;
    }

    private void Update()
    {
        if (dansZoneDeGlacon)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                coll.gameObject.GetComponent<PlayerController>().glacon = true;
                glaconRamasse = true;
                canvas.enabled = false;
                gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            coll = other;
            if(!glaconRamasse)
            {
                canvas.enabled = true;
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dansZoneDeGlacon = true;
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            canvas.enabled = false;
            dansZoneDeGlacon = false;
        }
    }
}
