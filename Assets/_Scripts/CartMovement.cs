using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{
    [SerializeField] TrackController track;
    [SerializeField] float arrivalDistance = 1.1f;
    [SerializeField]Transform targetNode = null;
    [SerializeField] float moveSpeed = 2;
    [SerializeField] float dist;
    public bool moving = true;

    // Start is called before the first frame update
    void Start()
    {
        track = FindObjectOfType<TrackController>();
        targetNode = track.StartingNode();
    }

    // Update is called once per frame
    void Update()
    {
        if (moving == false) return;

        dist = Vector3.Distance(targetNode.position, transform.position);

        
        if (dist <= arrivalDistance)
        {
            targetNode = track.GetNextNode();
        }

        transform.position = Vector2.MoveTowards(transform.position, targetNode.position, moveSpeed * Time.deltaTime);

    }

    public void ToggleMovement()
    {
        moving = !moving;
    }

}
