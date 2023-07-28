using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GAMEMANAGER : MonoBehaviour
{
    public static GAMEMANAGER Instance;

    public bool BolaEmCena;
    public int numJogadas;
    public GameObject bolaPrefab;
    private Transform Esquerda, Direita, Baixo, Cima;
    private bool jogoEx = true, win = false, lose = false;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        SceneManager.sceneLoaded += carrega;
    }

    void carrega(Scene cena, LoadSceneMode modo)
    {
        Direita = GameObject.FindWithTag("Direita").GetComponent<Transform>();
        Esquerda = GameObject.FindWithTag("Esquerda").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Start()
    {
        BolaEmCena = true;
        numJogadas = 3;
    }

    public void Nasbolas()
    {
        Instantiate(bolaPrefab, new Vector2(Random.Range(Esquerda.position.x, Direita.position.x), Random.Range(Baixo.position.y, Cima.position.y)), Quaternion.identity);
        BolaEmCena = true;
    }
}
