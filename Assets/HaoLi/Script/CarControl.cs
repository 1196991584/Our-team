using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarControl : MonoBehaviour {
    private MeshRenderer[] wheelMesh;
    private WheelCollider[] wheel;
    private float maxAngle;
    private float maxToque;
    private float h, v;
    public Text score;
    public int x = 0;
    public GameObject win;

    void Start() { 
    maxAngle = 30;
    maxToque = 200;
    wheelMesh = transform.GetChild(0).GetComponentsInChildren<MeshRenderer>();
    wheel = transform.GetChild(2).GetComponentsInChildren<WheelCollider>();
    }
    void Update() { 

     h = Input.GetAxis("Horizontal");
     v = Input.GetAxis("Vertical");
        if (0 == Mathf.Abs(h) && 0 == Mathf.Abs(v)) return;
        Move();
    }

    private void Move()
    {
        for (int i = 0; i < 2; i++)
        {
            wheel[i+2].steerAngle = h * maxAngle;
        }

        foreach (var o in wheel)
        {
            o.motorTorque = maxToque * 2 * v;
        }

        for (int i = 0; i < 4; i++)
        {
            wheelMesh[i].transform.localRotation = Quaternion.Euler(wheel[i].rpm * 360 / 60, wheel[i].steerAngle, 0);
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Coin")
        {
            
            Destroy(collision.collider.gameObject);
            x++;
            score.text = x.ToString();
            if (x == 3)
            {
                gameObject.SetActive(true);
            }

        }
    }

    

}