using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (GameIsPaused)
            {
                Resume();
            
            }   else
            {
                Pause();
            }
        }
    }


        public void Resume()
        {
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;


        }
        public void Pause ()
        {
            PauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
            
        }
            
       
        public void LoadMenu (){
            Time.timeScale = 1f;
            Debug.Log("Ładuje");
            SceneManager.LoadScene("Menu");
        }
        
        public void QuitGame(){
            Debug.Log("Wychodze");
            Application.Quit();

         }
         
            

         
}
        





