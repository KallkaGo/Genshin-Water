using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : MonoBehaviour {
    public float anglePerFrame = 0.03f;
    float rot = 0.0f;

    void Update() {
		/*
        	rot += anglePerFrame;
			rot %= 360f;
        	RenderSettings.skybox.SetFloat("_Rotation", rot);
		*/
    }
}
