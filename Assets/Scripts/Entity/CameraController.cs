using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // 플레이어 오브젝트 
    [SerializeField] protected GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 카메라 플레이어 따라다니기  
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
