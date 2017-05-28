using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Storage for every Item in Game. 
public enum Item{
    Shoppinglist,
    Apple
}

public class ItemPool : MonoBehaviour {

    int currentID = 0;
    List<ItemObject> items;

	// List of all aviable Items in whole Game
	void Start () {
        items = new List<ItemObject>();
        items.Add(new ItemObject(Item.Apple, currentID++, ItemSprites.ITEM_1, ItemDescriptions.ITEM_1));
        items.Add(new ItemObject(Item.Shoppinglist, currentID++, ItemSprites.ITEM_2, ItemDescriptions.ITEM_2));
    }

    public ItemObject getItem(int id)
    {
        return items[id];
    }

    public ItemObject getItem(Item item)
    {
        return items.Find(x => x.getItem() == item);
    }

}
