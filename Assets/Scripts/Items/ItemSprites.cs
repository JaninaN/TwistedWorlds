using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSprites : MonoBehaviour {

    public static Sprite APPLE;
    public static Sprite ITEM_2;
    
    private void Awake()
    {
        APPLE = Resources.Load<Sprite>("Items/Apfel");
        ITEM_2 = Resources.Load<Sprite>("Items/Charm");
    }
}
