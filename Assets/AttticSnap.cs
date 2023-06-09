using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
public class AttticSnap : MonoBehaviour
{
    public GameObject AtticEntrance;
    
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
        
            Destroy(AtticEntrance);
        
    }
}
