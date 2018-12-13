using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "quit")
        {
            Application.Quit();
        }

    }
}
