using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeChoque : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Suelo"){
            Debug.Log("Me cai");
        }
    }
}
