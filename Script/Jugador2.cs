using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador2 : MonoBehaviour
{
    //LevelProgressUI progress;
    //GameObject ARNm;
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    public GameObject juego_1;
    public GameObject juego_2;
    public GameObject juego_3;
    public GameObject camara;
    Collider coll2;

    private Animator anim;

    public float x, y;
    // Start is called before the first frame update
    
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
        
        transform.Rotate(0,  x * Time.deltaTime * rotationSpeed,0);
        transform.Translate(0,0,y*Time.deltaTime * movementSpeed);
        
        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag==("llave"))
        {
            print("activar juego");
            juego_1.SetActive(true);
            camara.SetActive(false);
            
        }
        
        if(collider.gameObject.tag==("llave2"))
        {
            print("activar juego2");
            juego_2.SetActive(true);
            camara.SetActive(false);
            
        }
        if(collider.gameObject.tag==("llave3"))
        {
            print("activar juego3");
            juego_3.SetActive(true);
            camara.SetActive(false);
            
        }

    }
    void OnTriggerExit(Collider col){
        switch (col.gameObject.tag)
        {
            case "llave":
                juego_1.SetActive (false);
                camara.SetActive(true);
                break;
            
            case "llave2":
                juego_2.SetActive (false);
                camara.SetActive(true);
                break;
            case "llave3":
                juego_3.SetActive (false);
                camara.SetActive(true);
                break;
        }
    }
}
