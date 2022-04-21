using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Food : MonoBehaviour
{
    public int score = 5;
    public Transform originT;
    public Transform targetT;
    public float timer;
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

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            UIManager.instance.AddScore(score);
            GameObject.Destroy(gameObject);
       

        }
        

    }
    
}