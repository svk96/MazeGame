using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void onQuit()
    {
        Debug.Log("Game closed");
        Application.Quit();

    }
}
