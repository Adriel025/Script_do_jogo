using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Forca : MonoBehaviour
{
    private Rigidbody2D bola;
    private float force = 850f;
    private Rotacao rot;

    void Start()
    {
        bola = GetComponent<Rigidbody2D>();
        rot = GetComponent<Rotacao>();
    }


    void Update()
    {
        AplicaForca();
    }

    void AplicaForca()
    {
        float x = force * Mathf.Cos(rot.zRot * Mathf.Deg2Rad);
        float y = force * Mathf.Sin(rot.zRot * Mathf.Deg2Rad);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            bola.AddForce(new Vector2(x,y));
        }
    }
}
