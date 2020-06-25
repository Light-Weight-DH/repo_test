using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLeft_Obstacle_Custom : MonoBehaviour
{
    GameObject player;
    GameObject StartingPoint;
    Vector3 pos;
    public float Xminus=0;
    public float Xplus=0;
    public bool Left = false;
    public float speed = 5.0f;

    int a = 1;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.gameObject.transform.position;
        Debug.Log(pos);
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
        if (transform.localPosition.x > pos.x+Xplus)
        {
            a = -1;
        }
        else if (transform.localPosition.x < pos.x-Xminus)
        {
            a = 1;
        }
        transform.Translate(Vector3.down * speed * Time.deltaTime * a);
    }
}
