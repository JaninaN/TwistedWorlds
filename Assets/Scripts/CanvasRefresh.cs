using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasRefresh : MonoBehaviour {

    //Add listener to sceneLoaded Event. It´s called if a Scene was loaded
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //Refresh References to new Storyflow Component
        Storyflow story = GameObject.Find("DataStorage").GetComponent<Storyflow>();
        GameObject dialogWindow = GameObject.Find("DialogWindow");
        GameObject verblender = GameObject.Find("DialogWindow");
        GameObject storyDesicionLeft = GameObject.Find("StoryDesicionLeft");
        GameObject storyDesicionRight = GameObject.Find("StoryDesicionRight");

        dialogWindow.GetComponent<Button>().onClick.RemoveAllListeners();
        verblender.GetComponent<Button>().onClick.RemoveAllListeners();
        storyDesicionLeft.GetComponent<Button>().onClick.RemoveAllListeners();
        storyDesicionRight.GetComponent<Button>().onClick.RemoveAllListeners();

        dialogWindow.GetComponent<Button>().onClick.AddListener(() => story.continueTalk());
        verblender.GetComponent<Button>().onClick.AddListener(() => story.continueStory());
        storyDesicionLeft.GetComponent<Button>().onClick.AddListener(() => story.chooseLeft());
        storyDesicionRight.GetComponent<Button>().onClick.AddListener(() => story.chooseRight());
    }
}
