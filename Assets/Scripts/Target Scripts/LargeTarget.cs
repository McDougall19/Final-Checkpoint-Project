using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeTarget : Target
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

        if (transform.position.x > topBound)
        {
            xSpeed *= -1;
        }
        if (transform.position.x < bottomBound)
        {
            xSpeed *= -1;
        }
    }

    protected override void Setxy()
    {
        xSpeed = 3;
        ySpeed = 0;
        topBound = 12;
        bottomBound = -18;
    }
}
