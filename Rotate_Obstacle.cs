using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Obstacle : MonoBehaviour
{
    GameObject player;
    GameObject StartingPoint;
    Vector3 movement;

    public float speed = 10f;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
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
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
