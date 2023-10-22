using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraVida : MonoBehaviour
{
    private Slider barraVida;
    private double vida;
    private void Awake()
    {
        barraVida = GetComponent<Slider>();
    }

    public void Update()
    {
        vida = GameManager.Instance.Vida;
        barraVida.value = (float)vida;
        
    }
}
