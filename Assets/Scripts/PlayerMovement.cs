using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
  
    public float speed = 2f;
    private Vector2 directoin = Vector2.zero;
    private AudioSource audioData;

    private void Start()
    {
        audioData = GetComponent<AudioSource>();

    }

    private void Update()
    {
        CheckInput();
        Move();
    }

    private void CheckInput()
    {
        Vector3 temp = transform.rotation.eulerAngles;
        if (Input.GetKeyDown("w"))
        {
            directoin = Vector2.up;
            temp.z = 90.0f;
        }
        
        else if (Input.GetKeyDown("s"))
        {
            directoin = Vector2.down;
            temp.z = -90.0f;
        }

        else if (Input.GetKeyDown("a"))
        {
            directoin = Vector2.left;
            temp.z = 180.0f;
        }

        else if (Input.GetKeyDown("d"))
        {
            directoin = Vector2.right;
            temp.z = 0f;
        }

        transform.rotation = Quaternion.Euler(temp);
    }

    private void Move()
    {
        transform.localPosition +=(Vector3) (directoin * speed) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "point")
        {
            audioData.Play();
        }
    }
}