﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndObstacle3 : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == player)
        {
            SceneManager.LoadScene("Stage2_Clear");

        }
    }
}
