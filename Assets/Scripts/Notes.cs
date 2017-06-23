using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour {

    Vector3 showPos;
    Vector3 hidePos;

	// Use this for initialization
	void Start () {
        hidePos = transform.localPosition;
        showPos = new Vector3(hidePos.x + GetComponent<RectTransform>().rect.width, hidePos.y, hidePos.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showBook()
    {
        transform.localPosition = showPos;
    }

    public void hideBook()
    {
        transform.localPosition = hidePos;
    }
}
