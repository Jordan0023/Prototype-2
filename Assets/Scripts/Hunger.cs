using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{

    public Slider slider;
    public int amountFed = 0;

    private int amount;

    private Main main;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = amountFed;
        slider.value = 0;
        slider.fillRect.gameObject.SetActive(false);

        main = GameObject.Find("Main").GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Feed(int n)
    {
        amountFed += n;
        slider.fillRect.gameObject.SetActive(true);
        slider.value = amount;

        if(amountFed  > amount)
        {
            main.Score(amountFed);
            Destroy(gameObject, 0.1f);
        }

    }

}
