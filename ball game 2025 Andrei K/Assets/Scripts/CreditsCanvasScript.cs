using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsCanvasScript : MonoBehaviour
{
    public GameObject CreditsCanvas;
    public GameObject MainMenuCanvas;

    public void BackButton()
    {
        CreditsCanvas.SetActive(false);
        MainMenuCanvas.SetActive(true);
    }
}
