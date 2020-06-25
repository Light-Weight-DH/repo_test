using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updown_Obstacle : MonoBehaviour
{
    GameObject player;
    GameObject StartingPoint;
    Vector3 pos;
    public float Yminus = 0;
    public float Yplus = 0;
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
        if (transform.localPosition.y > pos.y + Yplus)
        {
            a = -1;
        }
        else if (transform.localPosition.y < pos.y - Yminus)
        {
            a = 1;
        }
        transform.Translate(Vector3.up * speed * Time.deltaTime * a);
    }
}
