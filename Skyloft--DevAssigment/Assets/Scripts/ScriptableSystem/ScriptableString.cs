using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(menuName = "ScriptableSystem/ScriptableData/ScriptableString")]
    public class ScriptableString : ScriptableObject
    {
        public int value;

        public int GetValue()
        {
            return value;
        }
    }
}

