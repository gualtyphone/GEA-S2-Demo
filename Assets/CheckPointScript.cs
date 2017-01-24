using UnityEngine;
using System.Collections;

public class CheckPointScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void onTriggerEnter() {

        HealthController.Instance.setRespawnPosition(transform.position);

    }


}
