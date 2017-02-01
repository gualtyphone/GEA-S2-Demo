using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            col.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if(Input.GetKey(KeyCode.W))
            {
                col.transform.Translate(new Vector3(0.0f, 0.1f, 0.0f));
            }
            else if(Input.GetKey(KeyCode.S))
            {
                col.transform.Translate(new Vector3(0.0f, -0.1f, 0.0f));
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            col.GetComponent<Rigidbody2D>().gravityScale = 3;
        }
    }
}
