using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{


	public float startWait;
	public float waveWait;
	public TextMeshProUGUI scoreText;
	public TextMeshProUGUI restartText;
	public TextMeshProUGUI gameOverText;

	private int score;
	public bool gameOver;
	public bool restart;

	void Start()
	{
		score = 0;
		UpdateScore();

		gameOver = false;
		gameOverText.text = "";

		restart = false;
		restartText.text = "";
	}

	void Update()
	{
		if (restart)
		{
			if(Input.GetKeyDown("r"))
			{
				
				SceneManager.LoadScene("Prototype 2");
				
			}
		}
	}

	void Restart()
	{

			if (gameOver)
			{
				restart = true;
				restartText.text = "Press 'R' to Restart";
			}
		
	}

	void UpdateScore()
	{
		scoreText.text = "Score: " + score.ToString();
	}

	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore();
	}

	public void GameOver()
	{
		gameOver = true;
		gameOverText.text = "GAME OVER";
		Restart();

	}
}