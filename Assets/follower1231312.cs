using UnityEngine;
using PathCreation;

public class NewBehaviourScript1 : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;

    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;




        //transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
        if (distanceTravelled <= pathCreator.path.length)
        {
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);

        }


    }


}

