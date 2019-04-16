using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour {

    public Light lightGameObject;
    //variable called "lightGameObject" to store a Unity Light
    //Need to have a light dragged to it in the Unity Inspector

    public float lightIntensity = 1.0f;

    public float lightIntensityIncrease = 1.0f;

    private void OnTriggerEnter(Collider other) {
        //Any collider that enters the trigger this is attached to will run this code
        //Collider on attached objects need to be set to Is Trigger being ticked
        lightGameObject.intensity = lightIntensity;
        //make the intensity of lightGameObject to be 5
    }

    private void OnTriggerExit(Collider other)
    {
        lightGameObject.intensity = 0.0f;
    }

    private void OnTriggerStay(Collider other)
    {
        lightGameObject.intensity = lightGameObject.intensity + lightIntensityIncrease;
        //If any collider is within trigger, each frame will increase intensity
    }

}
