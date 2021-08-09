using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Transform position;
    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        position.position = playerTransform.position;
    }
}
