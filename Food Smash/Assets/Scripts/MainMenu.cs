﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    // called when StartButton pressed
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    // called when ExitButton pressed
    public void QuitGame()
    {
        // Debug.Log("QUIT!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Application.Quit();
    }

    public void NotQuit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Application.Quit();
    }

    public void OpenQuit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Application.Quit();
    }

    public void OpenEscape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Application.Quit();
    }

    public void YesEscape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        Application.Quit();
    }

    public void NoEscape()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        // Application.Quit();
    }

    // called when CreditButton pressed
    public void Credit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}