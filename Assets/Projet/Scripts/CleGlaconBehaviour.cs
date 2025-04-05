using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CleGlaconBehaviour : MonoBehaviour
{
    public Canvas canvas;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player"))
        {
            canvas.enabled = true;
            other.GetComponent<PlayerController>().hache = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("player"))
        {
            canvas.enabled = false;
        }
    }
}
