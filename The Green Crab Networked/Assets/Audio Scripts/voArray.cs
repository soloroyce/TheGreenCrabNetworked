using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using DG.Tweening;


public class voArray : MonoBehaviour
{
    public static voArray instance;
    public AudioSource _as;
    public Text _title;
    public Text _script;
    public Image _scriptBackground;

    public AudioClip[] audioClipArray;
    public string[] textArray;
    public string[] titleArray;

    public AudioMixerSnapshot normal;
    public AudioMixerSnapshot zoomin;

    void Awake() {
        instance = this;
        _as = GetComponent<AudioSource> ();
    }

    void Start()
    {
        // StartCoroutine(waiter());
    }

    public void VoiceoverStart(int i)
    {
        //delay one second
        DOTween.KillAll();
        _as.DOFade(1,0.05f);
        zoomin.TransitionTo(0.5f);
        _as.clip=audioClipArray[i];
        _as.PlayOneShot(_as.clip);
        _script.text = textArray[i];
        _script.DOFade(1, 1.0f);
        _scriptBackground.DOFade(0.3f, 1.0f);
        //zoom in
    }
    public void VoiceoverEnd()
    {
        _as.DOFade(0,0.1f);
        _as.Stop();
        _script.DOFade(0, 1.0f);
        _scriptBackground.DOFade(0.0f, 1.0f);
        normal.TransitionTo(1.0f);
        //zoom out
    }

    public void ShowTitle(int i) {
        _title.text = titleArray[i];
        // _title.text = "TIL";
        _title.DOFade(1, 1.0f);
    }

    public void HideTitle() {
        _title.DOFade(0, 1.0f);
    }

    void Update()
    {
        
    }
}
