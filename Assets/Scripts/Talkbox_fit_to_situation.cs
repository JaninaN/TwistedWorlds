using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talkbox_fit_to_situation : MonoBehaviour {

    public int speed;

    Color transparent = Color.clear;
    Color non_transparent;

    GameObject diaWindow;
    GameObject leftImg;
    GameObject txtbox;

    Vector3 hidePos; 
    Vector3 showPos;

    bool showBox = false;
    bool hideBox = false;

    // Use this for initialization
    void Start () {
		ColorUtility.TryParseHtmlString("#FFFFFFFF", out non_transparent);
        diaWindow = GameObject.Find("DialogWindow");
        leftImg = GameObject.Find("Image_left");
        txtbox = GameObject.Find("Textbox");

        hidePos = transform.localPosition;
        showPos = new Vector3(hidePos.x, hidePos.y + GetComponent<RectTransform>().rect.height, hidePos.z);
    }

    void Update()
    {
        if (showBox)
        {
            float step = (Time.deltaTime * speed);
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + step, transform.localPosition.z);
            if(transform.localPosition.y >= showPos.y)
            {
                transform.localPosition = showPos;
                diaWindow.GetComponent<Button>().interactable = true;
                showBox = false;
            }
        }
        else if (hideBox)
        {
            float step = (Time.deltaTime * speed);
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - step, transform.localPosition.z);
            if (transform.localPosition.y < hidePos.y)
            {
                hideBox = false;
                leftImg.GetComponent<Image>().sprite = null;
                leftImg.GetComponent<Image>().color = transparent;
            }
        }
    }

    //sets text and show the Dialog Window
    void activate(string m_text)
    {
        txtbox.GetComponent<Text>().text = m_text;
        diaWindow.GetComponent<Button>().enabled = true;
        diaWindow.GetComponent<Image>().raycastTarget = true;
        showBox = true;
    }

    //Image on left side + text to show in Dialog
    public void show(Sprite leftImage, string text)
    {
        leftImg.GetComponent<Image>().sprite = leftImage;
        leftImg.GetComponent<Image>().color = non_transparent;

        activate(text);
    }

    //update Text in Dialog, Images are not
    public void update(Sprite leftImage, string text)
    {
        txtbox.GetComponent<Text>().text = text;
        leftImg.GetComponent<Image>().sprite = leftImage;
    }

    //hide Dialog Window
    public void hide()
    {
        diaWindow.GetComponent<Button>().interactable = true;
        diaWindow.GetComponent<Button>().enabled = false;
        diaWindow.GetComponent<Image>().raycastTarget = false;
        hideBox = true;
    }
}
