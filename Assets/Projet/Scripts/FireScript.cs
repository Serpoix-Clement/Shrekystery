using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (PlayerController.Instance.glacon)
        {
            PlayerController.Instance.glacon = false;
            PlayerController.Instance.cleFinal = true;
        }
    }
}
