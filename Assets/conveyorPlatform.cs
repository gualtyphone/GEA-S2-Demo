using UnityEngine;
using System.Collections;

public class conveyorPlatform : MonoBehaviour {

	public float horMov = 0;
	public float verMov = 0;

	// Use this for initialization
	void Start () {
	    
	}

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
		GameObject obj = other.gameObject;
		obj.transform.position = Vector3.Lerp(obj.transform.position, 
												new Vector3(obj.transform.position.x + horMov, 
															obj.transform.position.y + verMov, 
															obj.transform.position.z), 0.1f);
		//obj.transform.position = new Vector3(obj.transform.position.x + horMov, obj.transform.position.y + verMov, obj.transform.position.z);
    }
}
