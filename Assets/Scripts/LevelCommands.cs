using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCommands : MonoBehaviour
{
    [SerializeField] int level;

    audioScript audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioScript>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            audioManager.PlaySFX(audioManager.restartLevel);

            SceneManager.LoadScene(level + 1, LoadSceneMode.Single);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            audioManager.PlaySFX(audioManager.menuSelectNoise);

            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
}
