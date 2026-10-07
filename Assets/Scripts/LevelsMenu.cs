using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelsMenu : MonoBehaviour
{
    audioScript audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioScript>();
    }

    public void OnLevelButton(int level)
    {
        SceneManager.LoadScene(level + 1, LoadSceneMode.Single);
        audioManager.PlaySFX(audioManager.menuSelectNoise);
    }
    public void OnBackButton()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        audioManager.PlaySFX(audioManager.menuSelectNoise);
    }
}