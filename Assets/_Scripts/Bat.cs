using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] float fireRate, range, movespeed;
    [SerializeField] Transform spitPrefab, barrel;
    
    Player _player;
    float dist;
    float nextfire;
    bool CanFire = true;
    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(_player.transform.position, transform.position);

        var dir = _player.transform.position - transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, movespeed * Time.deltaTime);


        CanFire = Canfire();
        if (dist <= range && CanFire)
        {
            nextfire = Time.time + fireRate;
            Instantiate(spitPrefab, barrel.position, barrel.rotation);
        }
    }

    bool Canfire()
    {
        return Time.time >= nextfire;
    }
}
