using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    public GameObject flashlight;
    int flashlightCounter;
    

    // Start is called before the first frame update
    void Start()
    {
        flashlight.SetActive(false);
        flashlightCounter = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlightCounter++;
            if (flashlightCounter % 2 == 1)
            {

                flashlight.SetActive(true);
                return;
            }

            if (flashlightCounter % 2 == 0)
            {

                flashlight.SetActive(false);
            }

            return;

        }
        

    }
}
