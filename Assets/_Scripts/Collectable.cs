using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    Player Player;
    [SerializeField] int value = 1;
    public bool moving = false;
    [SerializeField] float dist;
    [SerializeField] float movingDist = 3f;
    [SerializeField] float moveSpeed = 10;

    private void Start()
    {
        Player = FindObjectOfType<Player>();
        moveSpeed = Random.Range(6, moveSpeed);
    }

    private void Update()
    {
        //TODO stop collectables during pause
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, moveSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player.gameObject)
        {
            Player.GiveCurrency(value);
            Destroy(this.gameObject);
        }
    }

    
}
