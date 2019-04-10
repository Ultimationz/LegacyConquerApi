using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyConquer.Api
{
    public interface ISkillManager
    {
        /// <summary>
        /// Award a skill/weapon proficiency to the player, if they already have it learned only the level will be changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="level"></param>
        void AwardSkill(uint id, uint level);

        /// <summary>
        /// Remove a skill/weapon proficiency from the player, 
        /// </summary>
        /// <param name="id"></param>
        void RemoveSkill(uint id);

        /// <summary>
        /// Give the skill/weapon proficiency some experience.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        void AwardSkillExp(uint id, long amount);

        /// <summary>
        /// Has the player already learned a  skill/weapon proficiency?
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool HasSkill(uint id);

        /// <summary>
        /// Get the skill/weapon proficiency level by the skill Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int GetSkillLevel(uint id);
    }
}
