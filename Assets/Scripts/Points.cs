using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Animator animator;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
     
        if (other.gameObject.name == "Pacman")
        {
           
            ScoreSystem.score += 10;
            Destroy(gameObject);
            animator.Play("Pacman");
            
        } 
    }

   
}

   

   

