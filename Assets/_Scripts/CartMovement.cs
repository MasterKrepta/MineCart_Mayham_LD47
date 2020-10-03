using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{
    [SerializeField] TrackController track;
    [SerializeField] float arrivalDistance = 0.2f;
    [SerializeField]TrackPoint targetNode = null;
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
    void LateUpdate()
    {
        if (moving == false) return;

        dist = Vector3.Distance(targetNode.transform.position, transform.position);

        
        if (dist <= arrivalDistance)
        {
            targetNode = track.GetNextNode();
        }

        transform.position = Vector2.MoveTowards(transform.position, targetNode.transform.position, moveSpeed * Time.deltaTime);

    }

    public void ToggleMovement()
    {
        moving = !moving;
    }

    public void SetTargetNode(TrackPoint point)
    {
        targetNode = point;
    }

    //public void JunctionDelay()
    //{
    //    print("start");
    //    StartCoroutine(ShortDelayHack());
    //}

    //IEnumerator ShortDelayHack()
    //{
    //    arrivalDistance = -5;
    //    yield return new WaitForSeconds(.5f);
    //    arrivalDistance = 0.2f;
    //}
}
