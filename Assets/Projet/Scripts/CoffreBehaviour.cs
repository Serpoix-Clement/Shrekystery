using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffreBehaviour : MonoBehaviour
{
    [Header("Canvas pour demander la touche E")]
    public Canvas canvas;
    private bool dansLaZone;
    private bool coffreOuvert;
    public GameObject couvercle;
    private Light lumiere;

    private void Start()
    {
        lumiere = GetComponent<Light>();
        coffreOuvert = false;
        canvas.enabled = false;
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
                coffreOuvert = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dansLaZone = true;
            if(!coffreOuvert)
            {
                canvas.enabled = true;
            }
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
            if(!coffreOuvert)
            {
                canvas.enabled = false;
            }
        }
    }
}
