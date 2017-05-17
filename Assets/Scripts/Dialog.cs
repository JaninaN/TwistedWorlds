using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog{

    Sprite character;
    string text;

    public Dialog(Sprite c, string txt)
    {
        character = c;
        text = txt;
    }

    public Sprite getCharacter()
    {
        return character;
    }

    public string getText()
    {
        return text;
    }
}
