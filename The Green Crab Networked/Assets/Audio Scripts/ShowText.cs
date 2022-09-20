using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerDescription : MonoBehaviour
{   
    public GameObject descriptionHolder;
    public Text descriptionText;
    public string location;
    public string symbol;
    public string description;    
    

    // Start is called before the first frame update
    void Start()
    {
        descriptionHolder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            descriptionText.text = location + description + symbol;
            descriptionHolder.SetActive(true);
            Debug.Log("Player in sound");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            descriptionHolder.SetActive(false);
            Debug.Log("Player out of sound");
        }
    }
}

