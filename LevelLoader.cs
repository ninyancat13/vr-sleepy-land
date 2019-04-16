using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Import Unity scene management code

public class LevelLoader : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag==("Player"))
        {
            SceneManager.LoadScene("Opening");
            //Load the scene within the quotes when this trigger has any colllider enter

        }

    }

}  //Closer LevelLoader class