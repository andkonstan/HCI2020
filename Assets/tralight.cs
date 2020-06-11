using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class tralight : MonoBehaviour
{

    public GameObject light;

    public GameObject light1;
    private bool on = true;
    private float Timet = 0f;
    private int carnum = 0;


    void start() {
       

    }
    void OnCollisionEnter()
    {
        Debug.Log("Hi");

    }
    public bool isRed() {
        if (light.active && light1 != null) {
            return true;
        }
        return false;
        
    
    }
    public void turnRed() {
        light.SetActive(true);
        light1.SetActive(false);
    }

    public void turnGreen()
    {
        light.SetActive(false);
        light1.SetActive(true);
    }
    public int getCarsWaiting() {
        return carnum;

    }
    void OnTriggerEnter()
     {
        carnum += 1;

         /*if(carnum == 2){

            turnRed();
        }*/
         

     }
    void OnTriggerExit() {

        carnum -= 1;

    }

    /* void OnTriggerExit()
     {
         //Sleep(0.5);
         StartCoroutine(waiter());


     }*/
    /*void Update()
     {

         Timet += Time.deltaTime;

         if (Timet >= 2f)
         {
             Timet = 0f;
             StartCoroutine(waiter(on));

         }


     }

     IEnumerator waiter(bool state)
     {
         Debug.Log("waiter");
         on = !state;
         yield return new WaitForSeconds(0f);
         light1.SetActive(!on);
         light.SetActive(on);

     }   */


}
