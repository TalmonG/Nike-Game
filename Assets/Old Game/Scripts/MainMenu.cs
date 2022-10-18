using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource sfxPlayer;

    void Start()
    {
        sfxPlayer = GetComponent<AudioSource>();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Extras");
    }

	public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
