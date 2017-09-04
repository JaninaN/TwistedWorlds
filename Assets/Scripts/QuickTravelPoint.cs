using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickTravelPoint : MonoBehaviour {

    public string scene;

    // Use this for initialization
    void Start()
    {

    }
    
    public void travel()
    {
        SceneManager.LoadScene(scene);
        SceneManager.MoveGameObjectToScene(GameObject.Find("Canvas"), SceneManager.GetSceneByName(scene));
        GameObject.Find("QuickTravel").GetComponent<QuickTravelMap>().hideMap();
        GameObject.Find("Inventory").GetComponent<InventoryManager>().hideInventory();
    }
}
