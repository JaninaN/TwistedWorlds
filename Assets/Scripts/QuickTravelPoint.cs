using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuickTravelPoint : MonoBehaviour {

    public string scene;
    public string ingameName;

    private Text details;

    // Use this for initialization
    void Start()
    {
        details = GameObject.Find("TravelDetails").GetComponent<Text>();
    }
    
    public void travel()
    {
        SceneManager.LoadScene(scene);
        SceneManager.MoveGameObjectToScene(GameObject.Find("Canvas"), SceneManager.GetSceneByName(scene));
        GameObject.Find("QuickTravel").GetComponent<QuickTravelMap>().hideMap();
        GameObject.Find("Inventory").GetComponent<InventoryManager>().hideInventory();
    }

    public void showDetails()
    {
        string txt = "Reise nach " + ingameName;
        details.text = txt;
    }

    public void hideDetails()
    {
        details.text = "";
    }
}
