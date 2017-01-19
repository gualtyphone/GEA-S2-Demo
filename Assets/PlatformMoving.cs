using UnityEngine;
using System.Collections;

public class PlatformMoving : MonoBehaviour {
    public bool move = false;
    public GameObject wayPoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (move)
        {
            transform.position = Vector3.Lerp(transform.position, wayPoint.transform.position, 0.1f);
        }
	}
}
