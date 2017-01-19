using UnityEngine;
using System.Collections;

public class BugsCollector : MonoBehaviour {
    public int collectedBugs = 0;
    public GameObject door;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(collectedBugs >= 1)
        {
            door.GetComponent<PlatformMoving>().move = true;
        }
	}
}
