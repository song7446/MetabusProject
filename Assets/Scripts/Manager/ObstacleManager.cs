using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void CreateObstacle()
    {
        int idx = Random.Range(0, 4);
        float randomX = 0f;
        float randomY = 0f;
        switch (idx)
        {
            // 위
            case 0:
                randomX = Random.Range(-20f, 18f);
                randomY = 11f;
                break;
            // 아래 
            case 1:
                randomX = Random.Range(-20f, 18f);
                randomY = -11f;
                break;
            // 왼쪽
            case 2:
                randomX = -20f;
                randomY = Random.Range(-11f, 11f);
                break;
            // 오른쪽 
            case 3:
                randomX = 17f;
                randomY = Random.Range(-11f, 11f);
                break;
        }

        GameObject obstacle = Instantiate(obstacles[0]);
        obstacle.transform.position = new Vector2(randomX, randomY);
    }
}
