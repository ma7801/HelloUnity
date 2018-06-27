using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotateScript : MonoBehaviour
{
    // Controls rotation speed
    public float xspeed = 1;
    public float yspeed = 1;
    public float zspeed = 1;

    // Use this for initialization
    void Start()
    {
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xspeed, yspeed, zspeed);
  
    }
}
