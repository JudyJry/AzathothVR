using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove2 : MonoBehaviour
{
    public GameObject Box;

    public bool isOpen = false;
    public int speed = 2;
    public int RamVar;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Ram", 0f, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            RotateAxisOfSelf(SelfAxis.Y, speed);
        }

        Box.transform.Translate(new Vector3(0, 0, 1f) * Time.deltaTime);
    }

    private void RotateAxisOfSelf(SelfAxis selfAxis, int speed = 2)
    {
        switch (selfAxis)
        {
            case SelfAxis.X:
                this.transform.Rotate(new Vector3(1 * Time.deltaTime * speed, 0, 0));
                break;
            case SelfAxis.Y:
                this.transform.Rotate(new Vector3(0, RamVar * Time.deltaTime * speed, 0));
                break;
            case SelfAxis.Z:
                this.transform.Rotate(new Vector3(0, 0, 1 * Time.deltaTime * speed));
                break;
            default:
                this.transform.Rotate(new Vector3(1 * Time.deltaTime * speed, 0, 0));
                break;

        }


    }

    enum SelfAxis
    {
        X,
        Y,
        Z,
    }

    public void Ram()
    {
        RamVar = Random.Range(-90,90);
    }
}
