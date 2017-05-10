using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBoxClickEvent : MonoBehaviour {

    GameObject data;

    // Use this for initialization
    void Start () {
        data = GameObject.Find("DataStorage");
    }

    private void OnMouseUpAsButton()
    {
        data.GetComponent<Storyflow>().continueTalk();
    }
}
