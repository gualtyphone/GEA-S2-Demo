﻿using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
			GameObject.Destroy(this.gameObject);
			switch(this.gameObject.name){
			case "BUG":
            	GameObject.Find("Player").GetComponent<BugsCollector>().collectedBugs++;
				break;
			case "Life":
				HealthController.Instance.addLives(1);
				break;
			}
        }
    }
}
