using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    [SerializeField] float delayTime = 1;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Jugador"){
            Invoke("ReloadScene", delayTime);
            
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene("PrimerNivel");
    }

}
