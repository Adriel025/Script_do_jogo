using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
   // [SerializeField]
   // private float vidaBola = 1f;
   // [SerializeField]
    //private Renderer bolaRender;
    //[SerializeField]
    //private bool ToqChao = false;

    //void OnCollisionEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.CompareTag("chao"))
   //     {
    //        ToqChao = true;
    //    }
   // }

    //void MataBola()
    //{
     //   if(vidaBola > 0)
     //   {
     //       vidaBola -= Time.deltaTime;
     //   }

      //  if(vidaBola <= 0)
     //   {
     //       Destroy(gameObject);
    //    }
  //  }

  //  private void Update()
  //  {
  //      if (ToqChao == true)
  //      {
    //        MataBola();
    //    }
  //  }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        switch (tag)
        {
            case "Dead":
               Gerir.instance.Fim();
                break;

            case "Obsta":
              Gerir.instance.UpRecord(10, 1);
                break;

            case "Quiqui":
                Gerir.instance.UpRecord(15, 1);
                break;

            case "Ponto":
               Gerir.instance.UpRecord(20, 1);
                break;

            case "Lado":
               Gerir.instance.UpRecord(10, 0);
                break;

           case "Flip":
                Gerir.instance.soma = 1;
                break;

            default:
                break;
        }
    }
}
