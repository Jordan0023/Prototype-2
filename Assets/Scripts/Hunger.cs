using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{

    public Slider hungerSlider;
    public int amountToBeFed;

    private int currentFedAmount = 0;

    private Main main;

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        main = GameObject.Find("Main").GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Feed(int n)
    {
       currentFedAmount += n;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if(currentFedAmount > amountToBeFed)
        {
            main.Score(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }

    }

}
