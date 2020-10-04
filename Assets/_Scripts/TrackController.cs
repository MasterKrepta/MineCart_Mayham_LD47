using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrackController : MonoBehaviour
{
    [SerializeField] List<TrackPoint> currentNodes;
    public List<TrackPoint> Track1, Track2, Track3, Track4, Track5, Track6, Track7, Track8, Track9, Track10,
                            Track11, Track12, Track13, Track14, Track15,Track16,Track17,Track18,Track19,Track20,
                            Track21, Track22, Track23,Track24;
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

        RespawnTrack();
        //nodes = GetComponentsInChildren<TrackPoint>();
        
    }

    public void RespawnTrack()
    {
        currentNodes = Track1;

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

    public TrackPoint StartingNode()
    {
        RespawnTrack();
        return currentNodes[0]; 
    }

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
            case "6":
                newTrack = Track6;
                break;
            case "7":
                newTrack = Track7;
                break;
            case "8":
                newTrack = Track8;
                break;
            case "9":
                newTrack = Track9;
                break;
            case "10":
                newTrack = Track10;
                break;
            case "11":
                newTrack = Track11;
                break;
            case "12":
                newTrack = Track12;
                break;
            case "13":
                newTrack = Track13;
                break;
            case "14":
                newTrack = Track14;
                break;
            case "15":
                newTrack = Track15;
                break;
            case "16":
                newTrack = Track16;
                break;
            case "17":
                newTrack = Track17;
                break;
            case "18":
                newTrack = Track18;
                break;
            case "19":
                newTrack = Track19;
                break;
            case "20":
                newTrack = Track20;
                break;
            case "21":
                newTrack = Track21;
                break;
            case "22":
                newTrack = Track22;
                break;
            case "23":
                newTrack = Track23;
                break;
            case "24":
                newTrack = Track24;
                break;
            default:
                break;
        }
        
        currentNodes = newTrack;
        currentPosition = 0;
        closestNode = currentNodes[currentPosition];
    }
}
