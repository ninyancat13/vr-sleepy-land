using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour {

void OnCollisionEnter(Collision other)
{
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;
}
}
