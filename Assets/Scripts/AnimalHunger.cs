using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimalHunger : MonoBehaviour
{

    public Slider hungerSlider;
    public int hunger = 3;


    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = hunger;
        hungerSlider.value = 0;

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void removeHunger()
    {
        hunger -= 1;
        hungerSlider.value += 1;
        if(hunger <= 0)
        {
            Destroy(gameObject);
        }
    }
}
