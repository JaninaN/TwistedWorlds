using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void NewGame(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        Destroy(GameObject.Find("Canvas"));
        SceneManager.LoadScene("MainMenu");
    }
}
