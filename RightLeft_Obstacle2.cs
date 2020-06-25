using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLeft_Obstacle2 : MonoBehaviour
{
    GameObject player;
    GameObject StartingPoint;
    int a = 1;
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
        if (transform.localPosition.x < -195.0f)
        {
            a = -1;
        }
        else if (transform.localPosition.x > -188.0f)
        {
            a = 1;
        }
        transform.Translate(Vector3.up * 5.0f * Time.deltaTime * a);
    }
}
