using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{

	public int scoreValue;

	private GameController gameController;

	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");

		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent<GameController>();
		}

		if (gameControllerObject == null)
		{
			Debug.Log("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Boundary") || other.CompareTag("Enemy"))
		{
			// Ignore Boundary
			return;
		}

		if (other.CompareTag("Player"))
		{

			gameController.GameOver();
		}
		else
		{
			gameController.AddScore(scoreValue); // Only add to the score when not hitting the Player!
		}

		Destroy(other.gameObject); // Bolt or Player
		Destroy(gameObject); // Asteroid

	}

}

