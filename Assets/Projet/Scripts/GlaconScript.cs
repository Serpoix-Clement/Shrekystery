using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlaconScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerController.Instance.glacon = true;
        Debug.Log("vous avez ramassé le glaçon avec une clé à l'intérieur");
    }
}
