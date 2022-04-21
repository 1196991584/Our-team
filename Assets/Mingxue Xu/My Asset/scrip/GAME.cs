using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GAME : MonoBehaviour
{
	public void LoadScene(string Name)
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(Name);
	}
}