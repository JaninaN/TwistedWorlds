using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTravelMap : MonoBehaviour {

    Vector3 showPos;
    Vector3 hidePos;

    // Use this for initialization
    void Start()
    {
        hidePos = transform.localPosition;
        showPos = new Vector3(hidePos.x - GetComponent<RectTransform>().rect.width, hidePos.y, hidePos.z);

        //Canvas will be moved to current Scene and will not be destroyed
        DontDestroyOnLoad(GameObject.Find("Canvas"));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showMap()
    {
        transform.localPosition = showPos;
    }

    public void hideMap()
    {
        transform.localPosition = hidePos;
    }
}
