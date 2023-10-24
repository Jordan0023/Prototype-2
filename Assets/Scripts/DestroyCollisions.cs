using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Image;

public class DestroyCollisions : MonoBehaviour
{


    private Main main;

    private Health health;


    // Start is called before the first frame update
    void Start()
    {

       main = gameObject.GetComponent<Main>();

    }

    // Update is called once per frame
    void Update()
    {
        main = GameObject.Find("Main").GetComponent<Main>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            

                Destroy(gameObject);
            if(main != null)
                main.Lives(-1);





        }
        else
        {

            other.GetComponent<Hunger>().Feed(1);
            main.Score(1f);
        }
           


        

       
       
    }

}
