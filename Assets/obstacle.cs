﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
        Debug.Log("hello1111");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}