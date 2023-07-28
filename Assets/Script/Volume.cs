using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    private bool on;
    [SerializeField] Image somOff;
    [SerializeField] Image somOn;

    void Start()
    {
        OnOff();
    }

    public void volume()
    {
        on = !on;
        if (on == true)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
        OnOff();
    }

    private void OnOff()
    {
        if(on == false)
        {
            somOn.enabled = false;
            somOff.enabled = true;
        }
        else
        {
            somOn.enabled = true;
            somOff.enabled = false;
            
        }
    }
}
