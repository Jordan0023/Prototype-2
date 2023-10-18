using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.Image;

public class DestroyCollisions : MonoBehaviour
{


    private Main main;


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
                
               
  
            
            
            
        } else 
        {
            Destroy(gameObject);
            if (main != null)
                Debug.Log("hi");
               
               //other.GetComponent<Hunger>().Feed(1);
           
            
           
        }
           


        

       
       
    }

}
