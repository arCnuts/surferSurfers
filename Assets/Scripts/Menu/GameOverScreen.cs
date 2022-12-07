using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public static bool GameisOver = false;
    public GameObject OverMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            
            if (GameisOver)
            {
                Restart();
            
            }   else
            {
                LoadMenu();
            }
        }
  
    }
        public void Restart()
        {
            OverMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameisOver = false;

        }
        public void LoadMenu ()
        {
            OverMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameisOver = true;
            
        }
}

