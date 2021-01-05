using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxController : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.5f;
    private Vector3 velocity = Vector3.zero;
    public Vector3 targetPosition;

    public GameObject Box;

    void Start()
    {
        InvokeRepeating("Size", 0f, 0.25f);
    }

    void Update()
    {
        Box.GetComponent<BoxCollider>().size = Vector3.SmoothDamp(Box.GetComponent<BoxCollider>().size, targetPosition, ref velocity, smoothTime);
    }

    int i = 1;
    
    public void Size()
    {
        i = i * -1;
        if (i < 0)
        {
            targetPosition = target.TransformPoint(new Vector3(0.15f, 0.125f, 0.15f));
        }
        else
        {
            targetPosition = target.TransformPoint(new Vector3(0.15f, 0.05f, 0.15f));
        }
    }
}
