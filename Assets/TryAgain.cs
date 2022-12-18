using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    
    public Text playerName;
    public Text playerScore;
    public Text highscore;
    public Text newHighScore;

    int score = 0;
    int highScore =0;
    void Start()
    {
        score = PlayerPrefs.GetInt("playerScore");
        highScore = PlayerPrefs.GetInt("highScore");

        playerName.text = "Player Name: " + PlayerPrefs.GetString("playerName");
        playerScore.text ="Player Score: " + PlayerPrefs.GetInt("playerScore");
        highscore.text ="Player Name: "+ PlayerPrefs.GetString("highScorename") + " | Score: " + PlayerPrefs.GetInt("highScore");

       if(highScore > score){
            newHighScore.text = "HIGH SCORE";
        }else{
            newHighScore.text = "NEW HIGH SCORE";
        }
    }
    public void clickRetry()
    {
        SceneManager.LoadScene("2-GameScene");
    }

    public void clickNewUser()
    {
        SceneManager.LoadScene("1-TitleScene");
    }

    public void clickResetPref()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("1-TitleScene");
    }


}
