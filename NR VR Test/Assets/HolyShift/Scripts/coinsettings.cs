﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinsettings : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    void update()
    {

        scoreText.GetComponent<Text>().text = "SCORE : " + theScore;

    }
}
