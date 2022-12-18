using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scoring : MonoBehaviour
{
    /*
    public static int totalScore;
    public static int highScore;
   */
    public static Scoring instance;

   public Text scoreText;
   public Text highscoreText;
   //public Text highScoreNameText;

   int score=0;
   int highScore = 0;
   string highscoreName;
   string highscoreNameSave;
   string playerName;


   private void Awake(){
        instance = this; 
   }

   public void start()
   {
    highScore = PlayerPrefs.GetInt("highScore",0);
    highscoreName = PlayerPrefs.GetString("highScorename", " ");
    scoreText.text = "Player: " + PlayerPrefs.GetString("username")+ " | Score: [ " + score + " ]";
    highscoreText.text = "HIGHSCORE: " + highscoreName + " [ " + highScore + " ] ";
   }

   public void AddPoint()
   { //this function will serve as a saving point for the highscore and highscorename
    highscoreNameSave = PlayerPrefs.GetString("username");
    score += 1;
    scoreText.text = "Player: " + PlayerPrefs.GetString("username")+ " | Score: [ " + score + " ]";


    if(highScore < score){
        PlayerPrefs.SetInt("highScore", score);
        PlayerPrefs.SetString("highScorename", highscoreNameSave);
    }
   }

    public void reset()
    {
        PlayerPrefs.SetInt("playerScore", score);
        score = 0;
        scoreText.text =  "Score: " + score;
        playerName = PlayerPrefs.GetString("username");
        PlayerPrefs.SetString("playerName", playerName);


         highScore = PlayerPrefs.GetInt("highScore",0);
         highscoreName = PlayerPrefs.GetString("highScorename", " ");
         highscoreText.text = "HIGHSCORE: " + highscoreName + " [ " + highScore + " ] ";
    }
}
