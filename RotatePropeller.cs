/* Brianna Scott
 * April 4, 2021
 * Purpose: Code for moving the propeller in Plane Simulator game
 * Challenge 1
 Use Unity Version 2018.4
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    //
    public Vector3 rotateChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates the propeller on the plane
        transform.Rotate(rotateChange);
    }
}
