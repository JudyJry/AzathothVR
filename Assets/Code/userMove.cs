using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.VRModuleManagement;
using HTC.UnityPlugin.Vive;

public class userMove : MonoBehaviour
{
    public float speed = 10;
    void Start()
    {
        var RightHand = ViveRole.GetDeviceIndex(HandRole.RightHand);
        if(!VRModule.IsValidDeviceIndex(RightHand)) return;
        
    }

    void Update()
    {
        Vector2 vector = ViveInput.GetPadTouchAxis(HandRole.RightHand);
        Vector3 direction = new Vector3(vector.x,0,vector.y);
        if (direction!=Vector3.zero){
            transform.Translate(direction*Time.deltaTime*speed);
        }
    }
}
