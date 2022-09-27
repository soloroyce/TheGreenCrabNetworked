using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetect : MonoBehaviour
{
    bool isEnter = false;
    bool played = false;
    int index;

    void Start()
    {
        index = GetIndex();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && isEnter)
        {
            if (played)
            {
                voArray.instance.VoiceoverEnd();
                played = false;
            }
            else
            {
                voArray.instance.VoiceoverStart(index);
                played = true;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered:"+ gameObject.name);
        voArray.instance.ShowTitle(index);
        voArray.instance.enterSFX();
        isEnter = true;
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("Left: "+ gameObject.name);
        voArray.instance.HideTitle();
        voArray.instance.VoiceoverEnd();
        isEnter = false;
        played = false;
    }

    int GetIndex() {
        string _name = gameObject.name;
        string[] splitArray =  _name.Split("_");
        return int.Parse(splitArray[0])-1;
    }
}
