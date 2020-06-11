using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsoff : MonoBehaviour
{

    void Start()
    {
        // WithForeachLoop();
        GetChildRecursive(gameObject);

    }

    /* void WithForeachLoop()
     {
         foreach (Transform child in transform)
             foreach (Transform child1 in child)
                 print("Foreach loop: " + child);

     }
     */


    private List<GameObject> listOfChildren;
    private void GetChildRecursive(GameObject obj)
    {
        Debug.Log(obj.transform.tag);
        if (null == obj)
            return;

        foreach (Transform child in obj.transform)
        {

            if (null == child)
                continue;
            //child.GetComponent<Light>();
            if (child.GetComponent<Light>())
            {
                //child.GetComponent<Light>().enabled(false);

                //GameObject.Find("1stlamp (4)").GetComponent("Spot Light").enabled = false;
                Light myLight = GameObject.Find("Spot Light").GetComponent<Light>();
                myLight.intensity = 0;
            }



            //child.gameobject contains the current child you can do whatever you want like add it to an array
            listOfChildren.Add(child.gameObject);
            GetChildRecursive(child.gameObject);
        }
    }


}
