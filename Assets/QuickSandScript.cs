using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class QuickSandScript : MonoBehaviour
{


    void OnTriggerStay2D(Collider2D other) // when player enters 
    {
        Debug.Log("lower grav");// will first debug lower grav
        if (other.gameObject.tag == "Player")// will check if is player
        {
           
            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.5f; // then lower grav 
        }

    }
    void OnTriggerExit2D(Collider2D other) // when player leaves
    {

        Debug.Log("reset grav"); // will debug reset grav

        if (other.gameObject.tag == "Player")// will check if player
        {

            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 3.0f; // then reset grav
        }

    }


}