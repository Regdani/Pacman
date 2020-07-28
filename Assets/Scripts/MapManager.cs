using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject pacman;
    public Transform target;


    //teleport
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Pacman")
        {
            pacman.transform.position = target.transform.position;
        }
    }

}
