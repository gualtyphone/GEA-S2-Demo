using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour {

	public int lives;
	public Text livesText;
	private bool invincible;

	public GameObject startPoint;

	public GameObject deathScreen;

	static HealthController _instance;
	public static HealthController Instance
	{
		get
		{
			if (_instance == null)
				_instance = GameObject.FindObjectOfType<HealthController> ();
			return _instance;
		}
	}

	// Use this for initialization
	void Start () {
		lives = 3;
		livesText = GameObject.Find("Lives Text").GetComponent<Text>();
		invincible = false;
		startPoint = GameObject.Find("PlayerStartingPoint");
		deathScreen = GameObject.Find("DeathScreen");
		deathScreen.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		livesText.text = "Lives: " + lives.ToString();
	}

	public void killPlayer()
	{
		if (!invincible){
			//Add death animation
			StartCoroutine("DeathAnim");
			lives--;
			transform.position = startPoint.transform.position;
			if (lives <= 0){
				SceneManager.LoadSceneAsync(0);
			}
			StartCoroutine("Invincible");
		}
	}

	public void addLives(int livesToAdd){
		lives += livesToAdd;
	}

	IEnumerator DeathAnim() {
		deathScreen.SetActive(true);
		//Time.timeScale = 0.0f;
		GetComponent<PlatformerCharacter2D>().enabled = false;
		yield return new WaitForSeconds(1.0f);
		deathScreen.SetActive(false);
		GetComponent<PlatformerCharacter2D>().enabled = true;
		//Time.timeScale = 1.0f;

	}

	IEnumerator Invincible() {
		invincible = true;
		yield return new WaitForSeconds(0.1f);
		invincible = false;
		yield return false;
	}

	void setRespawnPosition(Vector3 _position){
		startPoint.transform.position = _position;
	}
}
