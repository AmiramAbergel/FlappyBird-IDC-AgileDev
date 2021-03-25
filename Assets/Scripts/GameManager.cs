using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public Text scoreText; 
    public static GameManager instance;
    public GameObject gameOvertext; 

    private int score = 0;                      
    public bool gameOver = false;               
    public float scrollSpeed = -20.5f;

    void Awake()
    {
      
        if (instance == null)
           
            instance = this;
       
        else if(instance != this)
            
            Destroy (gameObject);
    }
      void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdScored()
    {
        if (gameOver)    
            return;
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        gameOvertext.SetActive (true);
        gameOver = true;
        
    }
   
}

