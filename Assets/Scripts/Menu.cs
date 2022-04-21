using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button exitButton;
    public Button startButton;
    public GameObject logo;
    public GameObject player;
    public TextMeshProUGUI loseText;
    public TextMeshProUGUI restartText;
    public GameObject SpawnPoint;
    public TextMeshProUGUI Score;
    private void Awake()
    {
        logo.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
        Score.gameObject.SetActive(false);
        SpawnPoint.gameObject.SetActive(false);
        loseText.gameObject.SetActive(false);
        restartText.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    private void OnEnable()
    {
        startButton.onClick.AddListener(StartGame);
        
    }

    private void OnDisable()
    {
        startButton.onClick.RemoveListener(StartGame);
    }

    private void StartGame()
    {
        Time.timeScale = 1f;

        // Hides the button
        startButton.gameObject.SetActive(false);
        logo.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        Score.gameObject.SetActive(true);
        SpawnPoint.gameObject.SetActive(true);
        loseText.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(false);

    }
}
