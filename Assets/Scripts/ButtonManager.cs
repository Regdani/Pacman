using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject Playbutton; 
    


    private void Start()
    {
        Debug.Log("STOP!");
        Time.timeScale = 0;
    }

 
    public void PlayGame()
    {
        Debug.Log("PLAY!");
        Time.timeScale = 1;
        Playbutton.SetActive(false);
    }
    public void QuitGame()
    {
        
        Application.Quit();
        Debug.Log("QUIT!");

    }

  


 

}
