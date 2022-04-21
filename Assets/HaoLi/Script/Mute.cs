using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Mute : MonoBehaviour
{
    public AudioSource baudio;

    void Start()
    {
        baudio = GetComponent<AudioSource>();
    }

    public void Stop()
    {
        if (baudio)
        {
            if (baudio.mute)
            { baudio.mute = false; }
            else
            { baudio.mute = true; }

        }
    
        else
        {
            Debug.Log("NO baudio found");
        }
        

    }
}