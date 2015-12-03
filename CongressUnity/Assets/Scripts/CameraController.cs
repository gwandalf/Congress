using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Translate(x, y);
	}

    /// <summary>
    /// Translates the camera over the horizontal plan.
    /// </summary>
    /// <param name="x">x value</param>
    /// <param name="y">y value</param>
    void Translate(float x, float y)
    {
        this.gameObject.transform.position += new Vector3(x, 0, y);
    }
}
