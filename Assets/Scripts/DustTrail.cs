using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem SnowEffect;

    void OnCollisionEnter2D(Collision2D other) {
        
     
        if(other.gameObject.tag == "Suelo"){
            SnowEffect.Play();
        }

    }
    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Suelo"){
            SnowEffect.Stop();
        }
        
    }
}