using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour {

    public AudioSource sFXtoPlay;

    // Update is called once per frame

    public Rigidbody physicsGameObject;
    //variable called physicsGameObject to store a rigidbody object assigned in Unity Inspector

	void Update () {
		if (Input.GetKeyDown(KeyCode.G))
        {
            sFXtoPlay.Play();
            //Play SFX when G is clicked
            physicsGameObject.AddForce(new Vector3(0f, 10f, 0f), ForceMode.Impulse);
        }
	}
}
