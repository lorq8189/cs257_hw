using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.InputSystem;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenu;
    public Button resumeButton;
    void Awake()
    {
        pauseMenu.SetActive(false);
        resumeButton.onClick.AddListener(OnResumePressed);
    }

    void OnResumePressed()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnDestroy()
    {
        Time.timeScale = 1;
    }
}
