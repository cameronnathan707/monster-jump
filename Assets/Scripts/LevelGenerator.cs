using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject MainPatform;
    public GameObject SpringPatform;
    public GameObject CannonPlatform;
    public GameObject CoinPlatform;
    public float levelWidth = Screen.width;
    public float minY = .5f;
    public float maxY = 1.5f;
    private Vector3 currentPosition;
    private Vector2 screenBounds;
    public Transform playerTransform;
    public Transform cameraTransform;
    public List<GameObject> spawnedPlatforms;
    public int count;
    

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        currentPosition = new Vector3(0f, playerTransform.position.y, 0f);
        count = 0;
        spawnPlatform();
    }
    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        checkDistance();
        removePlatform();
    }

    void spawnPlatform()
    {
        GameObject newSpawn;
        currentPosition.x = Random.Range(-levelWidth/2, levelWidth/2);
        currentPosition.y += Random.Range(minY, maxY);
        switch (Random.Range(0, 20))
        {
            case 0:
                newSpawn = Instantiate(SpringPatform, currentPosition, Quaternion.identity);
                break;
            case 1:
                newSpawn = Instantiate(CannonPlatform, currentPosition, Quaternion.identity);
                break;
            case 2:
                newSpawn = Instantiate(CoinPlatform, currentPosition, Quaternion.identity);
                break;
            default:
                newSpawn = Instantiate(MainPatform, currentPosition, Quaternion.identity);
                break;
        }
        spawnedPlatforms.Add(newSpawn);
        count++;
    }


    void checkDistance()
    {
        if(screenBounds.y + 25f > spawnedPlatforms[count - 1].transform.position.y)
        {
            spawnPlatform();
        }
    }

    public void removePlatform()
    {
        if (spawnedPlatforms[0].transform.position.y < cameraTransform.position.y - Constants.CAMERA_B_EDGE)
        {
            GameObject rm = spawnedPlatforms[0];
            spawnedPlatforms.Remove(rm);
            Destroy(rm);
            count--;
        }
    }

}
