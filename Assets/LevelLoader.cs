
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
    {
    public Animator transition;
    public float transitionTime = 1f;
  
    
    
        public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

        IEnumerator LoadLevel(int LevelIndex)
    {
        //start animacji 
        transition.SetTrigger("Start");

        //poczekac az sie zaladuje
        yield return new WaitForSeconds(transitionTime);

        //LoadScene
        SceneManager.LoadScene(LevelIndex);
    }
    }
