using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCamera_Action : MonoBehaviour
{
    public GameObject player;

    public float offsetX = 0f;
    public float offsetY = 25f;
    public float offsetZ = -35f;

    Vector3 cameraPosition;

    //게임 상 모든 update를 마친 후
    //실행하는 마지막 update 사이클
    void LateUpdate()
    {
        cameraPosition.x = player.transform.position.x + offsetX;
        cameraPosition.y = player.transform.position.y + offsetY;
        cameraPosition.z = player.transform.position.z + offsetZ;

        transform.position = cameraPosition;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
