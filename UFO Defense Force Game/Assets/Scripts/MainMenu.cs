using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private int sceneToLoad;

    private AudioSource startAudio;
    public AudioClip startSound;

    private AudioSource quitAudio;
    public AudioClip quitSound;

    void Start()
    {
        startAudio = GetComponent<AudioSource>();
        quitAudio = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        startAudio.PlayOneShot(startSound,1.0f);
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame()
    {
        quitAudio.PlayOneShot(quitSound,1.0f);
        Application.Quit();
        Debug.Log("You have quit the game, goodbye!");
    }
}
