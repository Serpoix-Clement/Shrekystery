using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planche_Behaviour : MonoBehaviour
{
    public Collider colliderPlanche;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<PlayerController>().hache == true)
            {
                colliderPlanche.enabled = false;
                other.GetComponent<PlayerController>().hache = false;
                gameObject.SetActive(false);
            }

            if (other.GetComponent<PlayerController>().scie == true)
            {
                colliderPlanche.enabled = false;
                other.GetComponent<PlayerController>().scie = false;
                gameObject.SetActive(false);
            }
        }
    }
}
