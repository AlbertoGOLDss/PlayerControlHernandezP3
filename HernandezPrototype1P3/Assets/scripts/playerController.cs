using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // private variables
    private float speed = 5.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float fowardinput;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        fowardinput = Input.GetAxis("Vertical");

      
        // We move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardinput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

       
       
    }
}
