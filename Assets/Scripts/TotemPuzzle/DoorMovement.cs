using System.Collections;
using System.Collections.Generic;
using static DoorButton;
using UnityEngine;



public class DoorMovement : MonoBehaviour
{
    
    

  void Update()
    {
        if (_puzzleCorrect == true)
        {
            transform.position = new Vector3(0, 50, 0) * Time.deltaTime;
            Debug.Log("Work");
        }
        else
        {
            Debug.Log("Puzzle Not Correct");
        }
    }
}
