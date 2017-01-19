using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour {
    public GameObject movingTo;
    public float speed = 0.1f;
	// Use this for initialization
	void Start () {
        movingTo = this.transform.parent.FindChild("WP1").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = Vector3.Lerp(transform.position, movingTo.transform.position, speed);

        if (Vector3.Distance( transform.position, movingTo.transform.position) < speed)
        {
            if (movingTo.name == "WP1")
            {
                movingTo = this.transform.parent.FindChild("WP2").gameObject;
            } else
            {
                movingTo = this.transform.parent.FindChild("WP1").gameObject;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
