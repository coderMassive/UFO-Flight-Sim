using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool paused = false;
    public GameObject menu;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = true;
            menu.SetActive(true);
            Time.timeScale = 0f;
        }

        if (paused)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                paused = false;
                Time.timeScale = 1f;
                SceneManager.LoadScene("unalive");
            }
            if (Input.GetMouseButton(0))
            {
                paused = false;
                menu.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
}
