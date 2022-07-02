using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace XPostProcessing
{
    public class PostProcessControllerManager : MonoBehaviour
    {
        public AudioSource depremSesi;
        public PostProcessVolume test;
        public GlitchScreenShake shake;
        float timeShake;
        float timeStart;
        int sayac;
        // Start is called before the first frame update
        void Start()
        {
            timeShake = 0;
            shake = ScriptableObject.CreateInstance<GlitchScreenShake>();
                      
            test = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, shake); //Burada yap?lan de?i?iklikler post process efektimize aktar?ld?
        }

        // Update is called once per frame
        void Update()
        {
            if (timeStart < 10)
            {
                timeStart += Time.deltaTime;
            }
            else
            {
                if (sayac < 1)
                {
                    sayac++;
                    depremSesi.Play();
                }
                if (8 - timeShake > -0.1)
                {
                    timeShake += Time.deltaTime;                
                    shake.ScreenShakeIndensity.value -= Time.deltaTime / 10;
                    shake.enabled.Override(true);
                    test = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, shake);
                }
                else
                {
                    shake.enabled.Override(false);
                    test = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, shake);
                }
            }
            


        }
    }

}