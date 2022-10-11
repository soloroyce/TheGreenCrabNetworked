using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhooshScript : MonoBehaviour
{
    public AudioSource wooshSound;

    void Update()
        {
            if (Input.GetKey("space"))
            {
                wooshSound.enabled = true;
        
            }
            else
            {
                wooshSound.enabled = false;
            }
        }
}