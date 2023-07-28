using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class R : MonoBehaviour
{
    private TextMeshProUGUI recorde;

    void Awake()

    {
        recorde = GameObject.FindWithTag("recorede").GetComponent<TextMeshProUGUI>();
    }
}
