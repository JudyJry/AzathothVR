using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frame4 : MonoBehaviour
{
    public GameObject deadUi;
    public Material normal, die;
    public float time = 0;
    private bool isWatch = false;

    void Start()
    {

    }

    
    void Update()
    {
        if (isWatch) {
            time+=Time.deltaTime;
            if (time > 3 ){
                dieVision();
                StartCoroutine(die2());
            }
        } 
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Vision")
        {
            isWatch = true;
        }

    }

    public void OnTriggerExit(Collider collider)
    {
        time = 0;
        isWatch = false;
    }

    public void dieVision(){
        gameObject.GetComponent<AudioSource>().enabled = true;
        gameObject.GetComponent<Renderer>().material = die;
    }

     public IEnumerator die2()
    {
        yield return new WaitForSeconds(0.5f);
        deadUi.SetActive(true);
    }
}
