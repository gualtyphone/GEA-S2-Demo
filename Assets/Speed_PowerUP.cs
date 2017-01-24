using UnityEngine;
using System.Collections;

public class Speed_PowerUP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        HealthController.Instance.setRespawnPosition(Vector3 newPos);
	}

    void OnTriggerEnter2D(Collider2D other)// one player enter
    {


        Debug.Log("player hit"); // will debug player hit 

        if (other.gameObject.tag == "Player")// then will check if player
        {
            Debug.Log("player powered up");// will debug player powered up 

            playerScript.m_MaxSpeed

        }

    }
}
