using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject deadUi;
    public userInfo user;
    public GameObject[] windowDie;
    void Start()
    {

    }

    void Update()
    {
        if (user.time >= user.limitTime) { StartCoroutine(die()); }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Window")
        {
            windowDie[0].SetActive(true);
            windowDie[1].SetActive(true);
            StartCoroutine(die());
        }
    
    }

    public IEnumerator die()
    {
        yield return new WaitForSeconds(0.5f);
        deadUi.SetActive(true);
    }
}
