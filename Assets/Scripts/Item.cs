using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item{

    int id;
    Sprite image;
    string description;

	public Item(int itemID, Sprite picture, string text)
    {
        id = itemID;
        image = picture;
        description = text;
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
