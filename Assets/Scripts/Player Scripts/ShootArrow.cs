using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnArrow();
        }
    }

    private void SpawnArrow()
    {
        GameObject clone;
        clone = Instantiate(arrow, transform.position + new Vector3(2,0,0), transform.rotation * Quaternion.Euler(90, 90, 0 ));
        clone.GetComponent<Rigidbody>().AddForce(transform.forward * 50, ForceMode.Impulse);
    }
}
