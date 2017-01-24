using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour {
    public int movingTo;
	public Vector3[] positions;
    public float speed = 1;


	// Use this for initialization
	void Start () {
		movingTo = 0;
		if (positions[0] == null){
			positions[0] = this.transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = Vector3.MoveTowards(transform.position, positions[movingTo], speed*Time.deltaTime);

		if (Vector3.Distance( transform.position, positions[movingTo]) < speed*Time.deltaTime)
		{
			movingTo++;
			if (movingTo >= positions.Length){
				movingTo = 0;
			}
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
			HealthController.Instance.killPlayer();
		}
    }
}
