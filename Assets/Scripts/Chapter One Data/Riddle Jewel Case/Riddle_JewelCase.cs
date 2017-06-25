using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riddle_JewelCase : MonoBehaviour {

    public int code;

    private GameObject numberOne;
    private GameObject numberTwo;
    private GameObject numberThree;
    private GameObject numberFour;

    Vector3 hidePos;
    Vector3 showPos;

    // Use this for initialization
    void Start () {
        numberOne = GameObject.Find("Schloss_Zahlenrad_1");
        numberTwo = GameObject.Find("Schloss_Zahlenrad_2");
        numberThree = GameObject.Find("Schloss_Zahlenrad_3");
        numberFour = GameObject.Find("Schloss_Zahlenrad_4");

        hidePos = transform.position;
        showPos = new Vector3(hidePos.x, hidePos.y - GameObject.Find("Lock").GetComponent<SpriteRenderer>().bounds.size.y, hidePos.z);
    }

    public void showLock()
    {
        GameObject.Find("Lock").transform.position = showPos;
    }

    public void checkCode()
    {
        int a = numberOne.GetComponent<NumberOnLock>().getNumber();
        int b = numberTwo.GetComponent<NumberOnLock>().getNumber();
        int c = numberThree.GetComponent<NumberOnLock>().getNumber();
        int d = numberFour.GetComponent<NumberOnLock>().getNumber();

        //append all 4 Numbers to compare it with the given code
        int input = int.Parse(a.ToString() + b.ToString() + c.ToString() + d.ToString());
        if(input == code)
        {
            GameObject.Find("Main Camera").GetComponent<CameraPositions>().fadeInBlender();
        }
    }
}
