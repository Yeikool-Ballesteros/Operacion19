using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private bool izquierda, derecha,izquierda2, derecha2;
    public float movementSpeed = 8.0f;
    Collider coll;
    public GameObject gameOver;
    private int i=1;
    public double vida;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();

    }

    // Update is called once per frame
    void Update()
    {
        izquierda = Input.GetKeyDown(KeyCode.LeftArrow);
        izquierda2= Input.GetKeyDown(KeyCode.A);

        derecha = Input.GetKeyDown(KeyCode.RightArrow);
        derecha2 = Input.GetKeyDown(KeyCode.D);

        if (izquierda || izquierda2)
        {
            if (i == 1 || i == 2)
            {
                transform.Translate(0, 0, 2f);
                i--;
            }
                
        }

        if (derecha || derecha2)
        {
            if (i == 1 || i == 0)
            {
                transform.Translate(0,0,-2f);
                i++;
            }
                
        }
        transform.Translate(Time.deltaTime * movementSpeed,0,0);
        vida = GameManager.Instance.Vida;
        if (vida<=0)
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (vida > 0)
        {
            if (collider.gameObject.tag == "Objetivo")
            {
                GameManager.Instance.IncreaseScore(1);
                Destroy(collider.gameObject);
            }
            else if (collider.gameObject.tag == "Obstacle")
            {
                GameManager.Instance.ReducirVida(1);
                Destroy(collider.gameObject);
            
            }
        }
        
    }
}