using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    private GameObject pause;
    [SerializeField]
    private Button BP;
    [SerializeField]
    private Animation AP;

    void Carrega(Scene cena, LoadSceneMode modo)
    {
        pause = GameObject.Find("Pause");
        BP = GameObject.Find("Pouse").GetComponent<Button>();
        LDPainel();

        BP.onClick.AddListener(Para);
    }

    void LDPainel()
    {
        StartCoroutine (tempo());
    }

    void Para()
    {
        AP.enabled = true;
        AP.GetComponent<Animation>().Play("Pouse");
        Time.timeScale = 0;
    }

    IEnumerator tempo() 
    {
        yield return new WaitForSeconds(0.001f);
        pause.SetActive(false);
    }
}
