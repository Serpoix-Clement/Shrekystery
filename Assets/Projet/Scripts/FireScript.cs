using System.Collections;
using DG.Tweening;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public ParticleSystem PS;
    public GameObject glacon;

    private void OnTriggerEnter(Collider other)
    {
        if (PlayerController.Instance.glacon)
        {
            PS.Stop();
            PS.Play();
            var main = PS.main;
            main.startSpeed = 5f;
            glacon.transform.DOScale(Vector3.zero, 5f);
            StartCoroutine(compteur());
        }
    }

    public IEnumerator compteur()
    {
        yield return new WaitForSeconds(5f);
        PlayerController.Instance.glacon = false;
        PlayerController.Instance.cleFinal = true;
        PS.Stop();
    }
}
