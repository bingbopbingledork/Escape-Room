using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    public RedStand redStand;
    public YellowStand yellowStand;
    public BlueStand blueStand;

    public GameObject openPos;
    public GameObject closedPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (redStand.isOnRed == true && blueStand.isOnBlue == true && yellowStand.isonYellow == true)
        {
            //transform.Translate(new Vector2(openPos.transform.position.x, openPos.transform.poition.y) * Time.deltaTime);
            gameObject.transform.position = openPos.transform.position;
        }
        else if (redStand.isOnRed == false || blueStand.isOnBlue == false || yellowStand.isonYellow == false)
        {
            //transform.Translate(new Vector2(closedPos.transform.position.x, closedPos.transform.position.y) * Time.deltaTime);
            gameObject.transform.position = closedPos.transform.position;
        }
    }



}
