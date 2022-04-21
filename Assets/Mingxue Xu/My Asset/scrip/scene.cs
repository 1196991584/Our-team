using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene : MonoBehaviour
{
    
    public float xvalue;
    public float yvalue;
    public float zvalue;
    public GameObject ARCamera;

    public void Moveleft()
    {
        xvalue = xvalue - 1f;
        ARCamera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Moveright()
    {
        xvalue = xvalue + 1f;
        ARCamera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Moveforward()
    {
        zvalue = zvalue + 1f;
        ARCamera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Movebackward()
    {
        zvalue = zvalue - 1f;
        ARCamera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Moveup()
    {
        yvalue = yvalue + 1f;
        ARCamera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Movedown()
    {
        yvalue = yvalue - 1f;
        ARCamera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Rotateleft() {
        ARCamera.transform.Rotate(0, 1f, 0);
    }
    public void RotateUp() {
        ARCamera.transform.Rotate(1f, 0, 0);
    }
    public void Rotateforward() {
        ARCamera.transform.Rotate(0, 0, 1f);
    }
  public void Rotatebackward() {
        ARCamera.transform.Rotate(0, 0, -1f);
    }
     public void RotateDown() {
        ARCamera.transform.Rotate(-1f, 0, 0);
    }
    public void RotatReight()
    {
        ARCamera.transform.Rotate(0, -1f, 0);
    }

    public void Resetcamera()
    {
        ARCamera.transform.position = new Vector3(-0.85f, 7.83f, 16.66f);
        ARCamera.transform.rotation = Quaternion.Euler(new Vector3(35.606f, -178.137f, 2.179f));
    }
}
