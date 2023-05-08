using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotemRotation : MonoBehaviour
{
    //Sets if the object can rotate or not
    private bool _canRotate;

    //Checks which face is currently at the front
    private float _currentface;

    //Is the face that should be the correct one at the front
    [SerializeField] private float _correctface;



    void Start()
    {
        _currentface = 0;
    }

    
    void Update()
    {

        //If rotate is started rotate 90 degrees
        if (_canRotate)
        {
            StartCoroutine(Rotate(Vector3.up, 90, 1.0f));
            
        }


        //On Keypress start rotation script
        if (Input.GetKeyDown("f"))
        {
            _canRotate = true;
        }

    }

    //If object is not done rotating dont let the rotate be pressed again
    IEnumerator Rotate(Vector3 axis, float angle, float duration = 1.0f)
    {
        Quaternion from = transform.rotation;

        Quaternion to = transform.rotation;

        to *= Quaternion.Euler(axis * angle);

        float elapsed = 0.0f;


        
        while(elapsed < duration && _canRotate)
        {
            transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.rotation = to;
        _canRotate = false;
    }
}



