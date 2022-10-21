using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class znikanie : MonoBehaviour{

   void OnBecameInvisible() {
         Destroy(gameObject);
         Debug.Log("Elo1");
     }

}

    // Start is called before the first frame update
