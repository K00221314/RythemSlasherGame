using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "start")
        {
            SceneManager.LoadScene("fruit slasher");
        }

    }
}
