using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Junction : MonoBehaviour
{
    TrackController _track;
    public Transform[] availablePaths;
    public GameObject junctionMenu;
    public UnityEvent SelectEvent;
    public UnityEvent ContinueMovement;
    // Start is called before the first frame update
    void Start()
    {
        _track = FindObjectOfType<TrackController>();   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            SelectEvent.Invoke();
        }
    }


    public void AssignNextPath(Transform next)
    {
        
        _track.ReconfigureTrack(next);
        ContinueMovement.Invoke();
    }

    
}
