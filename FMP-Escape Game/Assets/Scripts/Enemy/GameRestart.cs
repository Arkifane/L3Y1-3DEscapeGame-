using UnityEngine;
using UnityEngine.SceneManagement;
 
public class GameRestart : MonoBehaviour
{
     void OnTriggerEnter(Collider coll)
     {
          // Check if the object colliding has the "Player" tag
          if (coll.gameObject.CompareTag("Player"))
          {

               //Debug.Log("hit player");
               // Reload the current scene
               SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          }
     }
}