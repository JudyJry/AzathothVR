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
    public Text collectText;
    public Text timeText;
    public float time;
    private int limitTime = 10 * 60; //10min*60s

    public GameObject rightHand;
    public GameObject leftHand;

    void Start()
    {

    }


    void Update()
    {
        time += Time.deltaTime;
        collect();
        timeChange();
    }

    void collect()
    {
        if (treasureMap)
        {
            collectText.text = "已收集：";
            if (bearHead)
            {
                collectText.text += " 頭 ";
            }
            if (bearRightHand)
            {
                collectText.text += " 右手 ";
            }
            if (bearLeftHand)
            {
                collectText.text += " 左手 ";
            }
            if (bearLeg)
            {
                collectText.text += " 腳 ";
            }
            if (bearBody)
            {
                collectText.text += " 身體 ";
            }
        }
        else
        {
            collectText.text = "";
        }
    }

    void timeChange()
    {
        int lastTime = limitTime - (int)time;
        int min = lastTime / 60;
        int sec = lastTime - min * 60;
        timeText.text = string.Format("剩餘時間：{0:D2}:{1:D2}", min, sec);
        if (lastTime <= 60)
        {
            timeText.color = Color.red;
        }
    }

}
