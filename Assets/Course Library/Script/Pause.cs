using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject PauseScreen;
    public bool Paused;

    // Start is called before the first frame update
    void Start()
    {
        Paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseScreen.SetActive(true);
        Paused = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseScreen.SetActive(false);
        Paused = false;
    }
    public void QuitGame()
    {
        Application.Quit();
    }    
}
