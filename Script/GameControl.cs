using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject botonPausa;
    public GameObject menuPausa;

    private void Start()
    {
        Time.timeScale = 0f;
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

    public void ReiniciarLevel2()
    {
        Time.timeScale = 1f;
        GameManager.Instance.arn = 0;
        GameManager.Instance.inmunidad = 0;
        GameManager.Instance.score = 0;
        GameManager.Instance.Vida=5;
        SceneManager.LoadScene("Level"+GameManager.Instance.Nivel+"_2");
    }
    public void ReiniciarLevel1()
    {
        SceneManager.LoadScene("Level"+GameManager.Instance.Nivel+"_1");
        //Time.timeScale = 1f;
        GameManager.Instance.arn = 0;
        //GameManager.Instance.inmunidad = 0;
        //GameManager.Instance.score = 0;
        GameManager.Instance.Vida=5;
        GameManager.Instance.enemigosMuertos = 0;
        GameManager.Instance.puzzle = 0;

    }

    public void ReiniciarLevel3()
    {
        SceneManager.LoadScene("Level"+GameManager.Instance.Nivel+"_3");
    }
    

    public void Cerrar()
    {
        Application.Quit();
    }
}
