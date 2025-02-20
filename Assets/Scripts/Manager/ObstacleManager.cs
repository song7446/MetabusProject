using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;

    // 위
    private Vector2 spawnPointUP1 = new Vector2(-20f, 11f);
    private Vector2 spawnPointUP2 = new Vector2(17f, 11f);

    // 아래 
    private Vector2 spawnPointUP3 = new Vector2(-20f, -11f);
    private Vector2 spawnPointUP4 = new Vector2(17f, -11f);

    // 왼쪽
    private Vector2 spawnPointUP5 = new Vector2(-20f, 11f);
    private Vector2 spawnPointUP6 = new Vector2(-20f, -11f);

    // 오른쪽
    private Vector2 spawnPointUP7 = new Vector2(17f, 11f);
    private Vector2 spawnPointUP8 = new Vector2(17f, -11f);

    public Vector2 startPoint = new Vector2();
    public Vector2 endPoint = new Vector2();

    public void CreateObstacle()
    {
        int idx = Random.Range(0, 4);
        float randomX = 0f;
        float randomY = 0f;

        switch (idx)
        {
            // 위
            case 0:
                randomX = Random.Range(-19f, 17f);
                randomY = 10f;
                startPoint = new Vector2(randomX, randomY);
                endPoint = new Vector2(randomX, -11);
                break;
            // 아래 
            case 1:
                randomX = Random.Range(-19f, 17f);
                randomY = -10f;
                startPoint = new Vector2(randomX, randomY);
                endPoint = new Vector2(randomX, 11);
                break;
            // 왼쪽
            case 2:
                randomX = -19f;
                randomY = Random.Range(-10f, 11f);
                startPoint = new Vector2(randomX, randomY);
                endPoint = new Vector2(17, randomY);
                break;
            // 오른쪽 
            case 3:
                randomX = 16f;
                randomY = Random.Range(-10f, 10f);
                startPoint = new Vector2(randomX, randomY);
                endPoint = new Vector2(-20, randomY);
                break;
        }
        int randIdx = Random.Range(0, 7);
        GameObject obstacle = Instantiate(obstacles[randIdx]);
        obstacle.transform.position = new Vector2(randomX, randomY);
        obstacle.transform.SetParent(transform);
    }

    public void DestroyObstacles()
    {
        foreach (Transform child in transform) 
        {
            Destroy(child.gameObject);
        }
    }
}
