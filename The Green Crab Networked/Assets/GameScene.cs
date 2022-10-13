using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
   void OnEnable()
   {
       SceneManager.LoadScene("SingaporeNetworked", LoadSceneMode.Single);
   }
}