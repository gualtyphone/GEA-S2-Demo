using UnityEngine;
using System.Collections;

public class BugsCollector : MonoBehaviour {
    public int collectedBugs = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(collectedBugs >= 1)
        {
            GameObject.Find("MovingPlatform1").GetComponent<PlatformMoving>().move = true;
        }
	}
}
