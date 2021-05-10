using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatforms;
    public float levelWidth = Screen.width;
    public float minY = .8f;
    public float maxY = 2f;

    public Transform playerTransform;
    void Start()
    {
        Vector3 spawnPosition = new Vector3(0f, playerTransform.position.y - .5f, 0f);
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth/2, levelWidth/2);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
