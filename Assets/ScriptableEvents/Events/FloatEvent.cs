using ScriptableEvents.Abstracts;
using UnityEngine;

namespace ScriptableEvents.Events
{
    [CreateAssetMenu(menuName = "Scriptables/Float Event", order = 3)]
    public class FloatEvent : AbstractEvent<float>
    { }
}