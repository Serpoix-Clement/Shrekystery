using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlayerController>().hache = true;
        gameObject.SetActive(false);
    }
}
