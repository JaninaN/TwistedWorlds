using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talkbox_fit_to_situation : MonoBehaviour {

    Color transparent = Color.clear;
    Color non_transparent;

    GameObject leftImg, txtbox;

    Vector3 hidePos; 
    Vector3 showPos;

    // Use this for initialization
    void Start () {
		ColorUtility.TryParseHtmlString("#FFFFFFFF", out non_transparent);
        leftImg = GameObject.Find("Image_left");
        txtbox = GameObject.Find("Textbox");

        hidePos = transform.localPosition;
        showPos = new Vector3(hidePos.x, hidePos.y + GetComponent<RectTransform>().rect.height, hidePos.z);
    }

    //sets text and show the Dialog Window
    void activate(string m_text)
    {
        txtbox.GetComponent<Text>().text = m_text;
        transform.localPosition = showPos;
        GetComponent<BoxCollider2D>().enabled = true;
    }

    //Image on left side + text to show in Dialog
    public void show(Sprite leftImage, string text)
    {
        leftImg.GetComponent<Image>().sprite = leftImage;
        leftImg.GetComponent<Image>().color = non_transparent;

        activate(text);
    }

    //update Text in Dialog, Images are not
    public void updateText(string m_text)
    {
        txtbox.GetComponent<Text>().text = m_text;
    }

    //hide Dialog Window
    public void hide()
    {
        /*  //For deleting unused Buttons
        
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }*/

        GetComponent<BoxCollider2D>().enabled = false;
        transform.position = hidePos;

        leftImg.GetComponent<Image>().sprite = null;
        leftImg.GetComponent<Image>().color = transparent;
    }
}
