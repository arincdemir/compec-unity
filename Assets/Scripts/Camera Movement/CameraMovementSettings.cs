using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraMovement
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Camera/CameraMovementSettings")]
    public class CameraMovementSettings : ScriptableObject
    {
        public float rotationLerpSpeed = 1;
        public float movementLerpSpeed = 2;
        public float offsetBack = 10;
        public float offsetUp = 5;
    }
}