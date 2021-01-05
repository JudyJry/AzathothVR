using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead3 : MonoBehaviour
{
     public GameObject mc;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = mc.transform.position;
    }
}
