using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private GameObject wall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particle.Play();
            wall.SetActive(false);
        }
    }
}
