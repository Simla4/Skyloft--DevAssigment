using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(menuName = "ScriptableSystem/ScriptableData/ScriptableFloat")]
    public class ScriptableFloat : ScriptableObject
    {
        public int value;

        public int GetValue()
        {
            return value;
        }

        public int IncreaseValue(int v)
        {
            value += v;
            return value;
        }

        public int DecreaseValue(int v)
        {
            value -= v;
            return value;
        }

        public int MultibleValue(int v)
        {
            value *= v;
            return value;
        }

        public int DivideValue(int v)
        {
            value /= v;
            return value;
        }


    }
}