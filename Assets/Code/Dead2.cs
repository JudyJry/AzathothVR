using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead2 : MonoBehaviour
{
    public GameObject mc;
    
    void Start()
    {

    }

    
    void Update()
    {
        transform.position = mc.transform.position;
        transform.rotation = mc.transform.rotation;
    }
}
