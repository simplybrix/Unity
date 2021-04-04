/* Brianna Scott
 * April 4, 2021
 * Purpose: Code for moving a camera; follows player's movement in Fight Simulator
 * (Challenge 1) game
 * Use Unity Version 2018.4
 */

//preprocessor directives
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//FollowPlayerX Class
public class FollowPlayerX : MonoBehaviour
{
    //Declare public and private variables plane and offset
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //
        transform.position = plane.transform.position + offset;
    }
}
