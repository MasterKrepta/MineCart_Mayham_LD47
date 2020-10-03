using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrackController : MonoBehaviour
{
    [SerializeField] List<TrackPoint> currentNodes;
    public List<TrackPoint> Track1, Track2, Track3, Track4, Track5;
    public int currentPosition;
    TrackPoint closestNode;
    // Start is called before the first frame update
    void OnEnable()
    {
        //TODO remove auto assign so we can unlock different paths. 
        //foreach (TrackPoint c in this.GetComponentsInChildren<TrackPoint>())
        //{
        //    currentNodes.Add(c);
        //}

        currentNodes = Track1;
        //nodes = GetComponentsInChildren<TrackPoint>();
        closestNode = currentNodes[0];
    }

 
    public TrackPoint GetNextNode()
    {
        currentPosition++;
        if (currentPosition >= currentNodes.Count)
        {
            currentPosition = 0;
        }
        return currentNodes[currentPosition];
    }

    public TrackPoint StartingNode() { return currentNodes[0]; }

    //public void ReconfigureTrack(TrackPoint newNode)
    //{
    //    Debug.Log("Configure track here");
    //}

    public void AssignNextTrack(string trackName)
    {
        List<TrackPoint> newTrack = new List<TrackPoint>();
        switch (trackName)
        {
            case "1":
                newTrack = Track1;
                break;
            case "2":
                newTrack = Track2;
                break;
            case "3":
                newTrack = Track3;
                break;
            case "4":
                newTrack = Track4;
                break;
            case "5":
                newTrack = Track5;
                break;
            default:
                break;
        }
        
        currentNodes = newTrack;
        currentPosition = 0;
        closestNode = currentNodes[currentPosition];
    }
}
