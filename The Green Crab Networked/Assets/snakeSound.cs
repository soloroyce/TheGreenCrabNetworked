using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeSound : MonoBehaviour
{
    public GameObject player;
    public GameObject symbol;
    public AudioSource sound1;
    public AudioSource sound2;
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
            sound1.Play();
        }
        
    }

        void NewEvent2()
    {
        if(dis < maxDistance)
        {
            sound2.Play();
        }
        
    }
}
