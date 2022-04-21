

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class FPS : MonoBehaviour
{

    public Text showFpsText;

    private float fpsByDeltatime = 1.5f;

    private float passedTime = 8.0f;

    private int frameCount = 0;

    private float realtimeFPS = 0.0f;

    void Start()
    {

        SetFPS();
            }
    void Update()
    {

        GetFPS();
            }
    private void SetFPS()
    {

        Application.targetFrameRate = 60; }

    private void GetFPS()
    { 

        frameCount++;

        passedTime += Time.deltaTime;

        if (passedTime >= fpsByDeltatime)
        {

            realtimeFPS = frameCount/passedTime;

            showFpsText.text = "FPS :"+ realtimeFPS;


passedTime = 0.0f; frameCount = 0; } } }

