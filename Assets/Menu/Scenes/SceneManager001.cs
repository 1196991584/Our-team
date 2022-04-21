using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackEvent()
    {
        SceneManager.LoadScene(0);
    }

    public void Level1()
    {
        SceneManager.LoadScene("Menu1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Game2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Menu3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Menu4");
    }
    public void OnQuit()
    {
        Application.Quit();
    }
}
