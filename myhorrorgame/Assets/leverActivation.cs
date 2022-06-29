using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class leverActivation : MonoBehaviour
{
    public GameObject pressE;
    public Animator anim;
    public GameObject lamba;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            lamba.gameObject.GetComponent<Animator>().enabled = true;
            Debug.Log("girdi");
            anim.enabled = true;
        }
        
    }

    private void OnMouseEnter()
    {
        pressE.SetActive(true);
    }
    private void OnMouseExit()
    {
        pressE.SetActive(false);
    }
}
