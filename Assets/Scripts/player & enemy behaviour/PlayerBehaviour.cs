using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private int i;
    public float forwardSpeed;
    public float moveSpeed;
    public float maxSpeed;
     
    
    void Start()
    {
        
    }

    void Update()
    {
        if(forwardSpeed < maxSpeed){
            if(forwardSpeed < maxSpeed)
            forwardSpeed += 0.1f * Time.deltaTime;
        }
            
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
            
}
                
            

