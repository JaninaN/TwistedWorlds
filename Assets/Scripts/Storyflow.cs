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

public enum GameState
{
    Idle,
    Talk,
    Dead
}


public class Storyflow : MonoBehaviour {

    //Indicates the Progress of the Player for variation in NPCs behaviour
    public enum State
    {
        Intro,
        Tutorial,
        Chosen,
        Traveler
    }

    State currentState;
    GameState gState;
    Character currentCharacter;
    int dialogCount = 0, currentDialog = 0;
    GameObject dialogBox;
    Talkbox_fit_to_situation talkbox;

	// Use this for initialization
	void Start () {
        currentState = State.Intro;
        gState = GameState.Idle;
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
        currentCharacter = character;
        switch (currentState)
        {
            case State.Intro:
                if(character == Character.Fox_Mum)
                {
                    if(currentDialog == 0)
                    {
                        Dialog dia = ChapterOneDialogs.FOX_MUM_1[0];
                        talkbox.show(dia.getCharacter(), dia.getText());
                        currentDialog = 1;
                        dialogCount = ChapterOneDialogs.FOX_MUM_1.Count;
                        gState = GameState.Talk;
                    }else if(currentDialog < dialogCount)
                    {
                        Dialog dia = ChapterOneDialogs.FOX_MUM_1[currentDialog];
                        talkbox.show(dia.getCharacter(), dia.getText());
                        currentDialog++;
                    }else
                    {
                        talkbox.hide();
                        currentDialog = 0;
                        gState = GameState.Idle;
                    }
                }else
                {
                    talkbox.hide();
                    currentDialog = 0;
                    gState = GameState.Idle;
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

    public void nextState()
    {
        switch (currentState)
        {
            case State.Intro:
                currentState = State.Tutorial;
                break;
            case State.Tutorial:
                currentState = State.Chosen;
                break;
            case State.Chosen:
                currentState = State.Traveler;
                break;
        }
    }

    public GameState getGameState()
    {
        return gState;
    }
}
