using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour, IDamagable
{
    TrackController _track;
    CartMovement _cart;
    [SerializeField] Image _healthBar;
    [SerializeField] float _maxHealth = 4;
    float lostAmount = 0.25f;
    Vector3 startingPos;
    AudioSource audio;

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
        _track = FindObjectOfType<TrackController>();
        _cart = FindObjectOfType<CartMovement>();
        audio = GetComponent<AudioSource>();
        startingPos = transform.parent.transform.position;
        CurrentHealth = MaxHealth;
    }
    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
        audio.Play();
    }

 
    void Die()
    {
        Respawn();
        //Debug.Log("Dead");
    }

    private void Respawn()
    {
        transform.parent.position = startingPos;
        CurrentHealth = MaxHealth;

        _track.AssignNextTrack("20");

        _track.RespawnTrack();
        _cart.ResetTrackNode();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            TakeDamage(1);
        }
    }
}
