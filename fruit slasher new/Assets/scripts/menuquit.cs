using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuquit : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "menu")
        {
            SceneManager.LoadScene("start");
        }

    }
}
