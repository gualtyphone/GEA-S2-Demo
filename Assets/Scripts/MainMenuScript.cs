using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
