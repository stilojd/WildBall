using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private ParticleSystem particleOfOver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameOver"))
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            particleOfOver.Play();
            StartCoroutine(timer());
        }
    }

    private IEnumerator timer()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
