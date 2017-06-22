using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectable : MonoBehaviour {

    public Item item;
    public bool isCollectable;

    private void Start()
    {
        if (!isCollectable)
        {
            GetComponent<Collider2D>().enabled = false;
        }
    }

    public void collect()
    {
        GameObject.Find("Inventory").GetComponent<InventoryManager>().addItem(GameObject.Find("DataStorage").GetComponent<ItemPool>().getItem(item));
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("DataStorage").GetComponent<Storyflow>().ItemCollected(item);
    }

    public void setCollectable()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}
