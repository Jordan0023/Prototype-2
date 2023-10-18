using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{ 

    private const float MAX_HEALTH = 3f;

    public float health = MAX_HEALTH;

    public Image healthBar;


    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / MAX_HEALTH;
    }
}
