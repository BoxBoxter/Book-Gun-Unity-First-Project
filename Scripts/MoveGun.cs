﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float rotateSpeed = 15.0f;
    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        /*transform.Translate(new Vector3(0, 0, hInput) * Time.deltaTime * moveSpeed);*/

        float vInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hInput, 0, vInput) * Time.deltaTime * moveSpeed);

        //rotate
        //transform.Translate(new Vector3(0, hInput, 0) * Time.deltaTime * rotateSpeed);


    }
}
