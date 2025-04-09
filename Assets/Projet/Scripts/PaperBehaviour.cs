using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class PaperBehaviour : MonoBehaviour
{
    public Canvas canvasPaper;
    public Canvas canvasE;
    public Canvas canvasQuete;
    private bool active;
    private bool dansLaZone;

    private void Start()
    {
        dansLaZone = false;
        canvasPaper.enabled = false;
        canvasQuete.enabled = false;
        active = true;
    }

    private void Update()
    {
        if(dansLaZone)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                canvasPaper.enabled = active;
                canvasQuete.enabled = true;
                active = !active;
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
        if(active == false)
        {
            canvasPaper.enabled = false;
            active = true;
        }
    }
}
