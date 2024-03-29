﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mov : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;
    public float fixedRotetion = 0f;
    public float stop = 0f;

    void Start() { 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.eulerAngles = new Vector3 (fixedRotetion, 0, 0);
        rb.AddForce(0, 0, 0);
        
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")){
            transform.Translate(new Vector3 (0, 0, -moveSpeed) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")){
            transform.Translate(new Vector3 (0, 0, moveSpeed) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w")){
            transform.Translate(new Vector3 (-moveSpeed, 0, 0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s")){
            transform.Translate(new Vector3 (moveSpeed, 0, 0) * Time.deltaTime);
        }
        if(Input.GetKey("space")){
            transform.Translate(new Vector3 (0, moveSpeed, 0) * Time.deltaTime);
        }
        if(Input.GetKey("r")){
            transform.eulerAngles = new Vector3 (0, 0, 0);
        }
        if(Input.GetKey("e")){
            transform.position = new Vector3 (0, 1, 0);
        }
    }
}
