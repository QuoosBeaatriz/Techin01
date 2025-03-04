﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public GameOver GameOver;
    int maxPlatform = 0;
    public GameObject player;

    // Start is called before the first frame update

    public void GameOverActive()
    {
        GameOver.Setup(maxPlatform);
    }
    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("PointMor") == true)
        {
            GameOverActive();
        }
    }
}
