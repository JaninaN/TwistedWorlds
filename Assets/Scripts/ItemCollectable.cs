using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectable : MonoBehaviour {

    public Item item;
	
    public void collect()
    {
        GameObject.Find("Inventory").GetComponent<InventoryManager>().addItem(GameObject.Find("DataStorage").GetComponent<ItemPool>().getItem(item));
    }
}
