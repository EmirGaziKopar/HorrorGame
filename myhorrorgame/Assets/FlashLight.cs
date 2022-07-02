using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public AudioSource onOffSound;
    public GameObject flashlight;
    int flashlightCounter;

    int sayac;

    float time;
    

    // Start is called before the first frame update
    void Start()
    {
        flashlight.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 0.1f)
        {
            time += Time.deltaTime;
        }
        else
        {
            sayac = 0;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            time = 0;
            if (sayac < 1)
            {
                onOffSound.Play();
                sayac++;
                if (flashlight.activeSelf == true)
                {      
                    Debug.Log(flashlight.activeSelf);
                    flashlight.SetActive(false);
                }
                else
                {
                    Debug.Log(flashlight.activeSelf);
                    flashlight.SetActive(true);
                }
                
            }                                                       
        }
        
        

    }
}
