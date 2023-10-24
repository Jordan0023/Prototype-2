using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    private float score = 0;
    private int lives = 3;
    public GameObject player;

    public Text scoreText;
    public Text livesText;

   


    // Start is called before the first frame update


    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score = " + score.ToString();
        livesText.text = "Lives = " + lives.ToString();
    }

    public void Lives(int n)
    {
        lives += n;

        if( lives <= 0)
        {
            Debug.Log("Game Over!");
            lives = 0;
            Destroy(player);
        }
        Debug.Log("Lives = " + lives);

    }

    public void Score(float n)
    {
        score += n;

        Debug.Log("Score = " + score);
    }

}
