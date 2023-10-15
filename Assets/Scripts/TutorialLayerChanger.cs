using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLayerChanger : MonoBehaviour
{
    public int CurrentObjective = 0;
    public int ObjectiveMarker = 0;

    public GameObject objectiveObject;

    void OntriggerEnter(Collider collider)
    {
        //When player enters the area if the CurrentObjective is equal to the marker change the layer.
    }
}
