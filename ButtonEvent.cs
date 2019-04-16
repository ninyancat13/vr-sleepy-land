using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour {

    public Rigidbody physicsGameObject;
    //variable called physicsGameObject to store a rigidBody object assigned in Unity Inspector
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
            //Checking for key Press event every frame (this is looking for return)
            physicsGameObject.AddForce(new Vector3(0f, 10f, 0f), ForceMode.Impulse);
            //adding force in the y-axis to the rigidbody variable
        }
	}
}
