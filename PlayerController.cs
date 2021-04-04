/* Brianna Scott
 * April 4, 2021
 * Purpose: Code for moving a vehicle; gives player control to move the vehicle for Driving Simulator game
 * Use Unity Version 2018.4
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//declare private float variables speed, turnSpeed, horizontalInput, and forwardInput
private float speed = 20.0f;
private float turnSpeed = 45.0f;
private float horizontalInput;
private float forwardInput;

//PlayerController Class
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Initialize horizontalInput and forwardInput
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates thee car based on horizontal input
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
