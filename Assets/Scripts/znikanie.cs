using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class znikanie : MonoBehaviour{

   void OnBecameInvisible() {
         Destroy(gameObject);
     }
}