using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Experimental.Rendering.Universal;

public class Player : MonoBehaviour
{
    private int _currency;
    [SerializeField] TMP_Text cash;
    AudioSource cashAudio;

    public int Currency
    {
        get { return _currency; }
        set 
        { 
            _currency = value;
            cash.text = Currency.ToString();
            
        }
    }

    private void OnEnable()
    {
        Currency = 0;
        cashAudio = cash.GetComponent<AudioSource>();
    }


    public void GiveCurrency(int value)
    {
        Currency += value;
        cashAudio.Play();


    }

    
}
