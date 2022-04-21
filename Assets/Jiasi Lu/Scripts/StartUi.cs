using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScen(string name) {

        SceneManager.LoadScene(name);

    }
    public void OnQuit()
    {
        Application.Quit();
    }

}
