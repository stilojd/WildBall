using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour
{
    [SerializeField] private Material frouzenLava;
    [SerializeField] private GameObject lava;
    [SerializeField] private ParticleSystem particle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particle.Play();
            lava.GetComponent<MeshRenderer>().material = frouzenLava;
            lava.tag = "Ground";
        }
    }
}
