using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
    void OnCollisionEnter(Collision other)  
        {
             if (other.gameObject.tag == "Player")  
        {  
             SceneManager.LoadScene("GameWorld"); 
 
  // SceneManager.LoadScene(SceneManager.GetActiveScene());
   }
}
}