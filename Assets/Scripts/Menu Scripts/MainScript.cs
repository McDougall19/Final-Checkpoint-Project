using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScript : MonoBehaviour
{
    public Text pointText;
    public Text timerText;

    public float countdown = 10;
    public bool gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (countdown <= 0)
        {
            gameOver = true;
        }
       
        
            countdown -= Time.deltaTime;

            timerText.text = "Time: " + Mathf.Round(countdown);

            pointText.text = "Points: " + arrow.points;
        
        
    }
}
