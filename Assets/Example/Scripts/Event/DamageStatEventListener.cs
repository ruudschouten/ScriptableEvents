using System.Collections.Generic;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Responses;

namespace ScriptableEvents.Listeners
{
    public class DamageStatEventListener : AbstractEventListener<DamageStat>
    {
        public List<DamageStatResponse> Responses = new List<DamageStatResponse>();

        public override List<AbstractEventResponse<DamageStat>> GetResponse()
        {
            return new List<AbstractEventResponse<DamageStat>>(Responses);
        }
    }
}