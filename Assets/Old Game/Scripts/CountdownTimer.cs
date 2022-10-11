using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 500f;
    public bool shouldCount = true;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {

        if (shouldCount)
        {
            currentTime -= Time.deltaTime;
        }

        countdownText.text = currentTime.ToString("0");

		if(currentTime <= 0)
		{
			currentTime = 0;
			SceneManager.LoadScene("GameOver");
		}
    }
    public void DialogEnter()
    {
        shouldCount = false;
    }

    public void DialogExit()
    {
        shouldCount = true;
    }
}