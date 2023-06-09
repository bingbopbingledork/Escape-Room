using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using BNG;
public class AttticSnap : MonoBehaviour
{
    public GameObject AtticEntrance;
    public SnapZone snapPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AtticKeyInSnap()
    {
        if(snapPoint.HeldItem.gameObject.name == "Attic Key")
        {
            Destroy(AtticEntrance);
        }
         
        
    }
}
