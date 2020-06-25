using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash_Event : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;
    GameObject player;

    public float jumpPower = 5f;
    // Start is called before the first frame update
    
   


    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        //Vector3 pos = other.gameObject.transform.position;
        if (other.gameObject == player)
        {
            Vector3 originPoint = new Vector3();
            originPoint.x = player.transform.position.x + 0f;
            originPoint.y = player.transform.position.y + 1f;//위 아래 아래로 떨구는 함정 가능
            originPoint.z = player.transform.position.z + 1f;
            PlayerRigidbody.AddForce(Vector3.up * jumpPower*2, ForceMode.Impulse);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
