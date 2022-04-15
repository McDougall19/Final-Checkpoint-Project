using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScript : MonoBehaviour
{
    public Text pointText;
    public Text timerText;
    public Text gameOverText;
    public Text restartText;


    public float countdown = 30;
    public static bool gameOver = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ends game if timer reaches zero
        if (countdown <= 0)
        {
            gameOver = true;
        }

        if (!gameOver)
        {
            //sets text for points and timer
            countdown -= Time.deltaTime;
            pointText.text = "Points: " + arrow.points;
            timerText.text = "Time: " + Mathf.Round(countdown);
        }

        // when the game ends, displays text for game over and to restart
        if (gameOver)
        {
            restartText.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);
        }

        //restarts the game
        if (Input.GetKeyDown(KeyCode.Space) && gameOver)
        {
            arrow.points = 0;
            gameOver = false;
            countdown = 30;
            restartText.gameObject.SetActive(false);
            gameOverText.gameObject.SetActive(false);
        }
        
        
        
    }
}
