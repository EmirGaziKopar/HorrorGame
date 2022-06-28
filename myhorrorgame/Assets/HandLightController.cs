using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLightController : MonoBehaviour
{
    public Animator anim;
    int sayac;
    int sayac1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Walk", true);     
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Walk", false);
            
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("Walk", false);
            
        }


        
    }
}
