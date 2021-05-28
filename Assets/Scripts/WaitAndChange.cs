using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitAndChange : MonoBehaviour
{
    public Animator animator;
    private int SceneToLoad;
    
    IEnumerator Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name != Constants.MENU_SCENE)
        {
            yield return new WaitForSeconds(3);
            Fade(1);
        }
    }

    public void Fade(int SceneIndex)
    {
        SceneToLoad = SceneIndex;
        animator.SetTrigger("FadeOut");
    }

    public void onFadeComplete()
    {
        SceneManager.LoadScene(SceneToLoad);
    }

}
