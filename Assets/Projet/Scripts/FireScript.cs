using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public ParticleSystem PS;

    private void OnTriggerEnter(Collider other)
    {
        if (PlayerController.Instance.glacon)
        {
            PS.Stop();
            PS.Play();
            var main = PS.main;
            main.startSpeed = 5f;
            StartCoroutine(compteur());
        }
    }

    public IEnumerator compteur()
    {
        yield return new WaitForSeconds(5f);
        PlayerController.Instance.glacon = false;
        PlayerController.Instance.cleFinal = true;   
    }
}
