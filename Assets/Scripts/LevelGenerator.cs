using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject MainPatform;
    public GameObject SpringPatform;
    public GameObject CannonPatform;
    public GameObject CoinPlatform;
    public int numberOfPlatforms;
    public float levelWidth = Screen.width;
    public float minY = .5f;
    public float maxY = 1.5f;


    public Transform playerTransform;
    void Start()
    {
        Vector3 spawnPosition = new Vector3(0f, playerTransform.position.y - .5f, 0f);
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth/2, levelWidth/2);

            switch (Random.Range(0, 20))
            {
                case 0:
                    Instantiate(SpringPatform, spawnPosition, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(CannonPatform, spawnPosition, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(CoinPlatform, spawnPosition, Quaternion.identity);
                    break;
                default:
                    Instantiate(MainPatform, spawnPosition, Quaternion.identity);
                    break;
            }
                  
        }
    }

   
}
