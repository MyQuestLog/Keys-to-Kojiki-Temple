using System.Collections;
using System.Collections.Generic;
using static TotemRotation;
using UnityEngine;

public class TotemCode : MonoBehaviour
{
    public float _totalFaces;

    // Update is called once per frame
    void Update()
    {
        _totalFaces = _totemCorrect;
        
    }
}
