using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;

    public void PausetheGame() 
    {
        pause.SetActive(true);
        Time.timeScale = 0;
    }
}

