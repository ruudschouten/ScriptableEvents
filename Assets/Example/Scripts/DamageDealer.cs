using ScriptableEvents.Events;
using UnityEngine;

namespace Example
{
    public class DamageDealer : MonoBehaviour
    {
        public DamageStat DamageStat;
        public DamageStatEvent DealDamageEvent;

        public void DealDamage()
        {
            DealDamageEvent.Sent = DamageStat;
            DealDamageEvent.Raise();
        }
    }
}