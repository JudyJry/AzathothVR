using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userInfo : MonoBehaviour
{
    public bool bearHead = false;
    public bool bearRightHand = false;
    public bool bearLeftHand = false;
    public bool bearLeg = false;
    public bool bearBody = false;
    public bool treasureMap = false;
    public bool safeBox = false;
    public Text promptText;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (treasureMap){
            promptText.text = "已收集：";
            if (bearHead){
                promptText.text += " 頭 ";
            }
            if (bearRightHand){
                promptText.text += " 右手 ";
            }
            if (bearLeftHand){
                promptText.text += " 左手 ";
            }
            if (bearLeg){
                promptText.text += " 腳 ";
            }
            if (bearBody){
                promptText.text += " 身體 ";
            }
        }
        else 
        {
            promptText.text = "";
        }
    }
}
