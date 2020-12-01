using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMovement
{
    [CreateAssetMenuAttribute(menuName = "ScriptableObjects/PlayerMovement/PlayerMovementSettings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float sidewaysForce = 20000;
        public float jumpForce = 10;
        public float jumpDelay = 2;
    }
}