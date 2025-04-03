using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinProv : MonoBehaviour
{
    public GameObject fin;

    // Start is called before the first frame update
    void Start()
    {
        fin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        fin.SetActive(true);
    }
}
