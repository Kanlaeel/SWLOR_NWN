using SWLOR.Game.Server.Legacy.Enumeration;
using SWLOR.Game.Server.Legacy.Quest;

namespace SWLOR.Game.Server.Legacy.Scripts.Quest.GuildTasks.HuntersGuild
{
    public class MandalorianPlexiplate: AbstractQuest
    {
        public MandalorianPlexiplate()
        {
            CreateQuest(593, "Hunter's Guild Task: 6x Mandalorian Plexi-plate", "hun_tsk_593")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "m_plexiplate", 6, false)

                .AddRewardGold(83)
                .AddRewardGuildPoints(GuildType.HuntersGuild, 25);
        }
    }
}