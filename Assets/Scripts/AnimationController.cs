using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    private bool nearthedor;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && nearthedor)
        {
            if (!anim.enabled)
            {
                anim.enabled = true;
            }
            if (!anim.GetBool("clouse/open"))
            {
                anim.SetBool("clouse/open", true);
            }
            else
            {
                anim.SetBool("clouse/open", false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            nearthedor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            nearthedor = false;
        }
    }
}
