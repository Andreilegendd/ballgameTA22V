using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject CreditsCanvas;
    public GameObject MainMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        CreditsCanvas SetActive(false);
        MainMenuCanvas SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameLevel");
    }

    public void CreditsButton()
    {
        CreditsCanvas SetActive(true);
        MainMenuCanvas SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
