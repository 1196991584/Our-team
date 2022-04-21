using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDHp : MonoBehaviour
{

    public Slider HpSilder;
    public bool isPlayer=false;

    public float MaxHp=100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetHp(float value) {
        HpSilder.value = value / MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer) {
            return;
        }

        this.transform.LookAt(Camera.main.transform.position);
    }
}
