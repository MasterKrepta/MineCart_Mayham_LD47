using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] Texture2D cursor;
    [SerializeField] Transform gun;
    [SerializeField] Transform barrel;
    [SerializeField] Transform bulletPrefab;
    float fireDelay = .5f;
    float nextFireTime = 0;
    float fireOffset = .5f;


    // Use this for initialization
    void Start()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    
    }

    // Update is called once per frame
    void Update()
    {
        Aiming();
        if (Input.GetMouseButtonDown(0)&& CanFire())
        {
            nextFireTime = Time.time + fireDelay;
            Instantiate(bulletPrefab, barrel.transform.position, gun.transform.rotation);
        }
    }

    private bool CanFire()
    {
        return Time.time >= nextFireTime;
    }

    private void Aiming()
    {
        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        gun.rotation = rotation;
    }
}
