using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barrainmunidad : MonoBehaviour
{
    
    private Slider barraInmunidad;
    private float _inmunidad;
    private void Awake()
    {
        barraInmunidad = GetComponent<Slider>();
    }

    public void Update()
    {
        _inmunidad = GameManager.Instance.inmunidad;
        barraInmunidad.value = _inmunidad;
        
    }
}
