using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShop : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="PLayer")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                PlayerMovement player = other.GetComponent<PlayerMovement>();
                   if(player!=null)
                   {
                    //if (player.hasCoin = false)
                    //{
                    //    uiManager uimanager = GameObject.Find("UIManager").GetComponent<uiManager>();
                    //    if (uiManager != null)
                    //    {
                    //        uiManager.RemovedCoin();
                    //    }
                    //}
                    //else
                    //{
                    //    Debug.Log("Please go and collect the coin");
                    //}

                   
                   }
            }
        }
    }

}
