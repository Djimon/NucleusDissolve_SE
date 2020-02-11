using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [Header("Base Setting")]

    [SerializeField]
    private string playScene = "01_Tutorial";

    [SerializeField]
    GameObject PixelPrefab;

    [SerializeField]
    GameObject GoldenPixelPrefab;

    [Header("Debug")]

    [SerializeField]
    private bool _gameIsRunning = false;
    public bool GameIsRunning { get { return _gameIsRunning; } }

    [SerializeField]
    private float totalTime;

    private int[] Score;
    public int[] _Score { get { return Score; } }


    protected override void OnAwake()
    {
        //Basic settings
    }

    private void Start()
    {
        // if GameManager (DontDestroyOnLoad) appears in first playscene, start the game
        if (SceneManager.GetActiveScene().name.Equals(playScene))
            StartGame();
    }

    private void StartGame()
    {
        _gameIsRunning = true;
    }

    private void Update()
    {
        if (_gameIsRunning)
        {
            totalTime += Time.deltaTime;
        }
    }
}
