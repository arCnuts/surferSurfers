using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private int i;
    public float forwardSpeed;
    public float moveSpeed;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);  

        if(Input.GetKeyDown(KeyCode.A) && i == 0 | i == 1)
        {
            --i;
            transform.Translate(Vector3.left * moveSpeed);
        }    
        
        if(Input.GetKeyDown(KeyCode.D) && i == 0 | i == -1)
        {
            ++i;
            transform.Translate(Vector3.right * moveSpeed);
        }

            
        }
              
    

    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "obstacle")
        {
            gameObject.transform.position = Vector3.zero;
            i =+ 0;
        }
    }


 
     
     

}
