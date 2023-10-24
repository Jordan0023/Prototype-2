using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Image healthBar;
    public float healthAmountMoose = 3;
    public float healthAmountCow = 2;
    public float healthAmountDog = 1;

    public float healthAmount;

    public float amountDamage = 0;


 
    private Main main;


    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();

        main = gameObject.GetComponent<Main>();


    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void Damage(float n)
    {

        amountDamage += n;
        healthBar.gameObject.SetActive(true);

        if (amountDamage >= healthAmount)
        {


            main.Score(amountDamage);
            Destroy(gameObject, 0.1f);
        }

    }

}
