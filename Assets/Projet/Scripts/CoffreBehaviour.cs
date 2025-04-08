using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffreBehaviour : MonoBehaviour
{
    //public Canvas canvas;
    private bool dansLaZone;
    public GameObject couvercle;
    private Light lumiere;

    private void Start()
    {
        lumiere = GetComponent<Light>();
    }

    private void Update()
    {
        if (PlayerController.Instance.cleFinal && dansLaZone)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerController.Instance.scie = true;
                PlayerController.Instance.cleFinal = false;
                couvercle.SetActive(false);
                lumiere.enabled = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dansLaZone = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            dansLaZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dansLaZone = false;
        }
    }
}
