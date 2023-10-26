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
            
            
            if(main != null)
                main.Lives(-1);

                Destroy(gameObject);

          




        }
        else if(other.CompareTag("Animal")) 
        {

            other.GetComponent<Hunger>().Feed(1);
            main.Score(1f);
            Destroy(gameObject);
        }
           


        

       
       
    }

}
