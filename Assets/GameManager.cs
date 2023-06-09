using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool target1Hit;
    public bool target2Hit;
    public bool target3Hit;
    public GameObject debug;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AllTargetsHit()
    {
        if (target1Hit == true && target2Hit == true && target3Hit == true)
        {
            debug.SetActive(true);
        }
    }


    public void Target1Hit()
    {

    }

    public void TargetHit2()
    {

    }


    public void TargetHit3()
    {

    }


}
