using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    public static Activador Instance = null;
    // Start is called before the first frame update
    public GameObject Instrucciones;
    public GameObject Introduccion;
    public GameObject barraInmunidad;
    public GameObject Panel;
    public GameObject panel2;

    private bool x1,x2,x3;
    void Start()
    {
        x1 = GameManager.Instance.estado1;
        x2 = GameManager.Instance.estado2;
        barraInmunidad.SetActive(!x1);
        Instrucciones.SetActive(x2);
        Introduccion.SetActive(x1);
        Panel.SetActive(false);
    }

    // Update is called once per frame
    public void cerrarCanva1()
    {
        GameManager.Instance.cambiarEstado1();
    }
    public void cerrarCanva2()
    {
        GameManager.Instance.cambiarEstado2();
    }

    public void Update()
    {
        x1 = GameManager.Instance.estado1;
        x2 = GameManager.Instance.estado2;
        Introduccion.SetActive(x1);
        barraInmunidad.SetActive(!x1);
        Instrucciones.SetActive(x2);
    }
    
    void OnTriggerEnter(Collider col){
        switch (col.gameObject.tag){
            case "Player":
                Panel.SetActive (true);
                //x3 = true;
                break;
        }
    }
    void OnTriggerExit(Collider col){
        switch (col.gameObject.tag){
            case "Player":
                Panel.SetActive (false);
                panel2.SetActive(false);
                //x3 = false;
                break;
        }
    }

    public void Panel2()
    {
        panel2.SetActive(true);
        Panel.SetActive(false);

    }
    public void Atras()
    {
        panel2.SetActive(false);
        Panel.SetActive(true);

    }
    public void pausar()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Reaunadar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Cerrar()
    {
        Application.Quit();
    }

}
