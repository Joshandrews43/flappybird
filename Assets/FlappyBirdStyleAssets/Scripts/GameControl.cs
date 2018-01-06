using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public GameObject gameOverText;
	public static GameControl instance;
	public bool gameOver = false;
	public float scrollSpeed = -2f;
	public Text ScoreText;

	private int score = 0;

	// Called before Start.
	void Awake () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver && Input.GetMouseButtonDown (0))
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void BirdScored()
	{
		if (gameOver)
			return;

		score++;
		ScoreText.text = "Score: " + score.ToString ();
	}

	public void BirdDied()
	{
		gameOverText.SetActive (true); 
		gameOver = true;
	}
}
