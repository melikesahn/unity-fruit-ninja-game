using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Cut : MonoBehaviour
{
     private Manager manager;
     
    

    void Start() {
        manager = GameObject.FindObjectOfType<Manager>();
        
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Fruit") {
            
            Destroy(other.gameObject);
            manager.score += 1;
            
        }
        else if(other.gameObject.tag == "Bomb") {
            
            manager.restartGame();
            SceneManager.LoadScene("MainMenu");
            
           
        }
    }
}
