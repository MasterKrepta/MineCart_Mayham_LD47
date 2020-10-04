using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] Transform gun;
    public Camera main;
    [SerializeField] Transform barrel;
    [SerializeField] Transform bulletPrefab;
    public float fireDelay = 0.25f;
    float nextFireTime = 0;
    bool shootingEnabled = true;


    // Use this for initialization
    void Start()
    {
        //main = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (shootingEnabled == false) return;
        

        Aiming();
        if (Input.GetMouseButton(0)&& CanFire())
        {
            nextFireTime = Time.time + fireDelay;
            Instantiate(bulletPrefab, barrel.transform.position, barrel.transform.rotation);
        }
    }

    private bool CanFire()
    {
        return Time.time >= nextFireTime;
    }

    private void Aiming()
    {

        Vector2 dir = main.ScreenToWorldPoint(Input.mousePosition) - gun.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        gun.rotation = rotation;
    }

    public void ToggleShooting()
    {
        shootingEnabled = !shootingEnabled;
    }
}