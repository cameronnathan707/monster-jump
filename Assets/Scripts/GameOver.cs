using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameOver : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene(Constants.GAME_SCENE);
    }

    public void Menu()
    {
        Destroy(GameObject.Find("BackgroundMusic"));
        SceneManager.LoadScene(Constants.MENU_SCENE);
    }

    public void Quit()
    {
        Debug.Log("Game Shut Down");
        Application.Quit();
        #if UNITY_EDITOR
                EditorApplication.isPlaying = false;
        #endif
    }
}
