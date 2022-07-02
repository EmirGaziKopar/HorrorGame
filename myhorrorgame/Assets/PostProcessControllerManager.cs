using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace XPostProcessing
{
    public class PostProcessControllerManager : MonoBehaviour
    {
        public PostProcessVolume test;
        public ColorAdjustmentContrastV3 color;
        float timeColor;
        // Start is called before the first frame update
        void Start()
        {
            timeColor = 0;
            color = ScriptableObject.CreateInstance<ColorAdjustmentContrastV3>();
                      
            test = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, color); //Burada yap?lan de?i?iklikler post process efektimize aktar?ld?
        }

        // Update is called once per frame
        void Update()
        {

            if (2 - timeColor > -0.1)
            {
                timeColor += Time.deltaTime;
                
                test = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, color);
            }
            else
            {
                color.enabled.Override(false);
                test = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, color);
            }


        }
    }

}