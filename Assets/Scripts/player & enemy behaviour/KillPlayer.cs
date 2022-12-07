using System.Threading;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int GameOverScreen;
    public float delay = 1f;

    
     
  void OnTriggerEnter(Collider other)
        {
            FindObjectOfType<AudioManager>().Play("boatcrash");
            PlayerManager.gameOver = true;
        }
}