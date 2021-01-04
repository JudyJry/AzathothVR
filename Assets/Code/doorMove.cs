using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;


public class doorMove : MonoBehaviour
{
    public bool zMirror = false;
    private bool isTrigger = false;
    private bool isPressedR = false;
    private bool isPressedL = false;
    public userInfo user;
    private GameObject rh, lh;
    private float zm = 1;

    void Start()
    {
        rh = user.rightHand;
        lh = user.leftHand;
        if (zMirror) zm = -zm;
    }


    void Update()
    {
        isPressedR = ViveInput.GetPress(HandRole.RightHand, ControllerButton.Trigger);
        //if (isPressedR) Debug.Log("isPressedR");
        isPressedL = ViveInput.GetPress(HandRole.LeftHand, ControllerButton.Trigger);
        //if (isPressedL) Debug.Log("isPressedL");
        if (isTrigger && isPressedR)
        {
            if (isOpen(rh))
            {
                transform.Rotate(0, 90 * zm * Time.deltaTime, 0);
            }
            else
            {
                transform.Rotate(0, -90 * zm * Time.deltaTime, 0);
            }
        }
        else if (isTrigger && isPressedL)
        {
            if (isOpen(lh))
            {
                transform.Rotate(0, 90 * zm * Time.deltaTime, 0);
            }
            else
            {
                transform.Rotate(0, -90 * zm * Time.deltaTime, 0);
            }
        }
    }

    private void OnTriggerStay(Collider collider)
    {
        isTrigger = true;
        //Debug.Log("isTrigger");
    }
    private void OnTriggerExit(Collider collider)
    {
        isTrigger = false;
    }

    private bool isOpen(GameObject hand)
    {
        if (hand.transform.position.z - transform.position.z > 0) { return true; }
        else if (hand.transform.position.z - transform.position.z < 0) { return false; }
        return false;
    }

}
