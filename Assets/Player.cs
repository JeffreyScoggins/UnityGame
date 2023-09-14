using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
     public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,0,-speed * Time.deltaTime);
        }    

        //if(Input.GetKey(KeyCode.UpArrow))
       // {
        //    transform.Rotate(-speed * Time.deltaTime * 40,0,0);
       // }
      //  if(Input.GetKey(KeyCode.DownArrow))
    //    {
  //          transform.Rotate(speed * Time.deltaTime * 40,0,0);
//        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0,-speed * Time.deltaTime * 40,0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0,speed * Time.deltaTime * 40,0);
        }   
        
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Walls")
        {
            if(Input.GetKey(KeyCode.A))
            {
                transform.Translate(speed * Time.deltaTime * 2.5f,0,0);
            }
            if(Input.GetKey(KeyCode.D))
            {
                transform.Translate(-speed * Time.deltaTime * 2.5f,0,0);
            }
            if(Input.GetKey(KeyCode.W))
            {
                transform.Translate(0,0,-speed * Time.deltaTime * 2.5f);
            }
            if(Input.GetKey(KeyCode.S))
            {
                transform.Translate(0,0,speed * Time.deltaTime * 2.5f);
            }

        
            Debug.Log("Wall Hit");
        }

    }
}
