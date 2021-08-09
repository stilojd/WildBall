using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 offset;

    private void Start()
    {
        offset = gameObject.transform.position - playerTransform.position;
    }

    private void Update()
    {
        gameObject.transform.position = playerTransform.position + offset;
    }
}
