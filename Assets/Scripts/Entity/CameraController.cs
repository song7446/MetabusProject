using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // �÷��̾� ������Ʈ 
    [SerializeField] protected GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ī�޶� �÷��̾� ����ٴϱ�  
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
