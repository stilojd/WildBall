using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WildBall.Inputs
{
    [RequireComponent(typeof(Movement))]

    public class PlayerInput : MonoBehaviour
    {
        private Vector3 movement;
        private Movement playerMovement;
        private bool jump;

        private void Awake()
        {
            playerMovement = GetComponent<Movement>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalAxisVariables.HorizontaAxis);
            float vertical = Input.GetAxis(GlobalAxisVariables.VerticalAxis);
            jump = Input.GetButtonDown(GlobalAxisVariables.JumpAxis);
            movement = new Vector3(horizontal, 0, vertical).normalized;
            playerMovement.MoveCharacter(movement, jump);
        }
    }
}