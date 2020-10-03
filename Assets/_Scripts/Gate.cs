using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class Gate : MonoBehaviour
{
    [SerializeField] GameObject GateMenu;
    public UnityEvent SelectEvent;
    public UnityEvent CancelEvent;
    [SerializeField] int _balance;
    [SerializeField] int CostToUnlock = 25;

    public int Balance
    {
        get { return _balance; }
        set 
        { 
            _balance = value;
            GateMenu.SetActive(false);
            if (_balance >= CostToUnlock )
            {
                Unlock();
            }
        }
    }

    private void Unlock()
    {
        Debug.Log("Unlocked gate");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            SelectEvent.Invoke();
        }
    }


    // Update is called once per frame
    public void InvestInGate(int money)
    {
        _balance += money;
        CancelEvent.Invoke();
    }

   public void CancelInvest()
    {
        CancelEvent.Invoke();
    }
}
