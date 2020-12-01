using GameInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMovement
{
    public class PlayerMovement : MonoBehaviour
    {
        public Rigidbody rigidBody;
        public InputData inputData;
        public PlayerMovementSettings movementSettings;

        private float timeSinceLastJump = 10000;
        void Update()
        {
            timeSinceLastJump += Time.deltaTime;
            rigidBody.AddForce(new Vector3(inputData.horizontal, 0, inputData.vertical) * Time.deltaTime * movementSettings.sidewaysForce, ForceMode.Acceleration);
            if (inputData.jump && timeSinceLastJump > movementSettings.jumpDelay) {
                timeSinceLastJump = 0;
                rigidBody.AddForce(new Vector3(0, 1, 0) * movementSettings.jumpForce, ForceMode.VelocityChange);
            }
        }
    }
}