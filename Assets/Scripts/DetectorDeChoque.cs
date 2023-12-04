using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectorDeChoque : MonoBehaviour
{
    [SerializeField] float delayTime = 1;
    [SerializeField] ParticleSystem CrashEffect;
    [SerializeField] AudioClip CrashSFX;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Suelo"){
            CrashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(CrashSFX);
            Invoke("ReloadScene", delayTime);
        }
    }
    void ReloadScene(){
        SceneManager.LoadScene("PrimerNivel");
    }
}
