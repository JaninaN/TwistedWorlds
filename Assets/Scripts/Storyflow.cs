using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Available Characters for Interaction
public enum Character
{
    Fox_Mum,
    Fox_Child,
    Deer_Mum,
    Deer_Dad,
    Deer_Son,
    Deer_Daughter,
    Owl,
    Chipmunk,
    Stork,
    Object
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
        Traveler,
        WorldsEnd,
        DemosEnd
    }

    State currentState;
    GameState gState;
    Character currentCharacter;
    List<Dialog> objectDialog;
    //dialogCount = Number of Dialogs in a Conversation  currentDialog = current Dialog to display in Conversation
    int dialogCount = 0, currentDialog = 0;
    GameObject dialogBox;
    GameObject leftChoice;
    GameObject rightChoice;
    Talkbox_fit_to_situation talkbox;
    Text storybox;

    AudioSource soundDestroy;

  
    

	// Use this for initialization
	public void Start () {
        currentState = State.Intro;
        gState = GameState.Idle;
        currentCharacter = Character.Fox_Child;
        dialogBox = GameObject.Find("DialogBox");
        leftChoice = GameObject.Find("StoryDesicionLeft");
        rightChoice = GameObject.Find("StoryDesicionRight");
        talkbox = dialogBox.GetComponent<Talkbox_fit_to_situation>();
        storybox = GameObject.Find("Storytext").GetComponent<Text>();

    }

    //To continue a runnig Conversation
    public void continueTalk()
    {
        talkTo(currentCharacter);
    }
	
    //Depending on the Progress of the Player and the Character the Player is talking to, a Conversation will be displayed
	public void talkTo(Character character)
    {
        currentCharacter = character;

        //an Object with fixed dialog
        if(character == Character.Object)
        {
            toDialogue(objectDialog);
        }else
        //a Person with variable dialogs
        {
            switch (currentState)
            {
                case State.Intro:
                    
                    if(character == Character.Deer_Mum)
                    {
                        if(currentDialog == dialogCount)
                        {
                            GameObject.Find("Apfel").GetComponent<ItemCollectable>().setCollectable();
                        }
                        toDialogue(ChapterOneDialogs.DEER_MUM_1);
                    }
                    else if (character == Character.Fox_Child)
                    {
                        toDialogue(ChapterOneDialogs.FOX_SON_1);
                    }
                    else if(character == Character.Fox_Mum)
                    {
                        toDialogue(ChapterOneDialogs.FOX_MUM_1);
                    }
                    else if (character == Character.Stork)
                    {
                        toDialogue(ChapterOneDialogs.STORK_1);
                    }
                    else if (character == Character.Chipmunk)
                    {
                        toDialogue(ChapterOneDialogs.CHIPMUNK_1);
                    }
                    else
                    {
                        talkbox.hide();
                        currentDialog = 0;
                        gState = GameState.Idle;
                    }
                    break;
                case State.Tutorial:
                    
                    if (character == Character.Deer_Mum)
                    {
                        toDialogue(ChapterOneDialogs.DEER_MUM_2);
                    }
                    else if (character == Character.Fox_Child)
                    {
                        toDialogue(ChapterOneDialogs.FOX_SON_2);
                    }
                    else if (character == Character.Fox_Mum)
                    {
                        if (currentDialog == dialogCount)
                        {
                            GameObject.Find("Test_Schild_3").GetComponent<Collider2D>().enabled = true;

                        }
                        if (GameObject.Find("Test_Schild_3").GetComponent<Collider2D>().enabled == true)
                        {
                            toDialogue(ChapterOneDialogs.FOX_MUM_3);
                        }
                        else
                        {
                            toDialogue(ChapterOneDialogs.FOX_MUM_2);
                        }
                    
                    }
                    else if (character == Character.Stork)
                    {
                        toDialogue(ChapterOneDialogs.STORK_1);
                    }
                    else if (character == Character.Chipmunk)
                    {
                        toDialogue(ChapterOneDialogs.CHIPMUNK_1);
                    }
                    else
                    {
                        talkbox.hide();
                        currentDialog = 0;
                        gState = GameState.Idle;
                    }
                    break;
                case State.Chosen:
                    if (character == Character.Deer_Mum)
                    {
                        toDialogue(ChapterOneDialogs.DEER_MUM_2);
                    }
                    else if (character == Character.Fox_Mum)
                    { 
                        //toDialogue(ChapterOneDialogs.FOX_MUM_2);
                    }
                    else if (character == Character.Owl)
                    {
                        if (currentDialog == dialogCount)
                        {
                            nextState();
                        }
                       toDialogue(ChapterOneDialogs.OWL_1);
                    }
                    else
                    {
                        talkbox.hide();
                        currentDialog = 0;
                        gState = GameState.Idle;
                    }
                    break;
                case State.Traveler:
                    if (character == Character.Deer_Mum)
                    {
                        toDialogue(ChapterOneDialogs.DEER_MUM_2);
                    }
                    else if (character == Character.Fox_Mum)
                    {
                        //toDialogue(ChapterOneDialogs.FOX_MUM_2);
                    }
                    else if (character == Character.Owl)
                    {
                        if (currentDialog == dialogCount)
                        {
                            nextState();
                        }
                        toDialogue(ChapterOneDialogs.OWL_3);
                    }
                    else
                    {
                        talkbox.hide();
                        currentDialog = 0;
                        gState = GameState.Idle;
                    }
                    break;
                case State.WorldsEnd:
                    if (character == Character.Deer_Mum)
                    {
                        toDialogue(ChapterOneDialogs.DEER_MUM_2);
                    }
                    else if (character == Character.Fox_Mum)
                    {
                        //toDialogue(ChapterOneDialogs.FOX_MUM_2);
                    }
                    else if(character == Character.Owl)
                    {
                        if (currentDialog == dialogCount)
                        {
                            //Game Over
                            currentState = State.DemosEnd;
                        }
                       toDialogue(ChapterOneDialogs.OWL_2);
                    }
                    else
                    {
                        talkbox.hide();
                        currentDialog = 0;
                        gState = GameState.Idle;
                    }
                    break;
                case State.DemosEnd:
                    if (character == Character.Deer_Mum)
                    {
                        toDialogue(ChapterOneDialogs.DEER_MUM_2);
                    }
                    else if (character == Character.Fox_Mum)
                    {
                        //toDialogue(ChapterOneDialogs.FOX_MUM_2);
                    }
                    else if (character == Character.Owl)
                    {
                        toDialogue(ChapterOneDialogs.OWL_4);
                    }
                    else
                    {
                        talkbox.hide();
                        currentDialog = 0;
                        gState = GameState.Idle;
                    }
                    break;
            }


        }



    }

    public void interactWithObject(List<Dialog> dialog)
    {
        objectDialog = dialog;
        talkTo(Character.Object);
    }

    private void toDialogue(List<Dialog> dialog)
    {
        //Beginn of Conversation
        if (currentDialog == 0)
        {
            Dialog dia = dialog[0];
            talkbox.show(dia.getCharacter(), dia.getText());
            currentDialog = 1;
            dialogCount = dialog.Count;
            gState = GameState.Talk;
        }
        //Continue Conversation
        else if (currentDialog < dialogCount)
        {
            Dialog dia = dialog[currentDialog];
            talkbox.update(dia.getCharacter(), dia.getText());
            currentDialog++;
        }
        //End of Conversation
        else
        {
            talkbox.hide();
            currentDialog = 0;
            gState = GameState.Idle;
        }
    }

    //Screen is now black
    public void finishedFadeIn()
    {
        switch (currentState)
        {
            case State.Tutorial:
                tellStory(ChapterOneDialogs.FIRST_RIDDLE_BEGINNING);
                break;
            case State.Chosen:
                tellStory(ChapterOneDialogs.FIRST_RIDDLE_AMULET_COLLECTED);
                break;
        }
    }

    //Screen finished fade out from black to current Screen
    public void finishedFadeOut()
    {
        GameObject blend = GameObject.Find("Verblender");
        blend.GetComponent<Button>().enabled = true;
        storybox.text = "";
    }

    //If Player have to choose between two possibilities, the given answer is chooseLeft or chooseright
    public void chooseLeft()
    {
        //Player chose solving the riddle
        leftChoice.GetComponent<Image>().enabled = false;
        leftChoice.GetComponent<Button>().enabled = false;
        rightChoice.GetComponent<Image>().enabled = false;
        rightChoice.GetComponent<Button>().enabled = false;
        leftChoice.GetComponentInChildren<Text>().text = "";
        rightChoice.GetComponentInChildren<Text>().text = "";
        tellStory(ChapterOneDialogs.FIRST_RIDDLE_BEGINNING);
        nextState();
        GameObject.Find("Main Camera").GetComponent<CameraPositions>().fadeOutBlender();
    }

    public void chooseRight()
    {
        //Player chose destruction of Amulet box 
        leftChoice.GetComponent<Image>().enabled = false;
        leftChoice.GetComponent<Button>().enabled = false;
        rightChoice.GetComponent<Image>().enabled = false;
        rightChoice.GetComponent<Button>().enabled = false;
        leftChoice.GetComponentInChildren<Text>().text = "";
        rightChoice.GetComponentInChildren<Text>().text = "";
        currentState = State.WorldsEnd;
        GameObject.Find("Verblender").GetComponent<Button>().enabled = true;
        tellStory(ChapterOneDialogs.FIRST_RIDDLE_DESTROY_BOX);
        

    }

    public void ItemCollected(Item item)
    {
        switch (item)
        {
            case Item.Apple:
                nextState();
                break;

        }
    }

    private void tellStory(List<string> story)
    {
        //Beginn of Storytelling
        if (currentDialog == 0)
        {
            string dia = story[0];
            storybox.text = dia;
            currentDialog = 1;
            dialogCount = story.Count;
            gState = GameState.Talk;
        }
        //Continue Storytelling
        else if (currentDialog < dialogCount)
        {
            string dia = story[currentDialog];
            storybox.text = dia;
            currentDialog++;
        }
        //End of Storytelling
        else
        {
            storybox.text = "";
            currentDialog = 0;
            gState = GameState.Idle;
        }

        if (storybox.text.Contains("KRACK KRACH"))
        {
            soundDestroy = (AudioSource)gameObject.AddComponent<AudioSource>();
            AudioClip myAudioClip;
            myAudioClip = (AudioClip)Resources.Load("SFX/cracking_wood");
            soundDestroy.clip = myAudioClip;
            soundDestroy.volume = 0.5f;
            soundDestroy.Play();
        }
    }

    public void continueStory()
    {
        switch (currentState)
        {
            case State.Tutorial:
                if (currentDialog == dialogCount)
                {
                    //Player have to choose
                    GameObject.Find("Verblender").GetComponent<Button>().enabled = false;
                    leftChoice.GetComponent<Image>().enabled = true;
                    leftChoice.GetComponent<Button>().enabled = true;
                    rightChoice.GetComponent<Image>().enabled = true;
                    rightChoice.GetComponent<Button>().enabled = true;
                    leftChoice.GetComponentInChildren<Text>().text = ChapterOneDialogs.RIDDLE_ONE_YES;
                    rightChoice.GetComponentInChildren<Text>().text = ChapterOneDialogs.RIDDLE_ONE_NO;
                }
                else
                {
                    tellStory(ChapterOneDialogs.FIRST_RIDDLE_BEGINNING);
                }
                break;
            case State.Chosen:
                if (currentDialog == dialogCount)
                {
                    storybox.text = "";
                    GameObject sign = GameObject.Find("Test_Schild_3");
                    GameObject.Find("Main Camera").GetComponent<CameraPositions>().returnFromRiddle(sign.GetComponent<ChangePlace>().targetPlace);
                    GameObject.Find("Charm").GetComponent<Image>().enabled = true;
                }
                tellStory(ChapterOneDialogs.FIRST_RIDDLE_AMULET_COLLECTED);
                break;
            case State.WorldsEnd:
                if (currentDialog == dialogCount)
                {
                    storybox.text = "";
                    GameObject sign = GameObject.Find("Test_Schild_3");
                    GameObject.Find("Main Camera").GetComponent<CameraPositions>().returnFromRiddle(sign.GetComponent<ChangePlace>().targetPlace);
                }
                tellStory(ChapterOneDialogs.FIRST_RIDDLE_DESTROY_BOX);
                break;
        }


    }

    public void nextState()
    {
        switch (currentState)
        {
            /*case State.IntroText:
                currentState = State.Intro;
                break;
                */
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
