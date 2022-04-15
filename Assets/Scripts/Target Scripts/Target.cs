using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target : MonoBehaviour
{
    //variables to be set in child classes
    protected float xSpeed;
    protected float ySpeed;
    protected float topBound;
    protected float bottomBound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //used to set speed and bounds of the target, taking all of the above variables
    protected abstract void Setxy();

    //destroys arrows when they hit the target
    

    //moves the target
    protected void Move()
    {
        transform.Translate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, 0);
    }

}
