using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamera : MonoBehaviour
{
    public float movementSpeed = 8.0f;
  

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,Time.deltaTime * movementSpeed);
        
    }
}