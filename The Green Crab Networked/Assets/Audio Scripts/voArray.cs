using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voArray : MonoBehaviour
{
    public AudioSource _as;
    
    public AudioClip[] audioClipArray;

    void Awake() {
        _as = GetComponent<AudioSource> ();
    }

    void Start()
    {

    }

    void Voiceover(int i)
    {
        _as.clip=audioClipArray[i];
        _as.PlayOneShot(_as.clip);
    }


    void Update()
    {
        
    }
}
