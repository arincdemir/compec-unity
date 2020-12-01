using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraMovement{
    public class CameraMovementManager : MonoBehaviour
    {
        public CameraMovementSettings cameraMovementSettings;
        public Transform cameraTransform;
        public Transform targetTransform;

        void Update()
        {
            rotate();
            move();
        }

        private void rotate()
        {
            cameraTransform.rotation = Quaternion.Lerp(cameraTransform.rotation, Quaternion.LookRotation(
                targetTransform.position - cameraTransform.position), Time.deltaTime * cameraMovementSettings.rotationLerpSpeed);
        }

        private void move()
        {
            cameraTransform.position = Vector3.Lerp(cameraTransform.position, targetTransform.position + targetTransform.forward * cameraMovementSettings.offsetBack * -1 ,Time.deltaTime * cameraMovementSettings.movementLerpSpeed);
            cameraTransform.position = new Vector3(cameraTransform.position.x, targetTransform.position.y + cameraMovementSettings.offsetUp, cameraTransform.position.z);
        }
    }
}
