using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed;//���ÿ������ת�ٶ�
    void Start()
    {
        //�����һ�������ת�Ƕ�
        //Random�Ǹ������
        rotateSpeed = Random.Range(60, 360);
    }

    // Update is called once per frame
    void Update()
    {
        //Time����ʱ������� ��deltaTime��ÿ��֮֡���ʱ����
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);//����Y�� 
    }
    
}
