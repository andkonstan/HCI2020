using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic_Controller : MonoBehaviour
{
    private GameObject car1;
    private GameObject car2;
    private GameObject car3;
    private GameObject human1;
    private GameObject traffic_light;
    private GameObject traffic_light2;
    private GameObject traffic_light3;
    private GameObject traffic_light4;
    private GameObject traffic_light5;
    private GameObject traffic_light6;
    List<GameObject> traffic_lights = new List<GameObject>();
    void Awake() {

    }
    // Start is called before the first frame update
    void Start()
    {
        car1 = GameObject.Find("car1");
        car2 = GameObject.Find("car2");
        car3 = GameObject.Find("car3");
        human1 = GameObject.Find("human1");
        traffic_light = GameObject.Find("traffic_light");
        traffic_light2 = GameObject.Find("traffic_light2");
        traffic_light3 = GameObject.Find("traffic_light3");
        traffic_light4 = GameObject.Find("traffic_light4");
        traffic_light5 = GameObject.Find("traffic_light5");
        traffic_light6 = GameObject.Find("traffic_light6");
        traffic_lights.Add(traffic_light);
        traffic_lights.Add(traffic_light2);
        traffic_lights.Add(traffic_light3);
        traffic_lights.Add(traffic_light4);
        traffic_lights.Add(traffic_light5);
        traffic_lights.Add(traffic_light6);
    }

    IEnumerator waiter(int caller,float delay)
    {
        yield return new WaitForSeconds(delay);
        traffic_light = GameObject.Find("traffic_light");
        if (caller == 1)
        {
            traffic_light.GetComponent<tralight>().turnGreen();
        }
        else {
            traffic_light2.GetComponent<tralight>().turnGreen();
        }

    }

    bool isfirstTime = true;
    bool isfirstTime1 = true;
    bool isSecondTime = true;
    bool isThridTime = true;

    void manageTrafficLights() {

        if (traffic_light.GetComponent<tralight>().getCarsWaiting() == 2)
        {
            if (isfirstTime)
            {
                traffic_light.GetComponent<tralight>().turnRed();

                isfirstTime = false;
            }

            if (traffic_light.GetComponent<tralight>().isRed() == true)
            {
                traffic_light6.GetComponent<tralight>().turnGreen();
                traffic_light5.GetComponent<tralight>().turnGreen();
                human1.GetComponent<NewBehaviourScript>().startCar();
                car1.GetComponent<NewBehaviourScript>().stopCar(); //C#
                car2.GetComponent<NewBehaviourScript>().stopCar(); //C#
                StartCoroutine(waiter(1, 5f));

            }
            else
            {
                traffic_light6.GetComponent<tralight>().turnRed();
                human1.GetComponent<NewBehaviourScript>().stopCar();
                traffic_light5.GetComponent<tralight>().turnRed();
                car1.GetComponent<NewBehaviourScript>().startCar(); //C#
                car2.GetComponent<NewBehaviourScript>().startCar(); //C#
            }

        }

        if (traffic_light2.GetComponent<tralight>().getCarsWaiting() == 1)
        {
            if (!traffic_light2.GetComponent<tralight>().isRed()) {

                traffic_light3.GetComponent<tralight>().turnRed();
                traffic_light4.GetComponent<tralight>().turnRed();


            }
            if (isSecondTime && !isfirstTime1) {
                traffic_light2.GetComponent<tralight>().turnRed();
                isSecondTime = false;
                traffic_light3.GetComponent<tralight>().turnGreen();
                traffic_light4.GetComponent<tralight>().turnGreen();
            }
            if (isfirstTime1)
            {
                traffic_light3.GetComponent<tralight>().turnRed();
                traffic_light4.GetComponent<tralight>().turnRed();
                isfirstTime1 = false;
            }

            if (traffic_light2.GetComponent<tralight>().isRed() == true)
            {
                car3.GetComponent<NewBehaviourScript>().stopCar(); //C#
                StartCoroutine(waiter(2, 6f));

            }
            else
            {
                car3.GetComponent<NewBehaviourScript>().startCar(); //C#
            }

        }



    }
    void Update()
    {
        manageTrafficLights();

        /*
        GameObject car1 = GameObject.Find("car1");
        GameObject car2 = GameObject.Find("car2");
        GameObject traffic_light = GameObject.Find("traffic_light");*/
        
        /*if (traffic_light.GetComponent<tralight>().isRed() == true)
        {
            car1.GetComponent<NewBehaviourScript>().stopCar(); //C#
            car2.GetComponent<NewBehaviourScript>().stopCar(); //C#
            StartCoroutine(waiter());

        }
        else
        {
            car1.GetComponent<NewBehaviourScript>().startCar(); //C#
            car2.GetComponent<NewBehaviourScript>().startCar(); //C#
        }
        */
    }
}
