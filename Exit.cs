﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameEnd();
    }
    public void gameEnd()
    {
        Application.Quit();
    }
   
}
