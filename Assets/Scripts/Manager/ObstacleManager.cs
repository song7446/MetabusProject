using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObstacleManager : MonoBehaviour
{
    // ��ֹ� ������
    [SerializeField] private GameObject[] obstacles;

    // ���� ����
    public Vector2 startPoint = new Vector2();

    // ������ ����
    public Vector2 endPoint = new Vector2();

    // ��ֹ� ���� �Լ�
    public void CreateObstacle()
    {
        // �� �Ʒ� ���� ������ ���� 
        int randPoint = Random.Range(0, 4);

        // ���� x ��ǥ
        float randomX = 0f;

        // ���� y ��ǥ
        float randomY = 0f;

        // ��ġ�� ���� ���� ��ǥ ����
        switch (randPoint)
        {
            // ��
            case 0:
                randomX = Random.Range(-19f, 17f);
                randomY = 10f;
                startPoint = new Vector2(randomX, randomY);
                endPoint = new Vector2(randomX, -11);
                break;
            // �Ʒ� 
            case 1:
                randomX = Random.Range(-19f, 17f);
                randomY = -10f;
                startPoint = new Vector2(randomX, randomY);
                endPoint = new Vector2(randomX, 11);
                break;
            // ����
            case 2:
                randomX = -19f;
                randomY = Random.Range(-10f, 11f);
                startPoint = new Vector2(randomX, randomY);
                endPoint = new Vector2(17, randomY);
                break;
            // ������ 
            case 3:
                randomX = 16f;
                randomY = Random.Range(-10f, 10f);
                startPoint = new Vector2(randomX, randomY);
                endPoint = new Vector2(-20, randomY);
                break;
        }

        // ��ֹ� ���� �� �ϳ� ����
        int randIdx = Random.Range(0, 7);

        // ���� ��ֹ� ����
        GameObject obstacle = Instantiate(obstacles[randIdx]);

        // ��ֹ� ���� ��ġ ���� 
        obstacle.transform.position = new Vector2(randomX, randomY);

        // ��ֹ� �θ� ������Ʈ ���� 
        obstacle.transform.SetParent(transform);
    }

    // ��� ��ֹ� ���� �Լ�
    public void DestroyObstacles()
    {
        foreach (Transform child in transform) 
        {
            Destroy(child.gameObject);
        }
    }
}
