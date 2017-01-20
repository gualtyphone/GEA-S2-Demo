using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class Trampoline : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.tag == "Player"){
			other.gameObject.GetComponent<PlatformerCharacter2D>().m_jump = true;
		}
	}
}