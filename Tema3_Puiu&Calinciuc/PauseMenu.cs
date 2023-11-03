using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

using System.Runtime.InteropServices;
//using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Stats stats;
    private bool IsPaused => Input.GetKeyDown(pauseKey);

    //public GameObject resumeButton;
    //public GameObject exitButton;

    public static bool GameIsPaused = false;

    public UnityEvent onInteract;

    public GameObject pauseMenuUI;

    [SerializeField] private KeyCode pauseKey;

    public float cursorSpeed;
    float deltaValue;

    void Start()
    {
        GameIsPaused = false;
    }

    void Update()
    {
        if (IsPaused) // && GameInInventory == false
        {
            if (GameIsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void PressOnResumeButton()
    {
        GameIsPaused = false;
    }
    public void ResumeGame()
    {
        Resume();
        LockCursor();
    }

    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        LockCursor();
        GameIsPaused = false;
        Time.timeScale = 1;
        onInteract.Invoke();
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        UnlockCursor();
        GameIsPaused = true;
        Time.timeScale = 0;
        onInteract.Invoke();
    }

    public void Resume_Button()
    {
        pauseMenuUI.SetActive(false);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void TimeResume()
    {
        Time.timeScale = 1;
    }

    public void TimePause()
    {
        Time.timeScale = 0;
    }

}