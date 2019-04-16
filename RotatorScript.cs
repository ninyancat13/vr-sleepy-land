using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour {

    public Vector3 rotationAngle = new Vector3(40f, 60f, 100f);
    //new variable called "rotation angle" which stores a vector 3 which is initialised to the 
    //public variables are visible in Unity Inspector
    //Inspector value overrides the value written here

	// Use this for initialization
	void Start () {
        transform.Rotate(rotationAngle);
        //transform the GameObject this is attached to
        //Rotates around the new vector 3 (x, y, z) in degrees
       
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotationAngle * Time.deltaTime, Space.Self);
        //transform the GameObjevt this is attached to
        //Rotates around the new vector x(x, y, z) in degrees
        //Using Delta Time makes the speed the same on different hardware
        //Using Unity's Time allows for time manipulation
    }
}// Closes rotator script class
