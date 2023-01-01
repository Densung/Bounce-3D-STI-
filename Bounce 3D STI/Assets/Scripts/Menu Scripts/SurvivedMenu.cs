using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurvivedMenu : MonoBehaviour
{
    public static bool GameIsPaused;

    public GameObject survivedMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        survivedMenuUI.SetActive(false);
    }

    public void Pause()
    {
        survivedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();
    }
}
