﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //オブジェクトの回転
        transform.Rotate(1f, 0f, 2.5f);
    }
}
