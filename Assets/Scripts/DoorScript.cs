using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject door;
    private HingeJoint hinge;
    private bool nearthedor;
    private bool open = false;
    private JointLimits hingeLim;
    private float currentAngle = 1f;

    private void Start()
    {
        hinge = door.GetComponent<HingeJoint>();
        hingeLim.max = 2f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && nearthedor)
        {
            if (!open)
            {
                open = true;
            }
            else
            {
                open = false;
            }
        }
    }

    private void FixedUpdate()
    {
        if (open && hingeLim.max < 90f)
        {
            hingeLim.max += currentAngle * speed;
            hingeLim.min += currentAngle * speed;
            hinge.limits = hingeLim;
        }
        else if (!open && hingeLim.min > 0f)
        {
            hingeLim.min -= currentAngle * speed;
            hingeLim.max -= currentAngle * speed;
            hinge.limits = hingeLim;
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
