using UnityEngine;
using System.Collections;

public class conveyorPlatform : MonoBehaviour {

    ArrayList go = new ArrayList();

	// Use this for initialization
	void Start () {
	    
	}

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < go.Count; i++)
        {
            GameObject obj  = (GameObject) go[i];
            //obj.transform.position = 
        }
    }

    void OnCollisionEnter2D(Collider2D other)
    {
         go.Add(other.gameObject);
    }
    void OnCollisionExit2D(Collider2D other)
    {
        go.Remove(other.gameObject);
    }
}
