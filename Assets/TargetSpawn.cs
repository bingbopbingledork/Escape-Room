using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
public class TargetSpawn : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject textBlock;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTargets()
    {
        target1.SetActive(true);
        target2.SetActive(true);
        target3.SetActive(true);
        textBlock.SetActive(true);
    }
}
