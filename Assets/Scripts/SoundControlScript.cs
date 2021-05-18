using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControlScript : MonoBehaviour
{
    public static AudioClip MainPatform;
    public static AudioClip SpringPatform;
    public static AudioClip CannonPatform;
    public static AudioClip CoinPlatform;
    static AudioSource AudioSrc;

    void Start()
    {
        MainPatform = Resources.Load<AudioClip>("Normal");
        SpringPatform = Resources.Load<AudioClip>("Spring");
        CannonPatform = Resources.Load<AudioClip>("Cannon 1");
        CoinPlatform = Resources.Load<AudioClip>("Mario-coin-sound");

        AudioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "MainPlatform":
                AudioSrc.PlayOneShot(MainPatform);
                break;
            case "SpringPlatform":
                AudioSrc.PlayOneShot(SpringPatform);
                break;
            case "CannonPlatform":
                AudioSrc.PlayOneShot(CannonPatform);
                break;
            case "CoinPlatform":
                    AudioSrc.PlayOneShot(CoinPlatform);
                break;

        }
    }
}
