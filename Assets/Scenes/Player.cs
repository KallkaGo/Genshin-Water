using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = 0.5f; 
        if (Input.GetKey (KeyCode.A)) {
            this.transform.Translate (-step * Vector3.right);
        }
        if (Input.GetKey (KeyCode.D)) {
            this.transform.Translate (step * Vector3.right);
        }
        if (Input.GetKey (KeyCode.W)) {
            this.transform.Translate (step * Vector3.forward);
        }
        if (Input.GetKey (KeyCode.S)) {
            this.transform.Translate (-step * Vector3.forward);
        }
	}
}
