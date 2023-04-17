using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ModelChange : MonoBehaviour
{
    [SerializeField] private MeshFilter modelToChange;
    [SerializeField] private Mesh modelToUse;

    private float targetTime = 20.0f;
    private bool Timer = false;

    // Functions determining if the player is viewing the object
    public Transform originObject;
    public Transform lookingCameraTransform;
    [Range(0f, 1f)]
    public float sensitivity = 0.5f;
    Vector3 forwardVectorTowardsCamera;
    bool cameraLooking;
    float dotProductResult;

    // A public function to send to ModelChange to detect when the player is looking at the object
    private bool Looking = false;


    void Update()
    {
        targetTime -= Time.deltaTime;

        CheckIfCameraIsLooking();

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

        if (Timer == true && Looking == false)
        {

            modelToChange.mesh = modelToUse;


        }

    }

    void timerEnded()
    {

        Debug.Log("Alert ");
        Timer = true;
        //targetTime = 20.0f;
    }


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
        Debug.Log("Camera starts looking");
        Looking = true;

    }


    // Checking if the player is looking at the object
    void PlayerIsLooking()
    {


    }


    // Controlling what to do if the player is not viewing the object
    void NotLooking()
    {
        Debug.Log("Camera stops looking");
        Looking = false;
    }


    // Controlling what to do if the player is not looking
    void PlayerIsNotLooking()
    {

    }



}


