using UnityEngine;
using UnityEngine.UI;

namespace Example
{
    public class HealthUI : MonoBehaviour
    {
        public Text HealthText;
        public Text DamageChangeText;
        public Player Player;

        private void Awake()
        {
            HealthText.text = string.Format("{0}/{1}", Player.Health, Player.MaxHealth);
            DamageChangeText.text = ("Damage");
        }

        public void DisplayDamage(int amount)
        {
            DamageChangeText.text = string.Format("Received {0} Damage", amount);
        }

        public void DisplayHealing(int amount)
        {
            DamageChangeText.text = string.Format("Recovered {0} Damage", amount);
        }

        public void DisplayHealth(int amount)
        {
            HealthText.text = string.Format("{0}/{1}", amount, Player.MaxHealth);
        }
    }
}