using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private int _currency;
    [SerializeField] TMP_Text cash;

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
    }


    public void GiveCurrency(int value)
    {
        Currency += value;
        
    }

    
}
