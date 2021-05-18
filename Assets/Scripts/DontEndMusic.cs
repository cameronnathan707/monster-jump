using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontEndMusic : MonoBehaviour
{
    public AudioSource music;
    private void Update()
    {
      if(!(music.isPlaying))
      {
            music.Play();
      }   
    }
    private void Awake()
    {
            DontDestroyOnLoad(transform.gameObject);
    }
}
