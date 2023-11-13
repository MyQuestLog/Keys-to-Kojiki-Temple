using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Button1;


public class TotemFace1 : MonoBehaviour
{

    
    

    //Sets if the object can rotate or not
    private bool _canRotate;

    //Checks which face is currently at the front
    [SerializeField] private float _currentFace;

    //Is the face that should be the correct one at the front
    [SerializeField] private float _correctFace;

    //Send out number
    [HideInInspector] public static bool _totemCorrect;

    [SerializeField] GameObject button;

    void Start()
    {
        _currentFace = 1;
        EndRotation();
    }


    void Update()
    {

        if (_canRotate)
        {
            StartCoroutine(Rotate(Vector3.up, 90, 1.0f));

        }
    }

    [SerializeField] GameObject _Camera1;
    [SerializeField] GameObject _Camera2;
    void Cam1()
    {
        _Camera1.SetActive(true);
        _Camera2.SetActive(false);
    }

    void Cam2()
    {
        _Camera1.SetActive(false);
        _Camera2.SetActive(true);
    }

    void EndRotation()
    {

        if (_currentFace > 4)
        {
            Debug.Log("Reset to starting location");
            _currentFace = 1;
        }

        if (_currentFace == _correctFace)
        {
            _totemCorrect = true;
            button.GetComponent<Button1>().SetVariable();


        }
        else if (_currentFace != _correctFace)
        {
            _totemCorrect = false;
            button.GetComponent<Button1>().SetVariable();
        }
    }

    public void StartRotation()
    {
        //Debug.Log("Start rotating object");
        Cam2();
        _canRotate = true;
        _currentFace += 1;
    }

    //If object is not done rotating dont let the rotate be pressed again
    IEnumerator Rotate(Vector3 axis, float angle, float duration = 1.0f)
    {
        

        Quaternion from = transform.rotation;

        Quaternion to = transform.rotation;

        to *= Quaternion.Euler(axis * angle);

        float elapsed = 0.0f;



        while (elapsed < duration && _canRotate)
        {
            transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        //Do EndRotation in Button1
        //button.GetComponent<Button1>().EndRotation();
        transform.rotation = to;
        _canRotate = false;
        EndRotation();
        Cam1();


        //Debug.Log("Stop rotating object");


    }
}



