using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horse4 : MonoBehaviour
{
    public GameObject player;
    public GameObject symbol;
    public AudioSource sound;
    public float maxDistance;
    private float dis;

    void Start()
    {
        
    }

    void Update()
    {
        dis = Vector3.Distance(player.transform.position,symbol.transform.position);
    }
    
    void NewEvent()
    {
        if(dis < maxDistance)
        {
            sound.Play();
        }
        
    }
}
