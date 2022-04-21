using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemy10 : MonoBehaviour
{

	void Update()
	{
		transform.Rotate(new Vector3(0, 25, 0) * Time.deltaTime);
		
	}
}