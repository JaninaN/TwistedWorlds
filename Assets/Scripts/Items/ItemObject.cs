using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject{

    Item thisItem;
    int id;
    Sprite image;
    string description;

	public ItemObject(Item i, int itemID, Sprite picture, string text)
    {
        thisItem = i;
        id = itemID;
        image = picture;
        description = text;
    }

    public Item getItem()
    {
        return thisItem;
    }

    public int getID()
    {
        return id;
    }

    public Sprite getImage()
    {
        return image;
    }

    public string getDescription()
    {
        return description;
    }
}
