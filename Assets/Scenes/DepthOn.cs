using UnityEngine;

[ExecuteInEditMode]
public class DepthOn : MonoBehaviour {

    void Start ()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
	}
}