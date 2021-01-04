using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject deadUi;
    public userInfo user;
    void Start()
    {

    }

    void Update()
    {
        if (user.time > user.limitTime) { die(); }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Window") { die(); }
    }

    public void die()
    {
        deadUi.SetActive(true);
    }
}
