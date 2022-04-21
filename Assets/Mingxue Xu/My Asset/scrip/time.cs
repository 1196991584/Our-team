using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class time : MonoBehaviour
{
    public float allofTime;
    public Text timeT;



    public static time instance;


    private bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            if (allofTime > 0)
            {
                allofTime -= Time.deltaTime;
                timeT.text = "Time:" + allofTime.ToString("f0");
            }
            else
            {
                isGameOver = true;

                Time.timeScale = 0;

            }
        }

    }
}
