using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrackController : MonoBehaviour
{
    [SerializeField] TrackPoint[] nodes;
    int currentPosition;
    TrackPoint closestNode;
    // Start is called before the first frame update
    void OnEnable()
    {
        nodes = GetComponentsInChildren<TrackPoint>();
        closestNode = nodes[0];
    }

 
    public TrackPoint GetNextNode()
    {
        currentPosition++;
        if (currentPosition >= nodes.Length)
        {
            currentPosition = 0;
        }
        return nodes[currentPosition];
    }

    public TrackPoint StartingNode() { return nodes[0]; }

    public void ReconfigureTrack(Transform newNode)
    {
        Debug.Log("Configure track here");
    }
}
