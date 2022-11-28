using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int GameOverScreen;

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(GameOverScreen);
        }
    }
    
    
}
