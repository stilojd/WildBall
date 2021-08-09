using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helps : MonoBehaviour
{
    [SerializeField] private GameObject helpText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            helpText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            helpText.SetActive(false);
        }
    }
}
