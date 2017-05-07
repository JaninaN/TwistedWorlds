using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talkbox_fit_to_situation : MonoBehaviour {

    Color transparent = Color.clear;
    Color non_transparent;

    GameObject leftImg, rightImg, txtbox;

    Vector3 hidePos, showPos;
    bool postInit = true;

    // Use this for initialization
    void Start () {
		ColorUtility.TryParseHtmlString("#FFFFFFFF", out non_transparent);
        leftImg = GameObject.Find("Image_left");
        rightImg = GameObject.Find("Image_right");
        txtbox = GameObject.Find("Textbox");

        hidePos = transform.position;
        showPos = new Vector3(hidePos.x, hidePos.y - GetComponent<RectTransform>().rect.height, hidePos.z);
        Debug.Log(GetComponent<RectTransform>().rect.size);
        Debug.Log(hidePos);
        Debug.Log(showPos);
        
    }

    void Update()
    {
        if (postInit)
        {
            

            postInit = false;
        }
    }

    //sets text and show the Dialog Window
    void activate(string m_text)
    {
        txtbox.GetComponent<Text>().text = m_text;
        transform.position = showPos;
        Debug.Log(transform.position);
        Debug.Log(showPos);
    }

    //Image on left side + text to show in Dialog
    public void show(Sprite leftImage, string text)
    {
        leftImg.GetComponent<Image>().sprite = leftImage;
        leftImg.GetComponent<Image>().color = non_transparent;

        rightImg.GetComponent<Image>().sprite = null;
        rightImg.GetComponent<Image>().color = transparent;

        activate(text);
    }

    //text + Image on right side to show in Dialog
    public void show(string text, Sprite rightImage)
    {
        rightImg.GetComponent<Image>().sprite = rightImage;
        rightImg.GetComponent<Image>().color = non_transparent;

        leftImg.GetComponent<Image>().sprite = null;
        leftImg.GetComponent<Image>().color = transparent;

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
        transform.position = hidePos;

        leftImg.GetComponent<Image>().sprite = null;
        leftImg.GetComponent<Image>().color = transparent;
        rightImg.GetComponent<Image>().sprite = null;
        rightImg.GetComponent<Image>().color = transparent;
    }
}
