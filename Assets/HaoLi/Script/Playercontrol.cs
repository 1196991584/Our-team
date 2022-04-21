using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Playercontrol : MonoBehaviour
{
    public WheelCollider[] wheelColliders;
    public Transform[] WheelTrans;
    Rigidbody rb;
    float h;
    float v;
    float speed;
    float time;
    public int x = 0;
    public GameObject pa;
    public Text score;
    public AudioSource coinAudio;

    void Start()
    {
        coinAudio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        speed = wheelColliders[0].rpm;
        time = 1;
    }
    void Update()
    {
        
        time -= Time.deltaTime;
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        Move();
        Turn();
        Tb();
        Brake();
        Unbrake();
        speed = wheelColliders[0].rpm;
    }
    void Move()
    {
        wheelColliders[0].motorTorque = v * 2000;
        wheelColliders[1].motorTorque = v * 2000;
        wheelColliders[2].motorTorque = v * 2000;
        wheelColliders[3].motorTorque = v * 2000;
    }//�ƶ�
    void Turn()//ת��
    {
        wheelColliders[0].steerAngle = h * 50;
        wheelColliders[1].steerAngle = h * 50;
    }
    void Tb()//ͬ������
    {
        for (int i = 0; i < wheelColliders.Length; i++)
        {            //��ȡ������ײ����λ�ú���ת            
            Vector3 pos;
            Quaternion rotation;
            wheelColliders[i].GetWorldPose(out pos, out rotation);
            WheelTrans[i].position = pos;
            WheelTrans[i].rotation = rotation;
        }
    }
    void Brake()//ɲ��
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (speed != 0)
            {
                wheelColliders[0].brakeTorque = 50000000;
                wheelColliders[1].brakeTorque = 50000000;
                wheelColliders[2].brakeTorque = 50000000;
                wheelColliders[3].brakeTorque = 50000000;
                time = 1.5f;
            }
        }
    }
    void Unbrake()//ֹͣɲ��
    {
        Debug.Log(speed);
        if (speed == 0 && time <= 0)
        {
            for (int i = 0; i < wheelColliders.Length; i++)
            {
                wheelColliders[i].brakeTorque = 0;
            }
        }
    }

    


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin")
        {
            Destroy(collision.collider.gameObject);
            x++;
            score.text = x.ToString();
            if (x == 7)
            {
                pa.SetActive(true);
                Time.timeScale = 0;
            }
            if (coinAudio)
            {
                coinAudio.Play();
            }
            else
            {
                Debug.Log("NO coinAudio found");
            }
            

        }
    }

}
