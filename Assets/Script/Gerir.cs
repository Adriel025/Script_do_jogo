using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Gerir : MonoBehaviour
{
    [SerializeField]
    GameObject /*bola, start,*/ quit, restart, PontoMaxTex, RecordeTex;

    int Recorde, PontoMax;

    /*[SerializeField]
    Vector2 startBoll;*/

    public int soma;

    public static Gerir instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Time.timeScale = 1;
        Recorde = 0;
        soma = 1;
        PontoMax = PlayerPrefs.HasKey("PontoMax") ? PlayerPrefs.GetInt("PontoMax") : 0;
        PontoMaxTex.GetComponent<Text>().text = "PontoMax : " + PontoMax;
    }

    public void UpRecord(int ponto, int mullIncrease)
    {
        soma += mullIncrease;
        Recorde += ponto * soma;
        RecordeTex.GetComponent<Text>().text = "Recorde : " + Recorde;
    }

    public void Fim()
    {
        Time.timeScale = 0;
        PontoMaxTex.SetActive(true);
        quit.SetActive(true);
        restart.SetActive(true);
        if (Recorde > PontoMax)
        {
            PlayerPrefs.SetInt("PontoMax", Recorde);
            PontoMax = Recorde;
        }
        PontoMaxTex.GetComponent<Text>().text = "PontoMax : " + PontoMax;
    }

    /*public void StartGame()
    {
        PontoMaxTex.SetActive(false);
        start.SetActive(false);
        RecordeTex.SetActive(true);
        Instantiate(bola, startBoll, Quaternion.identity);
    }*/
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void RestartGame()
    {
    }

}