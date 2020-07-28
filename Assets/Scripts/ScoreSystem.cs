using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int score;
    public Text scoreTxt;
    public GameObject button;
    

    void Start()
    {
        scoreTxt = GetComponent<Text>();
        score = 0;
        
    }

    
    void Update()
    {
        scoreTxt.text = "" + score;
        if (scoreTxt.text=="2860")
        {
            Time.timeScale = 0;
            button.SetActive(true);
        }


    }

    public void YouWon()
    {
        button.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
