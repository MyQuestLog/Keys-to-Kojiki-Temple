using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DoorButton;


public class DoorMovement : MonoBehaviour
{
    
    

  void update()
    {
        if (_puzzleCorrect == true)
            {
            transform.position = new Vector3(200, 200, 200) * Time.deltaTime;
            Debug.Log("Work");
        }
    }

}
