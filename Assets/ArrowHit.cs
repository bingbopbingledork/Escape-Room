using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHit : MonoBehaviour
{

    public GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Arrow") && gameObject.CompareTag("Target1"))
        {
            GameManager.target1Hit = true;
        }


        if (collision.gameObject.CompareTag("Arrow") && gameObject.CompareTag("Target2"))
        {
            GameManager.target2Hit = true;
        }



        if (collision.gameObject.CompareTag("Arrow") && gameObject.CompareTag("Target3"))
        {
            GameManager.target3Hit = true;
        }
    }
}
