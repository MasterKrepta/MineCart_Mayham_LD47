using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour, IDamagable
{
    [SerializeField] Image _healthBar;
    [SerializeField] float _maxHealth = 4;
    float lostAmount = 0.25f;

    public float MaxHealth
    {
        get { return _maxHealth; }
        set { _maxHealth = value; }
    }


    [SerializeField] float _currentHealth;

    public float CurrentHealth
    {
        get { return _currentHealth; }
        set
        {
            _currentHealth = value;
            lostAmount = _currentHealth / 4;
            _healthBar.fillAmount = lostAmount;
            if (_currentHealth <= 0)
            {
                Die();
            }
        }
    }

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }
    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
    }

 
    void Die()
    {
        Debug.Log("Dead");
    }
}
