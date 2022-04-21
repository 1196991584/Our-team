using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

/// <summary>
/// 玩家状态信息
/// </summary>
public class PlayerStatusInfo : MonoBehaviour
{
    //静态 自身类型 (对外)只读属性
    public static PlayerStatusInfo Instance { get; private set; }


    public GameObject Deathgame;

    public GameObject DeathgameOver;
    public GameObject Wingame;
    public HUDHp hp;
    public Text HPtest;

    public Text timeText;
    public float timer=300;


    public Text enemyText;
    public float enemyNum=5;
    private void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        Time.timeScale = 1;
    }

    public Gun gun;
    public GameObject pasueGame;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pasueGame.SetActive(true);
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            gun.UpdateAmmo();
        }

        if (HP <= 0) {
            Deathgame.SetActive(true);
            //  Time.timeScale = 0;
            SceneManager.LoadScene("Game1");
        }
        hp.SetHp(HP);


        if (enemyNum <= 0) {

            GetComponent<FirstPersonController>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Wingame.SetActive(true);
            Time.timeScale = 0;
        }
        if (timer <= 0)
        {
            timer = 0;

            timeText.text = "Time ：" + timer.ToString("F2");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            DeathgameOver.SetActive(true);
            Time.timeScale = 0;
            return;
        }
            timer -= Time.deltaTime;
        timeText.text ="Time ："+ timer.ToString("F2");

        enemyText.text= "Enemy ：" + enemyNum.ToString("F0");

    }
    public float HP;
    public float maxHP;

    public void loadSence()
    {
        SceneManager.LoadScene(1);
    }
        public void loadSence(string name) {

        Time.timeScale = 1;
        SceneManager.LoadScene(name);
    }

    //玩家头部位置
    public Transform headTF;

    public void Damage(float amount)
    {
        HP -= amount;
    } 

}
