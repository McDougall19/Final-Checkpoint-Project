using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{

    public static int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(points);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sTarget"))
        {
            points += 5;
        }
        if (collision.gameObject.CompareTag("mTarget"))
        {
            points += 3;
        }
        if (collision.gameObject.CompareTag("LTarget"))
        {
            points += 1;
        }

            Destroy(gameObject);
    }

    
}
