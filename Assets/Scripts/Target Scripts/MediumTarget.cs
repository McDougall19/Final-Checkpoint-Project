using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumTarget : Target
{
    // Start is called before the first frame update
    void Start()
    {
        Setxy();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        //switches direction when the target reaches the outer bounds 
        if (transform.position.y > topBound)
        {
            xSpeed *= -1;
        }
        if (transform.position.y < bottomBound)
        {
            xSpeed *= -1;
        }
        
    }

    //sets speed and bounds of the target
    protected override void Setxy()
    {
        ySpeed = 0;
        xSpeed = 5;
        topBound = 18;
        bottomBound = 7;
    }
}
