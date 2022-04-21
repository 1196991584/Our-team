using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonPause : MonoBehaviour{
  //the ButtonPauseMenu
    public GameObject ingameMenu;

  void Start(){
ingameMenu.SetActive(false);

 }
    public void OnPause(){
        Time.timeScale = 0;
        ingameMenu.SetActive(true);
    }
    public void OnResume(){
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
    }
    public void OnRestart(string sceneName){
       SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }
   
    public void LoadScene(string sceneName){
SceneManager.LoadScene(sceneName);
}


}
