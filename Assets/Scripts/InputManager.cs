using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameInput
{
    public class InputManager : MonoBehaviour
    {
        public InputData inputData;
        public InputSettings inputSettings;

        void Update()
        {
            inputData.horizontal = Input.GetAxisRaw("Horizontal");
            inputData.vertical = Input.GetAxisRaw("Vertical");
            inputData.jump = Input.GetKey(inputSettings.jumpKey);
        }
    }
}