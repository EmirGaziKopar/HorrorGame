using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryCollection : MonoBehaviour
{
    public GameObject E_bas;

    private void OnMouseEnter()
    {
        E_bas.SetActive(true);
    }
    private void OnMouseExit()
    {
        E_bas.SetActive(false);
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            MyCharacterActions.isGetBattery = true;
            E_bas.SetActive(false);
            Destroy(this.gameObject);
            AllMissions.missions1 = true; // 1.gorev tamamlandý.
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    } 
}
