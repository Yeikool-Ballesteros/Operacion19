using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BarraARN : MonoBehaviour
{
    private Slider barra;
    public float arnActual;
    private void Awake()
    {
        barra = GetComponent<Slider>();
    }

    public void Update()
    {
        arnActual = GameManager.Instance.arn;
        barra.value = arnActual;
        
    }
}
