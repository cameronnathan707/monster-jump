﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    Rigidbody2D rb;
    float movement = 0f;
    public Transform cameraTransform;
    public Transform playerTransform;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        if(playerTransform.position.y < cameraTransform.position.y - 4.2)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    void FixedUpdate()
    {
        //Movement
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;

    }
}
