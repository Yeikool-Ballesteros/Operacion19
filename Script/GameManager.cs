using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public GameObject final;
    public GameObject textos;

    // Player score
    public float inmunidad = 0;
    public float score = 0;
    public double Vida = 5;
    public float arn = 0;
    public bool estado1=true;
    public bool estado2=true;
    public int Nivel;
    public int puzzle;
    public int enemigosMuertos=0;
    
    
    void Awake()
    {
        // if it doesn't exist
        if(Instance == null)
        {
            print("assigning GameManager instance");
            // Set the instance to the current object (this)
            Instance = this;
        }

        // There can only be a single instance of the game manager
        else if(Instance != this)
        {
            print("GameManager instance already exists");
            // Destroy the current object, so there is just one manager
            Destroy(gameObject);
            return;
        }

        // Don't destroy this object when loading scenes
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        estado1 = true;
        estado2 = true;
        print(estado1+" "+estado2);
        score = 0;
        Vida = 5;
        final.SetActive(false);
        textos.SetActive(true);
    }

    public void IncreaseArn(float x)
    {
        arn += x;
        print("puntaje"+arn);
        if (arn == 6)
            SceneManager.LoadScene("Level"+Nivel+"_2");
    }
    public void IncreaseScore(int amount)
    {
        // Increase the score by the given amount
        score += amount;
        if (score == 20)
        {
            score = 0;
            Vida = 5;
            SceneManager.LoadScene("Level"+Nivel+"_3");
            //inmunidad++;
        }
    }
    public void ReducirVida(double dañoX)
    {
        Vida -= dañoX;
    }
    public void Reset()
    {
        arn = 0;
        inmunidad = 0;
        score = 0;
        Vida=5;
        SceneManager.LoadScene("Level"+Nivel+"_2");
    }

    public void cambiarEstado1()
    {
        estado1 = false;
    }
    public void cambiarEstado2()
    {
        estado2 = false;
    }

    public void PrimerNivel()
    {
        SceneManager.LoadScene("Level"+Nivel+"_1");
    }

    public void aumentarPuzzle()
    {
        puzzle += 1;
        print(puzzle);
        if (puzzle==3)
        {
            SceneManager.LoadScene("Level"+Nivel+"_2");
        }
    }

    public void AumentarEnemigoMuerto()
    {
        enemigosMuertos++;
        if (enemigosMuertos == 3)
        {

            SceneManager.LoadScene("Level2_2");
            Vida = 5;
            score = 0;
        }
    }

    public void AumentarRibosomas()
    {
        score++;
        if (score==16)
        {
            inmunidad+=1;
            score = 0;
            Vida = 5;
            SceneManager.LoadScene("LugarPortales");
        }
    }

    private void Update()
    {
        int LevelActual = SceneManager.GetActiveScene().buildIndex;
        if (LevelActual == 2 && inmunidad<3)
        {
            textos.SetActive(true);
        }
        else
        {
            textos.SetActive(false);
        }
        if (inmunidad == 3)
        {
            final.SetActive(true);
            
        }
        else
        {
            final.SetActive(false);
        }
    }
}
