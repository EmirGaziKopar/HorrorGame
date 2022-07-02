using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryController
{
    int sayac;
    float BatteryTime=8f; //pilin ka� saniye boyunca dolaca��
    /*
    public Light fener;
    public Image fill;
    public static bool getBattery; //battery al�nd��� zaman 0.2f saniye kadar true olacak ve pil de�eri dolacak sonra false olacak tekrar pil topland���nda tekrar true olacak.

    float time;
    */
    // Start is called before the first frame update
    

    public void flashLight(Image fill,Light fener)
    {
        if (fener.transform.gameObject.activeSelf)
        {
            if (fill.fillAmount >= 0.1f)
            {
                fill.fillAmount -= Time.deltaTime / 1000;
            }
            else
            {
                fener.intensity = 0; //a��kken 25 
            }
        }
        
        
    }

    public void getBatteryForFlashLight(Image fill, bool getBattery)
    {
        if (getBattery)
        {
            if (BatteryTime > 0)
            {          
                BatteryTime -= Time.deltaTime;
                Debug.Log(BatteryTime);
                fill.fillAmount += Time.deltaTime / 50;
                
            }
            else
            {
                getBattery = false;
                sayac = 0;
            }

        }
    }
}
