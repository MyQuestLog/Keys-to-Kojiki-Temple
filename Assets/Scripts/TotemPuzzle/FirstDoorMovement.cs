using System.Collections;
using System.Collections.Generic;
using static FirstDoorButton;
using UnityEngine;



public class FirstDoorMovement : MonoBehaviour
{



    void Update()
    {
        if (_puzzleCorrect1 == true)
        {
            transform.position = new Vector3(0, 50, 0) * Time.deltaTime;
            Debug.Log("Work");
        }
    }
}
