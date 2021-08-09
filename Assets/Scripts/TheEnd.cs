using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    [SerializeField] private GameObject theEndCanvas;
    [SerializeField] private GameObject player;
    [SerializeField] private ParticleSystem particleWin;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<Rigidbody>().isKinematic = true;
            player.GetComponent<MeshRenderer>().enabled = false;
            theEndCanvas.SetActive(true);
            particleWin.Play();
        }
    }
}
