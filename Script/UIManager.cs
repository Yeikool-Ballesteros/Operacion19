using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{// Start is called before the first frame update
    public GameObject Instrucciones;
    public GameObject Introduccion;
    public GameObject Introduccion1;
    void Start()
    {
        Instrucciones.SetActive(true);
        Introduccion.SetActive(true);
    }
    
    // Update is called once per frame
    public void cerrarCanvaIntroduccion()
    {
        Introduccion.SetActive(false);
        Destroy(Introduccion);
    }
    public void cerrarCanvaInstruccion()
    {
        Instrucciones.SetActive(false);
        Destroy(Instrucciones);
    }
    public void cerrarCanvaInstruccion1()
    {
        Introduccion1.SetActive(false);
        Destroy(Introduccion1);
    }
}
