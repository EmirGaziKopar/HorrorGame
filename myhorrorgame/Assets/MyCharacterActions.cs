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

    AllMissions allMissions; //B�t�n g�revlerin yap�l�p yapilmadigi bilgisi buraya yazilacak.

    public GameObject Mission1; //1. g�revin mission kart�


    #endregion

    #region Battery
    int sayac;
    public AudioSource chargingSound;   
    public static bool isGetBattery; //battery al�nd��� zaman 4 saniye boyunca true kalp bataryan�n dolmas�n� sa�lar
    BatteryController battery; //BattaryController nesnesi i�erisinde bataryan�n dolumunu ve bo�almas�n� kontrol eden fonksiyonlar var
    public Light fener;
    public Image fill;
    public static bool getBattery; //battery al�nd��� zaman 0.2f saniye kadar true olacak ve pil de�eri dolacak sonra false olacak tekrar pil topland���nda tekrar true olacak.
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

        battery.getBatteryForFlashLight(fill,isGetBattery); // yeni batarya al�nd���nda pilin dolmas�n� sa�layan fonksiyon            
        battery.flashLight(fill, fener); //pilin azalmas�n� saglayan ve pil biti�inde �����n s�nmesini kontrol eden fonksiyon

        //pil alma sesi i�in
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
