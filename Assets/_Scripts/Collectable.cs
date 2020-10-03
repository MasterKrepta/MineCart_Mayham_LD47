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
    [SerializeField] float moveSpeed = .75f;

    private void Start()
    {
        Player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, moveSpeed * Time.deltaTime);
        
        
        //if (moving)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, moveSpeed * Time.deltaTime);
        //    return;
        //};
        
        //dist = Vector3.Distance(Player.gameObject.transform.position, transform.position);

        //if (dist <= movingDist)
        //{
        //    moving = true;
        //}
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
