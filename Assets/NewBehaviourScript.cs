﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using System;

public class NewBehaviourScript : MonoBehaviour{

    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    bool notStopped = true;
    void start() {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    }

    void Update()
    {
            //transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
        if (distanceTravelled <= pathCreator.path.length && notStopped)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        }
    }

    public void stopCar() 
    {
        notStopped = false;
        speed = 0;

    }

    public void startCar()
    {

        StartCoroutine(waiter(UnityEngine.Random.Range(0,9)));
        notStopped = true;
        speed = 5;
    }


    IEnumerator waiter(int num)
    {
       
        yield return new WaitForSeconds(0.22f * num);
       
    }   


}
