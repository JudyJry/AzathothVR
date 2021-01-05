using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;

public class bearHeadC : MonoBehaviour
{
    private bool isPressedR = false;
    private bool isPressedL = false;
    public userInfo user;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isPressedR = ViveInput.GetPress(HandRole.RightHand, ControllerButton.Trigger);
        isPressedL = ViveInput.GetPress(HandRole.LeftHand, ControllerButton.Trigger);
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "RightHand" || collider.tag == "LeftHand")
        {
            if (isPressedR || isPressedL)
            {
                user.bearHead = true;
                Destroy(gameObject);
            }

        }
    }
}
