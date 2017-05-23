using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSprites : MonoBehaviour {

    public static Sprite ITEM_1;
    public static Sprite ITEM_2;
    
    private void Awake()
    {
        ITEM_1 = Resources.Load<Sprite>("Items/Test_Schild");
        ITEM_2 = Resources.Load<Sprite>("Items/Charm");
    }
}
