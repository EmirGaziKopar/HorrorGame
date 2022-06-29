using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaredMe : MonoBehaviour
{
    public AudioSource ManScared;
    public static bool isManScared;
    float time;
    int sayac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This will run When man is afraid
        if (isManScared == true)
        {
            if (sayac < 1)
            {
                sayac++;
                ManScared.Play();
            }
            
            if (time < 8)
            {
                time += Time.deltaTime;
            }
            else
            {
                ManScared.Stop();
                isManScared = false;
                sayac = 0;
            }
            
        }
    }
}
