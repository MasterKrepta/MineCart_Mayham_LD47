using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;
using UnityEngine.UI;

public class Gate : MonoBehaviour
{
    [SerializeField] GameObject GateMenu;
    [SerializeField] TMP_Text txtBalance, txtCost;
    [SerializeField] Button investBtn;
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
            UpdateUI();
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
            UpdateUI();
            SelectEvent.Invoke();
        }
    }


    // Update is called once per frame
    public void InvestInGate(Player player)
    {
        
        _balance += player.Currency;
        player.Currency = 0;
        CancelEvent.Invoke();
    }

   public void CancelInvest()
    {
        CancelEvent.Invoke();
    }

    void UpdateUI()
    {
        txtBalance.text = $"Balance: ${_balance}";
        txtCost.text = $"Cost Remaining: ${CostToUnlock - _balance}";
        investBtn.interactable = IsEnabled(FindObjectOfType<Player>().Currency);
    }

    bool IsEnabled(int currency)
    {
        return currency > 0; 
    }
    
}
