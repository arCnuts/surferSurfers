using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("gra");
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }

    
 
}
