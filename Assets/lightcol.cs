
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcol : MonoBehaviour
{

    public GameObject light;

    public GameObject light1;
    private bool on = false;

    // Use this for initialization
    void OnTriggerEnter()
    {
   
         light.SetActive(false);
         light1.SetActive(true);
    }
    void OnTriggerExit()
    {
        //Sleep(0.5);
        StartCoroutine(waiter());
        
   
    }

    IEnumerator waiter()
    {

        yield return new WaitForSeconds(10f);
        light1.SetActive(false);
        light.SetActive(true);

    }


}
