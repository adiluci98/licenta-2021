﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodStuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Buff")
        {
            transform.Rotate(3, 0, 0);
        }
        if (gameObject.name == "Coin" || gameObject.name == "Coin(Clone)")
        {
            transform.Rotate(0, 0, -3);
        }
    }
}
