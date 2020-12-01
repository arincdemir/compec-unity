using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameInput
{
    [CreateAssetMenuAttribute(menuName = "ScriptableObjects/Input/InputSettings")]
    public class InputSettings : ScriptableObject
    {
        public KeyCode jumpKey;
    }
}
