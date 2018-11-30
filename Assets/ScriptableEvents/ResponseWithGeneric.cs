using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents
{
    [Serializable] public class ResponseWithGeneric<T> : UnityEvent<T> {}
    [Serializable] public class ResponseWithBool : ResponseWithGeneric<bool> {}
    [Serializable] public class ResponseWithString : ResponseWithGeneric<string> {}
    [Serializable] public class ResponseWithInteger : ResponseWithGeneric<int> {}
    [Serializable] public class ResponseWithFloat : ResponseWithGeneric<float> {}
    [Serializable] public class ResponseWithGameObject : ResponseWithGeneric<GameObject> {}
}