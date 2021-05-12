using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{
    const string GAME_SCENE = "Game";
    public void PlayGame()
    {
        SceneManager.LoadScene(GAME_SCENE);
    }

    public void Quit()
    {
        Debug.Log("Application Succesfully Shut Down!");
        Application.Quit();
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #endif
    }
}
