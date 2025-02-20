using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObstacleManager : MonoBehaviour
{
    // 장애물 프리팹
    [SerializeField] private GameObject[] obstacles;

    // 시작 지점
    public Vector2 startPoint = new Vector2();

    // 마지막 지점
    public Vector2 endPoint = new Vector2();

    // 장애물 생성 함수
    public void CreateObstacle()
    {
        // 위 아래 왼쪽 오른쪽 랜덤 
        int randPoint = Random.Range(0, 4);

        // 랜덤 x 좌표
        float randomX = 0f;

        // 랜덤 y 좌표
        float randomY = 0f;

        // 위치에 따라 랜덤 좌표 지정
        switch (randPoint)
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

        // 장애물 개수 중 하나 랜덤
        int randIdx = Random.Range(0, 7);

        // 랜덤 장애물 생성
        GameObject obstacle = Instantiate(obstacles[randIdx]);

        // 장애물 시작 위치 지정 
        obstacle.transform.position = new Vector2(randomX, randomY);

        // 장애물 부모 오브젝트 지정 
        obstacle.transform.SetParent(transform);
    }

    // 모든 장애물 삭제 함수
    public void DestroyObstacles()
    {
        foreach (Transform child in transform) 
        {
            Destroy(child.gameObject);
        }
    }
}
