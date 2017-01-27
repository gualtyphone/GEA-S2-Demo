using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(AudioSource))]

public class DemoScreenScript : MonoBehaviour {

    public MovieTexture demoVideo;
    private AudioSource demoAudio;
    public Text promptText;
    private float flashTimer = 0.5f;
    private float resetTimer = 0.0f;
        
    // Use this for initialization
	void Start () {
        GetComponent<RawImage>().texture = demoVideo as MovieTexture;
        demoAudio = GetComponent<AudioSource>();
        demoAudio.clip = demoVideo.audioClip;
        demoVideo.Play();
        demoAudio.Play();
        promptText.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {

        resetTimer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && demoVideo.isPlaying)
        {
            SceneManager.LoadSceneAsync(0);
        }

        if (resetTimer > flashTimer)
        {
            if (promptText.enabled == true)
            {
                promptText.enabled = false;
                resetTimer = 0.0f;
            }
            else if (promptText.enabled == false)
            {
                promptText.enabled = true;
                resetTimer = 0.0f;
            }
        }
    }
}
