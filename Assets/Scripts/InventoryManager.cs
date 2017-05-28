using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {


    Vector3 hidePos;
    Vector3 showPos;
    Color transparent = Color.clear;
    Color non_transparent;
    List<ItemObject> items;
    List<Image> itemDisplay;
    Text itemDescription;
    //current shown Page of Item Display
    int currentPage;

    // Use this for initialization
    void Start () {
        hidePos = transform.localPosition;
        showPos = new Vector3(hidePos.x, hidePos.y - GetComponent<RectTransform>().rect.height, hidePos.z);
        ColorUtility.TryParseHtmlString("#FFFFFFFF", out non_transparent);
        items = new List<ItemObject>();
        itemDisplay = new List<Image>();
        itemDescription = GameObject.Find("ItemDescription").GetComponent<Text>();
        currentPage = 1;

        //Fill itemDisplay with Image Components of Images that displays the Items
        itemDisplay.Add(GameObject.Find("Item_One").GetComponent<Image>());
        itemDisplay.Add(GameObject.Find("Item_Two").GetComponent<Image>());
        itemDisplay.Add(GameObject.Find("Item_Three").GetComponent<Image>());
        itemDisplay.Add(GameObject.Find("Item_Four").GetComponent<Image>());
        itemDisplay.Add(GameObject.Find("Item_Five").GetComponent<Image>());
        itemDisplay.Add(GameObject.Find("Item_Six").GetComponent<Image>());
        itemDisplay.Add(GameObject.Find("Item_Seven").GetComponent<Image>());
        itemDisplay.Add(GameObject.Find("Item_Eight").GetComponent<Image>());
        itemDisplay.Add(GameObject.Find("Item_Nine").GetComponent<Image>());
        itemDisplay.Add(GameObject.Find("Item_Ten").GetComponent<Image>());
        
    }
	
	public void showInventory()
    {
        transform.localPosition = showPos;
        currentPage = 1;
        loadItemPage();
    }

    public void hideInventory()
    {
        transform.localPosition = hidePos;
    }

    //adds Item to Inventory
    public void addItem(ItemObject item)
    {
        int pagesBefore = (items.Count + 9) / 10;
        if(items.Count == 0)
        {
            pagesBefore = 1;
        }
        items.Add(item);
        int pagesAfter = (items.Count + 9) / 10;
        //Item start filling next Page
        if (pagesBefore < pagesAfter)
        {
            GameObject.Find("NextPage").GetComponent<Image>().enabled = true;
            GameObject.Find("NextPage").GetComponent<Button>().enabled = true;
        }
        else
        {
            loadItemPage();
        }
    }

    //remove Item from Inventory
    public void removeItem(ItemObject item)
    {
        int pagesBefore = (items.Count + 9) / 10;
        items.Remove(item);
        int pagesAfter = (items.Count + 9) / 10;

        //last Page is empty after removing Item
        if(pagesBefore > pagesAfter)
        {
            //shown Page is last Page
            if(currentPage == pagesBefore)
            {
                currentPage -= 1;
            }
            else if(currentPage + 1 == pagesBefore)
            {
                GameObject.Find("NextPage").GetComponent<Image>().enabled = false;
                GameObject.Find("NextPage").GetComponent<Button>().enabled = false;
            }
        }
        //Numbers of Pages did not change
        else
        {
            loadItemPage();
        }
    }

    public void nextPage()
    {
        int pageCount = (items.Count + 9) / 10;
        if(currentPage < pageCount)
        {
            currentPage++;
            loadItemPage();
            GameObject.Find("PreviousPage").GetComponent<Image>().enabled = true;
            GameObject.Find("PreviousPage").GetComponent<Button>().enabled = true;
            if (currentPage == pageCount)
            {
                GameObject.Find("NextPage").GetComponent<Image>().enabled = false;
                GameObject.Find("NextPage").GetComponent<Button>().enabled = false;
            }
        }
    }

    public void previousPage()
    {
        if(currentPage > 1)
        {
            currentPage--;
            loadItemPage();
            GameObject.Find("NextPage").GetComponent<Image>().enabled = true;
            GameObject.Find("NextPage").GetComponent<Button>().enabled = true;
            if(currentPage == 1)
            {
                GameObject.Find("PreviousPage").GetComponent<Image>().enabled = false;
                GameObject.Find("PreviousPage").GetComponent<Button>().enabled = false;
            }
        }
    }

    //number [0...9] from item Displays in Inventory
    public void showDescription(int number)
    {
        int itemNumber = ((currentPage - 1) * 10) + number;
        if(itemNumber < items.Count)
        {
            itemDescription.text = items[itemNumber].getDescription();
        }
        
    }

    public void hideDescription()
    {
        itemDescription.text = "";
    }

    //test for adding Items on Click
    public void addTestItem()
    {
        addItem(GameObject.Find("DataStorage").GetComponent<ItemPool>().getItem(0));
    }

    void loadItemPage()
    {
        //clear Item Display
        foreach(Image img in itemDisplay)
        {
            img.color = transparent;
            img.sprite = null;
        }
        //Fill Display with updated Items
        int start = (currentPage - 1) * 10;
        for(int i = 0; (start + i) < items.Count && i < 10; i++)
        {
            itemDisplay[i].sprite = items[start + i].getImage();
            itemDisplay[i].color = non_transparent;
        }
    }
}
