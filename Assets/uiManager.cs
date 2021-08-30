using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{

    public Text ammoText;
    public GameObject coin;

    public void updateAmmo(int count)
    {
        ammoText.text = "Ammo  " + count;

    
    }
    public  void collectedCoins()
    {
        
    }

}
