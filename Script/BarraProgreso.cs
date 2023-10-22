using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarraProgreso : MonoBehaviour
{
    private Slider barra;
    public float valorAct;

    private void Awake()
    {
        barra = GetComponent<Slider>();
    }

    public void Update()
    {
        valorAct = GameManager.Instance.score;
        barra.value = valorAct;
    }
}
