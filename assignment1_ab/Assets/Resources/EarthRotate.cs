﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.parent.position, new Vector3(0, 1, 0), 90 * Time.deltaTime);
         transform.Rotate(new Vector3(0, 1, 0), 90 * Time.deltaTime);

    }

}
