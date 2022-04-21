using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject pause;

    public void ResumetheGame()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
