using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other) {
        collectSound.Play();
        ScoreSystem.theScore += 50;
        Destroy(gameObject);
        }
}
