using Dapper.Contrib.Extensions;
using SWLOR.Game.Server.Legacy.Data.Contracts;

namespace SWLOR.Game.Server.Legacy.Data.Entity
{
    [Table("PerkLevelQuestRequirement")]
    public class PerkLevelQuestRequirement: IEntity
    {
        [Key]
        public int ID { get; set; }
        public int PerkLevelID { get; set; }
        public int RequiredQuestID { get; set; }

        public IEntity Clone()
        {
            return new PerkLevelQuestRequirement
            {
                ID = ID,
                PerkLevelID = PerkLevelID,
                RequiredQuestID = RequiredQuestID
            };
        }
    }
}