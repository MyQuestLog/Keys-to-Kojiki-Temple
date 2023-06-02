using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static DoorButton;
public class DoorMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_puzzleCorrect == true)
        {
            transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
        }
    }
}
