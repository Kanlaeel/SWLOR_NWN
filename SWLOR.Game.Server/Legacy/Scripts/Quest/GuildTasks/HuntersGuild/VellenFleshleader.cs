using SWLOR.Game.Server.Legacy.Enumeration;
using SWLOR.Game.Server.Legacy.Quest;

namespace SWLOR.Game.Server.Legacy.Scripts.Quest.GuildTasks.HuntersGuild
{
    public class VellenFleshleader: AbstractQuest
    {
        public VellenFleshleader()
        {
            CreateQuest(609, "Hunter's Guild Task: 1x Vellen Fleshleader", "hun_tsk_609")
                .IsRepeatable()

                .AddObjectiveKillTarget(1, NPCGroupType.Viscara_VellenFleshleader, 1)
                .AddObjectiveTalkToNPC(2)

                .AddRewardGold(184)
                .AddRewardGuildPoints(GuildType.HuntersGuild, 44);
        }
    }
}