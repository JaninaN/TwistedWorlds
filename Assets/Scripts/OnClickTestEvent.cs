using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickTestEvent : MonoBehaviour {

    GameObject talkbox;

	// Use this for initialization
	void Start () {
        talkbox = GameObject.Find("Test_Laberkasten");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log("mouse ist unten");
        Sprite sprite = talkbox.GetComponent<SpriteRenderer>().sprite;
        RectTransform trans = talkbox.GetComponent<RectTransform>();
        trans.position = new Vector3(trans.position.x, (float)(trans.position.y - sprite.bounds.size.y), trans.position.z);
        Debug.Log(trans.localPosition + "\n" + trans.position);
        Debug.Log(sprite.bounds.size + "\n" + sprite.border);
    }
}
