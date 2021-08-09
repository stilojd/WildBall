using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleRedButton;
    [SerializeField] private GameObject animatedObject;
    private Animator anim;

    private void Start()
    {
        anim = animatedObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particleRedButton.Play();

            if (anim.enabled)
            {
                anim.enabled = false;
            }
            else
            {
                anim.enabled = true;
            }
        }
    }
}
