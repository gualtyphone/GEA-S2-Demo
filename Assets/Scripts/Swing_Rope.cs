using UnityEngine;
using System.Collections;

public class Swing_Rope : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player" && col.transform.parent == null) col.transform.parent = this.transform;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Player" && col.transform.parent != null) col.transform.parent = null;
    }
}
