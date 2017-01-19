using UnityEngine;
using System.Collections;

public class followCamera : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 nPos = new Vector3(cam.gameObject.transform.position.x, cam.gameObject.transform.position.y, 10);
        this.transform.position = nPos;
    }
}
