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
        GameObject.Find("DataStorage").GetComponent<Storyflow>().ItemCollected(item);
        Destroy(gameObject);
    }

    public void setCollectable()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}
