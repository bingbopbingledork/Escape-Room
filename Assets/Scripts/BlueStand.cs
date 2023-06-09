using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueStand : MonoBehaviour
{

    public bool isOnBlue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Blue"))
        {
            isOnBlue = true;
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Blue"))
        {
            isOnBlue = false;
        }
    }
}
