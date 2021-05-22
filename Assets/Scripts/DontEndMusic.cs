using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontEndMusic : MonoBehaviour
{
    public AudioSource music;
    private void Awake()
    {
            DontDestroyOnLoad(transform.gameObject);
    }
}
