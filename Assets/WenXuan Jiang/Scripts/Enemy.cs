using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{

    public Transform originT;
    public Transform targetT;
    public float timer;
    public int score = 5;
    // Start is called before the first frame update
    void Start()
    {
        Move();
    }


    void Move()
    {
        transform.LookAt(targetT);
        transform.DOMove(targetT.position, timer).OnComplete(() =>
        {
            transform.LookAt(originT);
            transform.DOMove(originT.position, timer).OnComplete(() => {
                Move();
            });
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);
        if (collision.transform.name == "Sword")
        {
            GameObject.Destroy(gameObject);
 UIManager.instance.DecreaseScore(score);

        }
        else if (collision.transform.name == "geo") {
            UIManager.instance.DecreaseScore(score);
        }
    }
}
