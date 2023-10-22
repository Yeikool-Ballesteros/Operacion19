using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{

public void StarGame()
{

    SceneManager.LoadScene("LugarPortales");
}

/*public void Seguir()
{
    SceneManager.LoadScene("Level1");
}*/

public void Omitir()
{
    SceneManager.LoadScene("Menu_game");
}
   
}
