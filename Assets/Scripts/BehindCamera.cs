using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehindCamera : MonoBehaviour
{

    public Transform originObject;
    public Transform lookingCameraTransform;
    [Range(0f, 1f)]
    public float sensitivity = 0.2f;
    Vector3 forwardVectorTowardsCamera;
    bool cameraLooking;
    float dotProductResult;

    // A public function to send to ModelChange to detect when the player is looking at the object
    public static bool Looking = false;


    // Constantly check if the camera is looking at the object
    void Update()
    {
        CheckIfCameraIsLooking();
    }


    // The script controlling if the player is looking at the object
    public void CheckIfCameraIsLooking()
    {

        forwardVectorTowardsCamera = (lookingCameraTransform.position - originObject.position).normalized;

        dotProductResult = Vector3.Dot(lookingCameraTransform.forward, forwardVectorTowardsCamera);

        if (cameraLooking)
        {
            if (dotProductResult > sensitivity)
            {
                cameraLooking = false;
                NotLooking();

            }
        }
        else
        {
            if (dotProductResult < -sensitivity)
            {
                cameraLooking = true;
                StartLooking();
            }
        }
        if (cameraLooking)
        {
            PlayerIsLooking();
        }
        else
        {
            PlayerIsNotLooking();

        }
    }


    // When the player starts looking at the object
    void StartLooking()
    {
        Looking = true;
    }


    // Checking if the player is looking at the object
    void PlayerIsLooking()
    {


    }


    // Controlling what to do if the player is not viewing the object
    void NotLooking()
    {
        Looking = false;
    }


    // Controlling what to do if the player is not looking
    void PlayerIsNotLooking()
    {

    }



}