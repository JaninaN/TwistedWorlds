using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour {

    public Sprite objectToInteract;
    public string textToDisplay;

    private List<Dialog> dialog;
    private Storyflow storyflow;

	// Use this for initialization
	void Start () {
        dialog = new List<Dialog>();
        dialog.Add(new Dialog(objectToInteract, textToDisplay));
        
	}
	
    public void clickOnObject()
    {
        storyflow = GameObject.Find("DataStorage").GetComponent<Storyflow>();
        storyflow.interactWithObject(dialog);
    }
}
