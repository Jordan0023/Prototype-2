using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update

    private float topBound = 30;
    private float lowerBound = -10;
    private float rightBound = -25;
    private float leftBound = 25;
    public GameObject[] objects;

   

    private Main main;



    void Start()
    {
        main = gameObject.GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
        main = GameObject.Find("Main").GetComponent<Main>();

        if (transform.position.z > topBound)
        {

                Destroy(gameObject);
           
            
        }
        else if (transform.position.z < lowerBound)
        {

            Destroy(gameObject);
            main.Lives(-1);
            

        }

        else if (transform.position.x > leftBound)
        {
Destroy(gameObject);
            main.Lives(-1);
            


        }
        else if (transform.position.x  < rightBound)
        {
Destroy(gameObject);
            main.Lives(-1);
            

        }





    }
}
