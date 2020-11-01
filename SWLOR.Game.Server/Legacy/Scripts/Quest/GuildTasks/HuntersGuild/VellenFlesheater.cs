using SWLOR.Game.Server.Legacy.Enumeration;
using SWLOR.Game.Server.Legacy.Quest;

namespace SWLOR.Game.Server.Legacy.Scripts.Quest.GuildTasks.HuntersGuild
{
    public class VellenFlesheater: AbstractQuest
    {
        public VellenFlesheater()
        {
            CreateQuest(610, "Hunter's Guild Task: 10x Vellen Flesheater", "hun_tsk_610")
                .IsRepeatable()

                .AddObjectiveKillTarget(1, NPCGroupType.Viscara_VellenFlesheater, 10)
                .AddObjectiveTalkToNPC(2)

                .AddRewardGold(184)
                .AddRewardGuildPoints(GuildType.HuntersGuild, 44);
        }
    }
}