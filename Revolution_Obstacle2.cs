using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution_Obstacle2 : MonoBehaviour
{
    GameObject player;
    GameObject StartingPoint;
    Vector3 Vec;


    public GameObject Center;//공전 기준점
    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Vec.x = 0;
        Vec.y = 1;
        Vec.z = 0;
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
        RevolutionAround();
    }

    void RevolutionAround()
    {
        transform.RotateAround(Center.transform.position, Vec, speed * Time.deltaTime);
    }
}
