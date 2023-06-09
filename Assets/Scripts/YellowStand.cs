using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowStand : MonoBehaviour
{

    public bool isonYellow;

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
        if (collision.gameObject.CompareTag("Yellow"))
        {
            isonYellow= true;
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Yellow"))
        {
            isonYellow = false;
        }
    }

}
