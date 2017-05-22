using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {


    Vector3 hidePos;
    Vector3 showPos;
    List<Item> items;
    //todo fill item presentation
    int currentPage;

    // Use this for initialization
    void Start () {
        hidePos = transform.localPosition;
        showPos = new Vector3(hidePos.x, hidePos.y - GetComponent<RectTransform>().rect.height, hidePos.z);
        items = new List<Item>();
        currentPage = 0;
	}
	
	public void showInventory()
    {
        transform.localPosition = showPos;
        currentPage = 1;
        
    }

    public void hideInventory()
    {
        transform.localPosition = hidePos;
    }

    public void addItem(Item item)
    {
        items.Add(item);
        if (items.Count > 10)
        {
            GameObject.Find("NextPage").GetComponent<Image>().enabled = true;
            GameObject.Find("NextPage").GetComponent<Button>().enabled = true;
        }
    }

    public void removeItem(Item item)
    {
        items.Remove(item);
        if (items.Count <= 10)
        {
            GameObject.Find("NextPage").GetComponent<Image>().enabled = false;
            GameObject.Find("NextPage").GetComponent<Button>().enabled = false;
        }
    }

    void showItems()
    {

    }
}
