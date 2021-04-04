/* Brianna Scott
 * April 4, 2021
 * Purpose: Code for moving a plane; follows player's movement in Plane Simulator game
 * Challenge 1
 Use Unity Version 2018.4
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //declare public float variables
    public float speed = 15.0f;
    public float rotationSpeed = 20.0f;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical and horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);

        // tilt the plane up/down based on vertical input
            transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed * verticalInput);
    }
}
