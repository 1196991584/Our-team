using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy15 : MonoBehaviour
{
	
public bool isFloating = false;
public float floatSpeed;
private float floatTimer;
private bool goingUp = true;
public float floatRate;

	void Update()
	{
        if (isFloating)
        {
            floatTimer += Time.deltaTime;
            Vector3 moveDir = new Vector3(0.0f, 0.0f, floatSpeed);
            transform.Translate(moveDir);

            if (goingUp && floatTimer >= floatRate)
            {
                goingUp = false;
                floatTimer = 0;
                floatSpeed = -floatSpeed;
            }

            else if (!goingUp && floatTimer >= floatRate)
            {
                goingUp = true;
                floatTimer = 0;
                floatSpeed = +floatSpeed;
            }
        }
    }
}
