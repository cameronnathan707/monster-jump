using UnityEngine;
using UnityEngine.UI;
using UnityEditor;


public class QuitButton : MonoBehaviour
{
    public Button Quit;

    void Start()
    {
        Button btn = Quit.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.Quit();
           #if UNITY_EDITOR
              EditorApplication.isPlaying = false;
           #endif
    }
}