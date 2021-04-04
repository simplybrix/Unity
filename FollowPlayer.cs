/* Brianna Scott
 * April 4, 2021
 * Purpose: Code for moving a camera; follows player's movement in Driving Simulator game
 Use Unity Version 2018.4
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//declare game object
public GameObject player;
//declare prvate Vector3 and offset
private Vector3 offset = new Vector3(0, 5, -7);

//FollowPlayer Class
public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        transform.position = player.transform.position + offset;
        
    }
}
