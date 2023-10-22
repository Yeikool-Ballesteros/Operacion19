using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    {
        GameManager.Instance.Reset();
    }
}
