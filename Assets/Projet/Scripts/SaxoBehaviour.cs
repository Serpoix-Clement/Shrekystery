using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaxoBehaviour : MonoBehaviour
{
    public Canvas canvasE;
    private bool dansLaZone;

    private void Start()
    {
        dansLaZone = false;
    }

    private void Update()
    {
        if(dansLaZone)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("win : saxophone trouvé");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        dansLaZone = true;
        canvasE.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        dansLaZone = false;
        canvasE.enabled = false;
    }
}
