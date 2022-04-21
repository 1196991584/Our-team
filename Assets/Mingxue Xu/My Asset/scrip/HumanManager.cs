using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
public GameObject human;
 public float value;
 public float Nub;
 public Vector3 sizeChange;

 public void Moveup()
 {
     value += 0.5f;
human.transform.position = new Vector3(-1.348758f, value , 1.123088f);
 }
 public void Movedown()
 {
    value -= 0.5f;
human.transform.position = new Vector3(-1.348758f, value , 1.123088f);
 }
  public void MoveLeft()
 {
     Nub += 0.5f;
human.transform.position = new Vector3(Nub, -0.2529585f , 1.123088f);
 }
  public void MoveRinght()
 {
     Nub -= 0.5f;
human.transform.position = new Vector3(Nub, -0.2529585f , 1.123088f);
 }
 public void Rotate()
 {
     human.transform.Rotate(0f,4f,0f);
 }
 public void RotateRight()
 {
     human.transform.Rotate(0f,-4f,0f);
 }
public void Grow()
{

human.transform.localScale = human.transform.localScale + sizeChange;
}
public void Shink()
{
human.transform.localScale = human.transform.localScale - sizeChange;
}
public void ResetHuman()
{
    human.transform.position = new Vector3(-1.348758f, -0.2529585f ,1.123088f);
    human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    human.transform.localScale = new Vector3(1, 1, 1);
    value = -0.2529585f;
    Nub = -1.348758f;
}
}
