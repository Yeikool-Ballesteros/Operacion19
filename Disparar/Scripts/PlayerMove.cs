using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public GameObject gameOver;

    public float speed = 10f;
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    //Collider coll2;
    //public float x, y;
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * z; 
        controller.Move(move * (speed * Time.deltaTime));
        transform.Rotate(0,  x * Time.deltaTime * rotationSpeed,0);
        double vida = GameManager.Instance.Vida;
        if (vida<=0)
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
            //SceneManager.LoadScene("Level2_1");
        }

        /*  FORMA 2 DE MOVER EL DISPARADOR
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
       
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);
        */

    }
}   
