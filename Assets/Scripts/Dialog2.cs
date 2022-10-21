using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog2 : MonoBehaviour
{
    public Text textComponent;
    public Text nameComponent;
    public string[] names;
    public string[] lines;
    public float textSpeed;
    PlayerMovement player;

    public bool loadSceneOnFinish = false;

    [SerializeField] AudioSource audio;
    [SerializeField] List<AudioClip> voiceLines;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                player.canMove = true;
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    //When dialogue starts
    void StartDialogue()
    {
        index = 0;
        textComponent.text = string.Empty;
        StartCoroutine(TypeLine());
    }

    //Typing out dialogue
    IEnumerator TypeLine()
    {
        nameComponent.text = names[index];
        // Type each character 1 by 1
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    //Next line in dialogue
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            audio.Stop();
            audio.clip = voiceLines[index];
            audio.Play();
            StartCoroutine(TypeLine());
        }
        else
        {
            if (loadSceneOnFinish == false)
            {
                gameObject.SetActive(false);
                player.canMove = true;
            } else
            {
                SceneManager.LoadScene("WellDone");
            }
        }
    }
}
