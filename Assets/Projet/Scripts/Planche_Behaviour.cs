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
                gameObject.SetActive(false);
            }
        }
    }
}
