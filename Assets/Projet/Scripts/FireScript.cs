using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (PlayerController.Instance.glacon)
        {
            Debug.Log("Le gla�on a fondu, vous avez la cl�");
            PlayerController.Instance.cleFinal = true;
        }
        else
        {
            Debug.Log("Voici une source de chaleur");
        }
    }
}
