using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrackController : MonoBehaviour
{
    [SerializeField] Transform[] nodes;
    int currentPosition;
    Transform closestNode;
    // Start is called before the first frame update
    void OnEnable()
    {
        nodes = GetComponentsInChildren<Transform>();
        closestNode = nodes[0];
    }

 
    public Transform GetNextNode()
    {
        currentPosition++;
        if (currentPosition >= nodes.Length)
        {
            currentPosition = 0;
        }
        return nodes[currentPosition];
    }

    public Transform StartingNode() { return nodes[0]; }
}
