using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinnerScript : MonoBehaviour
{
    float xAngle = 0;

    float yAngle = 0;
    
    float zAngle = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
