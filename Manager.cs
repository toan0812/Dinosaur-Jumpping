using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    static public Manager Instance;
    [SerializeField] AudioSource buttonEffect;
    private void Awake()
    {
        Instance = this;
    }
    public void PlayGame()
    {
       buttonEffect.Play(); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        buttonEffect.Play();
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void RestartloadGame()
    {
        SceneManager.LoadScene("Menu");
    }    
}
