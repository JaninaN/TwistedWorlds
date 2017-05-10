using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Fox_Mum,
    Fox_Child,
    Deer_Mum,
    Deer_Dad,
    Deer_Son,
    Deer_Daughter
}


public class Storyflow : MonoBehaviour {

    public enum State
    {
        Intro,
        Tutorial,
        Chosen,
        Traveler
    }

    State currentState;
    Character currentCharacter;
    int conCount = 0;
    GameObject dialogBox;
    Talkbox_fit_to_situation talkbox;

	// Use this for initialization
	void Start () {
        currentState = State.Intro;
        currentCharacter = Character.Fox_Child;
        dialogBox = GameObject.Find("DialogBox");
        talkbox = dialogBox.GetComponent<Talkbox_fit_to_situation>();
    }

    public void continueTalk()
    {
        talkTo(currentCharacter);
    }
	
	public void talkTo(Character character)
    {
        switch (currentState)
        {
            case State.Intro:
                if(character == Character.Fox_Mum && conCount == 0)
                {
                    talkbox.show(ChapterOneSprites.DEER_MUM_HEAD, ChapterOneDialogs.FOX_MUM_1);
                    currentCharacter = Character.Fox_Mum;
                    conCount = 7;
                }else if(character == Character.Fox_Mum && conCount == 7)
                {
                    talkbox.show(ChapterOneSprites.DEER_SON_HEAD, ChapterOneDialogs.FOX_CHILD_1);
                    conCount--;
                }else
                {
                    talkbox.hide();
                }
                break;
            case State.Tutorial:
                break;
            case State.Chosen:
                break;
            case State.Traveler:
                break;
        }
    }
}
