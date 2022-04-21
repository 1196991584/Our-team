using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed;//金币每秒钟旋转速度
    void Start()
    {
        //给金币一个随机旋转角度
        //Random是个随机类
        rotateSpeed = Random.Range(60, 360);
    }

    // Update is called once per frame
    void Update()
    {
        //Time类是时间控制类 ，deltaTime是每两帧之间的时间间隔
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);//绕着Y轴 
    }
    
}
