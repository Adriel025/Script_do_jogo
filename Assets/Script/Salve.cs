using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salve : MonoBehaviour
{
    public Text txt;
    public InputField caixaTxt;
    private float testo;
    private string testos;
    void Start()
    {
        txt.text = PlayerPrefs.GetString("Nome");
    }

    
    public void Salva()
    {
        testos = caixaTxt.text;
        PlayerPrefs.SetString("Nome", testos);
    }
}
