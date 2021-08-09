using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]

    public class Movement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        [SerializeField, Range(0, 10)] private float jumpPower = 2.0f;

        private Rigidbody playerRigidbody;
        private bool isGround;

        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 movement, bool jump)
        {
            playerRigidbody.AddForce(movement * speed);
            if (jump && isGround)
            {
                playerRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Ground"))
            {
                isGround = true;
            }
        }
       
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Ground"))
            {
                isGround = false;
            }
        }

#if UNITY_EDITOR
        [ContextMenu("Reset values")]
        public void ResetValues()
        {
            speed = 2;
            jumpPower = 2.0f;
        }
#endif
    }
}