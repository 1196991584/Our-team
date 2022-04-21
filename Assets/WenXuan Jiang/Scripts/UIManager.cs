using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public float allTime;
    public Text timeText;
    public int score;
    public Text scoreText;


    public GameObject fire;
    public static UIManager instance;

    public GameObject winText;
    public GameObject failText;

    private bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameOver)
        {
            if (allTime > 0)
            {
                allTime -= Time.deltaTime;
                timeText.text = "Time:" + allTime.ToString("f0");
            }
            else //Ê§°Ü
            {
                isGameOver = true;

                Time.timeScale = 0;

                failText.SetActive(true);
            }


            if(score >= 25)
            {

                isGameOver = true;

                Time.timeScale = 0;

                winText.SetActive(true);
            }

        }

    }

    public void AddScore(int _score)
    {
        score += _score;
        scoreText.text = "Score:" + score.ToString();

    }


    public void DecreaseScore(int _score)
    {
        score -= _score;
        scoreText.text = "Score:" + score.ToString();

    }
}

