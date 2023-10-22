using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigo : MonoBehaviour
{
    public float rangoDaño=0.5f;
    public float rangoAlcance=2;

    public LayerMask capaDelJugador;
    private bool haciendoDaño;
    private bool enElAlcance;

    public Transform jugador;
    public float velocidad=0.02f;
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        haciendoDaño = Physics.CheckSphere(transform.position, rangoDaño, capaDelJugador);
        enElAlcance = Physics.CheckSphere(transform.position, rangoAlcance, capaDelJugador);
        if (enElAlcance == true)
        {
            transform.LookAt(new Vector3(jugador.position.x,transform.position.y,jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(jugador.position.x, transform.position.y, jugador.position.z), velocidad);
        }

        if (haciendoDaño==true)
        {
            double vida = GameManager.Instance.Vida;
            if(vida>0)
                GameManager.Instance.ReducirVida(0.05);
            if (vida<=0)
            {
                Time.timeScale = 0f;
            }
        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,rangoDaño);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,rangoAlcance);
    }
}
