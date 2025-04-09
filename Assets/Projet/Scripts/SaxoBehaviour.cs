using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaxoBehaviour : MonoBehaviour
{
    public Canvas canvasE;
    public GameObject canvasEGO;
    public Canvas canvasDialogue;
    private bool dansLaZone;
    public List<GameObject> listDialogue;
    public Queue<GameObject> fileDialogue;
    private GameObject dialogueActu;

    private void Start()
    {
        dansLaZone = false;
        fileDialogue = new Queue<GameObject>();

        foreach(GameObject GO in listDialogue)
        {
            fileDialogue.Enqueue(GO);
        }
    }

    private void Update()
    {
        if(dansLaZone)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                canvasEGO.SetActive(false);
                canvasDialogue.enabled = true;
                for(int i = 0; i < 5; i++)
                {
                    StartCoroutine(waitForRealEnd());
                    StartCoroutine(waitForEnd(i));
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        dansLaZone = true;
        canvasE.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        dansLaZone = false;
        canvasE.enabled = false;
    }

    public IEnumerator waitForEnd(int i)
    {
        yield return new WaitForSeconds(2*i);
        dialogueActu = fileDialogue.Dequeue();
        dialogueActu.SetActive(true);
        StartCoroutine(waitForNext());
    }

    public IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1.75f);
        dialogueActu.SetActive(false);
    }

    public IEnumerator waitForRealEnd()
    {
        yield return new WaitForSeconds(9.5f);
        SceneManager.LoadScene(1);
    }
}
