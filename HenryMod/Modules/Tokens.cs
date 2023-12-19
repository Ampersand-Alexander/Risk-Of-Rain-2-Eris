using R2API;
using System;

namespace ErisMod.Modules
{
    internal static class Tokens
    {
        internal static void AddTokens()
        {
            #region Eris
            string prefix = HenryPlugin.DEVELOPER_PREFIX + "_ERIS_BODY_";

            string desc = "Eris was contemptuous, impulsive, defiant, and condescending. A short tempered women devoted to protect the protagonist against the Dragon God himself.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Sword is a good all-rounder while Boxing Gloves are better for laying a beatdown on more powerful foes." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Pistol is a powerful anti air, with its low cooldown and high damage." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Roll has a lingering armor buff that helps to use it aggressively." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Bomb can be used to wipe crowds with ease." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so she departed, to fight the Dragon God.";
            string outroFailure = "..and so she left, for the Holy Land of Swords.";

            LanguageAPI.Add(prefix + "NAME", "Mad Sword King Eris");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "'Intense, that was my first impression. All my senses are flashing danger signals again' -Rudeus");
            LanguageAPI.Add(prefix + "LORE", "'As expected of Rudeus.'");
            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Default");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "Alternate");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Mad Dog / Sword God Style: Long Sword of Light");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", "Eris gets angry the more damaged she is. Her attacks will be faster and cooldowns will be lower. Additionally, the longer she is in combat, she gains stacks of rage allowing her to unleash Long Sword of Light Augmenting each of her abilities.");
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_NAME", "Nameless Sword");
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Helpers.agilePrefix + $"Slash for <style=cIsDamage>{100f * StaticValues.swordDamageCoefficient}% damage</style>. If Long Sword of Light is active, her range is extended and she instead deals <style=cIsDamage>{200f * StaticValues.swordDamageCoefficient}% damage</style>");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_GUN_NAME", "Sword God Style: Light Reversal");
            LanguageAPI.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Helpers.agilePrefix + $"Momentarily block. If Sword of Light is active, enemy attacks are stored during this time and at the end of the invincibility send out a long range cut of light at your cursors direction that deals more damage based on how much was stored up to <style=cIsDamage>{100f * StaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_ROLL_NAME", "Sword God Style: Longsword of Silence");
            LanguageAPI.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Launch yourself and swing your blade beyond the speed of sound a velocity beyond the speed of sound at a targeted enemy and appear behind them. Dealing <style=cIsDamage>{100f * StaticValues.swordDamageCoefficient}% Damage <style=cIsDamage> Executing under 10% hp. If Sword of Light is active, Additionally mark them for death</style>");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_NAME", "Bomb");
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>{100f * StaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Henry: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Henry, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Henry: Mastery");
            #endregion
            #endregion
        }
    }
}