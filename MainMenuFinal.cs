using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFinal : MonoBehaviour
{
    public void PDF()
    {
        Application.OpenURL("https://drive.google.com/open?id=1cZCnJ34ZqNT0ws_ErkVd5J-Eb9sG1sr_");
    }

    public void QuitGame()
    {
        Debug.Log("Se quita");
        Application.Quit();
    }
}