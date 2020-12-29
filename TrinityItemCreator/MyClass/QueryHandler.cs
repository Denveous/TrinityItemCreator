

namespace TrinityItemCreator.MyClass
{
    class QueryHandler
    {
        public QueryHandler() { }

        public static string GetExportQuery()
        {
            string d1 = ", ", dend = ");";

            string sqlPrefix;
            if (Properties.Settings.Default.SQLPrefix == 0)
                sqlPrefix = "INSERT";
            else
                sqlPrefix = "REPLACE";

            string VQuery = "-- Item created with TrinityItemCreator\n" +
                sqlPrefix +
                " INTO `item_template` (`entry`, " +
                // --------------------------------------------------- COLUMNS
                "`class`, " +
                "`subclass`, " +
                "`SoundOverrideSubclass`, " +
                "`name`, " +
                "`displayid`, " +
                "`Quality`, " +
                "`Flags`, " +
                "`FlagsExtra`, " +
                "`BuyCount`, " +
                "`BuyPrice`, " +
                "`SellPrice`, " +
                "`InventoryType`, " +
                "`AllowableClass`, " +
                "`AllowableRace`, " +
                "`ItemLevel`, " +
                "`RequiredLevel`, " +
                "`RequiredSkill`, " +
                "`RequiredSkillRank`, " +
                "`requiredspell`, " +
                "`requiredhonorrank`, " +
                "`RequiredCityRank`, " +
                "`RequiredReputationFaction`, " +
                "`RequiredReputationRank`, " +
                "`maxcount`, " +
                "`stackable`, " +
                "`ContainerSlots`, " +
                "`StatsCount`, " +
                "`stat_type1`, " +
                "`stat_value1`, " +
                "`stat_type2`, " +
                "`stat_value2`, " +
                "`stat_type3`, " +
                "`stat_value3`, " +
                "`stat_type4`, " +
                "`stat_value4`, " +
                "`stat_type5`, " +
                "`stat_value5`, " +
                "`stat_type6`, " +
                "`stat_value6`, " +
                "`stat_type7`, " +
                "`stat_value7`, " +
                "`stat_type8`, " +
                "`stat_value8`, " +
                "`stat_type9`, " +
                "`stat_value9`, " +
                "`stat_type10`, " +
                "`stat_value10`, " +
                "`ScalingStatDistribution`, " +
                "`ScalingStatValue`, " +
                "`dmg_min1`, " +
                "`dmg_max1`, " +
                "`dmg_type1`, " +
                "`dmg_min2`, " +
                "`dmg_max2`, " +
                "`dmg_type2`, " +
                "`armor`, " +
                "`holy_res`, " +
                "`fire_res`, " +
                "`nature_res`, " +
                "`frost_res`, " +
                "`shadow_res`, " +
                "`arcane_res`, " +
                "`delay`, " +
                "`ammo_type`, " +
                "`RangedModRange`, " +
                "`spellid_1`, " +
                "`spelltrigger_1`, " +
                "`spellcharges_1`, " +
                "`spellppmRate_1`, " +
                "`spellcooldown_1`, " +
                "`spellcategory_1`, " +
                "`spellcategorycooldown_1`, " +
                "`spellid_2`, " +
                "`spelltrigger_2`, " +
                "`spellcharges_2`, " +
                "`spellppmRate_2`, " +
                "`spellcooldown_2`, " +
                "`spellcategory_2`, " +
                "`spellcategorycooldown_2`, " +
                "`spellid_3`, " +
                "`spelltrigger_3`, " +
                "`spellcharges_3`, " +
                "`spellppmRate_3`, " +
                "`spellcooldown_3`, " +
                "`spellcategory_3`, " +
                "`spellcategorycooldown_3`, " +
                "`spellid_4`, " +
                "`spelltrigger_4`, " +
                "`spellcharges_4`, " +
                "`spellppmRate_4`, " +
                "`spellcooldown_4`, " +
                "`spellcategory_4`, " +
                "`spellcategorycooldown_4`, " +
                "`spellid_5`, " +
                "`spelltrigger_5`, " +
                "`spellcharges_5`, " +
                "`spellppmRate_5`, " +
                "`spellcooldown_5`, " +
                "`spellcategory_5`, " +
                "`spellcategorycooldown_5`, " +
                "`bonding`, " +
                "`description`, " +
                "`PageText`, " +
                "`LanguageID`, " +
                "`PageMaterial`, " +
                "`startquest`, " +
                "`lockid`, " +
                "`Material`, " +
                "`sheath`, " +
                "`RandomProperty`, " +
                "`RandomSuffix`, " +
                "`block`, " +
                "`itemset`, " +
                "`MaxDurability`, " +
                "`area`, " +
                "`Map`, " +
                "`BagFamily`, " +
                "`TotemCategory`, " +
                "`socketColor_1`, " +
                "`socketContent_1`, " +
                "`socketColor_2`, " +
                "`socketContent_2`, " +
                "`socketColor_3`, " +
                "`socketContent_3`, " +
                "`socketBonus`, " +
                "`GemProperties`, " +
                "`RequiredDisenchantSkill`, " +
                "`ArmorDamageModifier`, " +
                "`duration`, " +
                "`ItemLimitCategory`, " +
                "`HolidayId`, " +
                "`ScriptName`, " +
                "`DisenchantID`, " +
                "`FoodType`, " +
                "`minMoneyLoot`, " +
                "`maxMoneyLoot`, " +
                "`flagsCustom`, " +
                "`VerifiedBuild`) VALUES \n(" +
                // --------------------------------------------------- VALUES
                MyData.Field_entry.ToString()
                + d1 + MyData.Field_class.ToString()
                + d1 + MyData.Field_subclass.ToString()
                + d1 + MyData.Field_SoundOverrideSubclass.ToString()
                + d1 + "'" + MyData.Field_name + "'"
                + d1 + MyData.Field_displayid.ToString()
                + d1 + MyData.Field_Quality.ToString()
                + d1 + MyData.Field_Flags.ToString()
                + d1 + MyData.Field_FlagsExtra.ToString()
                + d1 + MyData.Field_BuyCount.ToString()
                + d1 + MyData.Field_BuyPrice.ToString()
                + d1 + MyData.Field_SellPrice.ToString()
                + d1 + MyData.Field_InventoryType.ToString()
                + d1 + MyData.Field_AllowableClass.ToString()
                + d1 + MyData.Field_AllowableRace.ToString()
                + d1 + MyData.Field_ItemLevel.ToString()
                + d1 + MyData.Field_RequiredLevel.ToString()
                + d1 + MyData.Field_RequiredSkill.ToString()
                + d1 + MyData.Field_RequiredSkillRank.ToString()
                + d1 + MyData.Field_requiredspell.ToString()
                + d1 + MyData.Field_requiredhonorrank.ToString()
                + d1 + MyData.Field_RequiredCityRank.ToString()
                + d1 + MyData.Field_RequiredReputationFaction.ToString()
                + d1 + MyData.Field_RequiredReputationRank.ToString()
                + d1 + MyData.Field_maxcount.ToString()
                + d1 + MyData.Field_stackable.ToString()
                + d1 + MyData.Field_ContainerSlots.ToString()
                + d1 + MyData.Field_StatsCount.ToString()
                + d1 + MyData.Field_stat_type1.ToString()
                + d1 + MyData.Field_stat_value1.ToString()
                + d1 + MyData.Field_stat_type2.ToString()
                + d1 + MyData.Field_stat_value2.ToString()
                + d1 + MyData.Field_stat_type3.ToString()
                + d1 + MyData.Field_stat_value3.ToString()
                + d1 + MyData.Field_stat_type4.ToString()
                + d1 + MyData.Field_stat_value4.ToString()
                + d1 + MyData.Field_stat_type5.ToString()
                + d1 + MyData.Field_stat_value5.ToString()
                + d1 + MyData.Field_stat_type6.ToString()
                + d1 + MyData.Field_stat_value6.ToString()
                + d1 + MyData.Field_stat_type7.ToString()
                + d1 + MyData.Field_stat_value7.ToString()
                + d1 + MyData.Field_stat_type8.ToString()
                + d1 + MyData.Field_stat_value8.ToString()
                + d1 + MyData.Field_stat_type9.ToString()
                + d1 + MyData.Field_stat_value9.ToString()
                + d1 + MyData.Field_stat_type10.ToString()
                + d1 + MyData.Field_stat_value10.ToString()
                + d1 + MyData.Field_ScalingStatDistribution.ToString()
                + d1 + MyData.Field_ScalingStatValue.ToString()
                + d1 + MyData.Field_dmg_min1.ToString()
                + d1 + MyData.Field_dmg_max1.ToString()
                + d1 + MyData.Field_dmg_type1.ToString()
                + d1 + MyData.Field_dmg_min2.ToString()
                + d1 + MyData.Field_dmg_max2.ToString()
                + d1 + MyData.Field_dmg_type2.ToString()
                + d1 + MyData.Field_armor.ToString()
                + d1 + MyData.Field_holy_res.ToString()
                + d1 + MyData.Field_fire_res.ToString()
                + d1 + MyData.Field_nature_res.ToString()
                + d1 + MyData.Field_frost_res.ToString()
                + d1 + MyData.Field_shadow_res.ToString()
                + d1 + MyData.Field_arcane_res.ToString()
                + d1 + MyData.Field_delay.ToString()
                + d1 + MyData.Field_ammo_type.ToString()
                + d1 + MyData.Field_RangedModRange.ToString()
                + d1 + MyData.Field_spellid_1.ToString()
                + d1 + MyData.Field_spelltrigger_1.ToString()
                + d1 + MyData.Field_spellcharges_1.ToString()
                + d1 + MyData.Field_spellppmRate_1.ToString()
                + d1 + MyData.Field_spellcooldown_1.ToString()
                + d1 + MyData.Field_spellcategory_1.ToString()
                + d1 + MyData.Field_spellcategorycooldown_1.ToString()
                + d1 + MyData.Field_spellid_2.ToString()
                + d1 + MyData.Field_spelltrigger_2.ToString()
                + d1 + MyData.Field_spellcharges_2.ToString()
                + d1 + MyData.Field_spellppmRate_2.ToString()
                + d1 + MyData.Field_spellcooldown_2.ToString()
                + d1 + MyData.Field_spellcategory_2.ToString()
                + d1 + MyData.Field_spellcategorycooldown_2.ToString()
                + d1 + MyData.Field_spellid_3.ToString()
                + d1 + MyData.Field_spelltrigger_3.ToString()
                + d1 + MyData.Field_spellcharges_3.ToString()
                + d1 + MyData.Field_spellppmRate_3.ToString()
                + d1 + MyData.Field_spellcooldown_3.ToString()
                + d1 + MyData.Field_spellcategory_3.ToString()
                + d1 + MyData.Field_spellcategorycooldown_3.ToString()
                + d1 + MyData.Field_spellid_4.ToString()
                + d1 + MyData.Field_spelltrigger_4.ToString()
                + d1 + MyData.Field_spellcharges_4.ToString()
                + d1 + MyData.Field_spellppmRate_4.ToString()
                + d1 + MyData.Field_spellcooldown_4.ToString()
                + d1 + MyData.Field_spellcategory_4.ToString()
                + d1 + MyData.Field_spellcategorycooldown_4.ToString()
                + d1 + MyData.Field_spellid_5.ToString()
                + d1 + MyData.Field_spelltrigger_5.ToString()
                + d1 + MyData.Field_spellcharges_5.ToString()
                + d1 + MyData.Field_spellppmRate_5.ToString()
                + d1 + MyData.Field_spellcooldown_5.ToString()
                + d1 + MyData.Field_spellcategory_5.ToString()
                + d1 + MyData.Field_spellcategorycooldown_5.ToString()
                + d1 + MyData.Field_bonding.ToString()
                + d1 + "'" + MyData.Field_description + "'"
                + d1 + MyData.Field_PageText.ToString()
                + d1 + MyData.Field_LanguageID.ToString()
                + d1 + MyData.Field_PageMaterial.ToString()
                + d1 + MyData.Field_startquest.ToString()
                + d1 + MyData.Field_lockid.ToString()
                + d1 + MyData.Field_Material.ToString()
                + d1 + MyData.Field_sheath.ToString()
                + d1 + MyData.Field_RandomProperty.ToString()
                + d1 + MyData.Field_RandomSuffix.ToString()
                + d1 + MyData.Field_block.ToString()
                + d1 + MyData.Field_itemset.ToString()
                + d1 + MyData.Field_MaxDurability.ToString()
                + d1 + MyData.Field_area.ToString()
                + d1 + MyData.Field_Map.ToString()
                + d1 + MyData.Field_BagFamily.ToString()
                + d1 + MyData.Field_TotemCategory.ToString()
                + d1 + MyData.Field_socketColor_1.ToString()
                + d1 + MyData.Field_socketContent_1.ToString()
                + d1 + MyData.Field_socketColor_2.ToString()
                + d1 + MyData.Field_socketContent_2.ToString()
                + d1 + MyData.Field_socketColor_3.ToString()
                + d1 + MyData.Field_socketContent_3.ToString()
                + d1 + MyData.Field_socketBonus.ToString()
                + d1 + MyData.Field_GemProperties.ToString()
                + d1 + MyData.Field_RequiredDisenchantSkill.ToString()
                + d1 + MyData.Field_ArmorDamageModifier.ToString()
                + d1 + MyData.Field_duration.ToString()
                + d1 + MyData.Field_ItemLimitCategory.ToString()
                + d1 + MyData.Field_HolidayId.ToString()
                + d1 + "'" + MyData.Field_ScriptName + "'"
                + d1 + MyData.Field_DisenchantID.ToString()
                + d1 + MyData.Field_FoodType.ToString()
                + d1 + MyData.Field_minMoneyLoot.ToString()
                + d1 + MyData.Field_maxMoneyLoot.ToString()
                + d1 + MyData.Field_flagsCustom.ToString()
                + d1 + MyData.Field_VerifiedBuild.ToString() 
                + dend;

                return VQuery;
        }
    }
}
