using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //initialize variables
    private float speed = 10;
    private float leftBound = -11;
    private float rightBound = 22;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!MainScript.gameOver)
        {
            Move();
        }
       

        //prevents players from going past the walls
        if (transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, 6, -25);
        }
        else if (transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, 6, -25);
        }
    }

    private void Move() // moves player left or right using the A or D key, respectively
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }

    

   
    





}
