using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameInput
{
    [CreateAssetMenuAttribute(menuName = "ScriptableObjects/Input/InputData")]
    public class InputData : ScriptableObject
    {
        public float horizontal;
        public float vertical;
        public bool jump;
    }
}
