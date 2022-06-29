using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutatedsMusicSfxController : MonoBehaviour
{
    int sayac;
    int sayac1;
    public Transform Character;
    public Animator anim;
    public AudioSource ses;
    public AudioSource ses2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("devam"))
        {
            if (sayac1 < 1)
            {
                ses.Stop();
                sayac1++;
            }
            
        }
        if(Vector3.Distance(Character.position , transform.position)<9)
        {
            if (sayac < 1)
            {
                ScaredMe.isManScared = true;
                ses2.Play();
                sayac++;
                anim.SetTrigger("near");
            }
            
        }
    }
}
