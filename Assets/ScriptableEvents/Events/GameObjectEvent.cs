using ScriptableEvents.Abstracts;
using UnityEngine;

namespace ScriptableEvents.Events
{
    [CreateAssetMenu(menuName = "Scriptables/GameObject Event", order = 5)]
    public class GameObjectEvent : AbstractEvent<GameObject>
    { }
}