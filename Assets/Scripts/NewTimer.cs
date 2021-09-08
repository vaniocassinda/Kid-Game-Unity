using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewTimer : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider timerSlider;
    public Text timerText;
    public float gameTime;

    private bool stopTimer;

    public static NewTimer intance;

    public Text ScoreText ;

    public Text ScoreText2;
    public Text HighScoreText;

    public GameObject panel;  
    private bool isGameStarted = false;
    private bool gameEnded = false;

    int score = 0;
    int highScore = 0;


    void Start()
    {
        isGameStarted = true;
        gameTime = 20f + Time.time;

        ScoreText.text = score.ToString() + " PONTOS";
        HighScoreText.text = "HIGHSCORE: " + highScore.ToString();
        panel.SetActive(false);
        stopTimer = false;
        timerSlider.maxValue = gameTime - Time.time;
        timerSlider.value = gameTime - Time.time;
    }

    public void Awake()
    {
        intance = this;
       // panel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
        float time = gameTime - Time.time;
        
      //  Debug.Log("Tempo do jogo "+time);
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        
        
        if (time <= 0)
        {
            stopTimer = true;
            //7ScoreText2.text = ScoreText.text;

            isGameStarted = false;
            gameEnded = true;
            panel.SetActive(true);
        }
        if (stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = time;

           // panel.SetActive(true);
        }
        /*if (gameEnded == true)
        {
            panel.SetActive(true);
        }
        if (isGameStarted == true)
        {
            panel.SetActive(false);
        }*/
    }

    public void AddPoint()
    {
        score += 1;
        ScoreText.text = score.ToString() + " PONTOS";
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
