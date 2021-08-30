using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
            if(Input.GetKeyDown(KeyCode.C))
            {
                PlayerMovement player = other.GetComponent<PlayerMovement>();
                if(player!=null)
                {
                    // player.hasCoin = true;
                    Destroy(this.gameObject);
                    uiManager uimanager = GameObject.Find("UIManager").GetComponent<uiManager>();
                    Debug.Log("Coin picked up");
                }
            }
        }
    }
}
