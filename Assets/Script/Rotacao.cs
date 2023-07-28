using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rotacao : MonoBehaviour
{
    [SerializeField]
    private Transform posStart;

    [SerializeField]
    private Image SetaImg;

    public float zRot = 90f;

    private void Start()
    {
       PosSet();
       PosBola();
    }

    void Update()
    {
        RotacaoSeta();
        input();
    }


    void PosSet()
    {
        SetaImg.rectTransform.position = posStart.position;
    }

    void PosBola()
    {
        this.gameObject.transform.position = posStart.position;
    }

    void RotacaoSeta()
    {
        SetaImg.rectTransform.eulerAngles = new Vector3(0, 0, zRot);
    }

    void input()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            zRot += 2.5f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            zRot -= 2.5f;
        }
    }
}
