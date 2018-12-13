using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitscript : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < .3f) 
        Destroy(this.gameObject);
	}
}
