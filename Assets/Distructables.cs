using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distructables : MonoBehaviour
{
    public GameObject crateDestroy;

    public void oncrateDestroyed()
    {
        Instantiate(crateDestroy, transform.position, transform.rotation);
    }

}
