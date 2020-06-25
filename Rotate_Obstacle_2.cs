using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Obstacle_2 : MonoBehaviour
{
    Vector3 RotateVector;
   
    GameObject player;
    GameObject StartingPoint;
    Vector3 movement;

    public float speed = 100f;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        RotateVector.x = 1;
        RotateVector.y = 0;
        RotateVector.z = 0;

        player = GameObject.FindGameObjectWithTag("Player");
        StartingPoint = GameObject.FindGameObjectWithTag("Starting_Point");
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == player)
        {
            player.transform.position = StartingPoint.transform.position;

        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
    }
}
