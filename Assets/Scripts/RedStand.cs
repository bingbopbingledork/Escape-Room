using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedStand : MonoBehaviour
{

    public bool isOnRed;


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
        if(collision.gameObject.CompareTag("Red"))
        {
            isOnRed = true;
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Red"))
        {
            isOnRed = false;
        }
    }

}
