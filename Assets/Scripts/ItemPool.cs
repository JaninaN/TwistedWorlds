using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPool : MonoBehaviour {

    int currentID = 0;
    List<Item> items;

	// List of all aviable Items in whole Game
	void Start () {
        items = new List<Item>();
        items.Add(new Item(currentID++, ItemSprites.ITEM_1, ItemDescriptions.ITEM_1));
        items.Add(new Item(currentID++, ItemSprites.ITEM_2, ItemDescriptions.ITEM_2));
    }

    public Item getItem(int id)
    {
        return items[id];
    }
	
}
