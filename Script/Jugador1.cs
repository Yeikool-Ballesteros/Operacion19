using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jugador1 : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    Collider coll2;

    private Animator anim;

    public float x, y;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        coll2 = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == ("ADN"))
        {
            print("ARN coleccionado...");
            GameManager.Instance.IncreaseArn(1);
            //SceneManager.LoadScene("Juego");
            Destroy(collider.gameObject);


            //progress.IncrementProgress(0.1f);

        }

        if (collider.gameObject.tag == ("Portal1"))
        {
            GameManager.Instance.Nivel = 1;
            GameManager.Instance.PrimerNivel();
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == ("Portal2"))
        {
            GameManager.Instance.Nivel = 2;
            GameManager.Instance.PrimerNivel();
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == ("Portal3"))
        {
            GameManager.Instance.Nivel = 3;
            GameManager.Instance.PrimerNivel();
            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == ("Finish"))
        {
            SceneManager.LoadScene("Final");
        }

    }
}
