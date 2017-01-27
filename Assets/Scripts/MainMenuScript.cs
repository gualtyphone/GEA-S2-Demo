using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    private float timeToIdle = 15.0f;
    private float idleTimer = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        idleTimer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            idleTimer = 0.0f;
        }

        if(idleTimer > timeToIdle)
        {
            SceneManager.LoadSceneAsync(1);
        }
	}

    public void loadMainGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void loadLevelEditor()
    {
       
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
