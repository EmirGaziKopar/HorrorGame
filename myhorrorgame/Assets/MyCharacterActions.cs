using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCharacterActions : MonoBehaviour
{
    #region PostProccessActions

    public GameObject volume;

    //ShakeEffectByKopar shake;

    #endregion



    #region Missions

    AllMissions allMissions; //Bütün görevlerin yapýlýp yapilmadigi bilgisi buraya yazilacak.

    public GameObject Mission1; //1. görevin mission kartý


    #endregion

    #region Battery
    int sayac;
    public AudioSource chargingSound;   
    public static bool isGetBattery; //battery alýndýðý zaman 4 saniye boyunca true kalp bataryanýn dolmasýný saðlar
    BatteryController battery; //BattaryController nesnesi içerisinde bataryanýn dolumunu ve boþalmasýný kontrol eden fonksiyonlar var
    public Light fener;
    public Image fill;
    public static bool getBattery; //battery alýndýðý zaman 0.2f saniye kadar true olacak ve pil deðeri dolacak sonra false olacak tekrar pil toplandýðýnda tekrar true olacak.
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        battery = new BatteryController();
        allMissions = new AllMissions();
        //shake = new ShakeEffectByKopar();
    }

    // Update is called once per frame
    void Update()
    {


        MissionController();

        battery.getBatteryForFlashLight(fill,isGetBattery); // yeni batarya alýndýðýnda pilin dolmasýný saðlayan fonksiyon            
        battery.flashLight(fill, fener); //pilin azalmasýný saglayan ve pil bitiþinde ýþýðýn sönmesini kontrol eden fonksiyon

        //pil alma sesi için
        if (isGetBattery)
        {
            //shake.ShakeIt(volume.GetComponent<XPostProcessing.GlitchScreenShake>());
            if (sayac < 1)
            {
                sayac++;
                chargingSound.Play();
            }
        }
        else
        {
            sayac = 0;
        }
    }



    public void MissionController()
    {
        if (AllMissions.missions1)
        {
            Mission1.SetActive(false);
        }
    }
}
