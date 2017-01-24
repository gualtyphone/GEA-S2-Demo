using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	[SerializeField] GameObject player;
	public float maxDistanceFromPlayer;
	public float speed;

	// Use this for initialization
	void Start () {
		maxDistanceFromPlayer = 10.5f;
		speed = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, player.transform.position) >= maxDistanceFromPlayer){
			Vector3 newPos = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
			transform.position = Vector3.Lerp(transform.position, newPos, speed*Time.deltaTime);
		}
	}
}
