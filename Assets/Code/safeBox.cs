using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeBox : MonoBehaviour
{
    public GameObject deadUi;
    public GameObject pp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Body")
        {
            pp.SetActive(true);
            StartCoroutine(die());
        }

    }

    public IEnumerator die() {
        yield return new WaitForSeconds(0.5f);
        deadUi.SetActive(true);
    }
}
