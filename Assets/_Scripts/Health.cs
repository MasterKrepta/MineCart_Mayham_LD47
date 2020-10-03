using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IDamagable
{
    [SerializeField] Transform collectablePrefab;
    [SerializeField] int numToSpawn;

    [SerializeField] float _maxHealth;

    public float MaxHealth
    {
        get { return _maxHealth; }
        set { _maxHealth = value; }
    }


    [SerializeField] float _currentHealth;

    public float CurrentHealth
    {
        get { return _currentHealth; }
        set {
            _currentHealth = value;
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

    private void Die()
    {
        for (int i = 0; i < numToSpawn; i++)
        {
            Vector3 randPos =  transform.position * UnityEngine.Random.Range(-1, 3);
            Instantiate(collectablePrefab, randPos, Quaternion.identity);
        }

        Destroy(this.gameObject);
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
    }


}
