using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Junction : MonoBehaviour
{
    TrackController _track;
    CartMovement _cart;
    public Transform[] availablePaths;
    public GameObject junctionMenu;
    public UnityEvent SelectEvent;
    public UnityEvent ContinueMovement;
    // Start is called before the first frame update
    void Start()
    {
        _track = FindObjectOfType<TrackController>();
        _cart = FindObjectOfType<CartMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            SelectEvent.Invoke();
        }
    }


    //public void AssignNextPath(TrackPoint next)
    //{
    //    _cart.SetTargetNode(next);
    //    _track.ReconfigureTrack(next);
    //    ContinueMovement.Invoke();
    //}

    
}
