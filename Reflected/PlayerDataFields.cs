namespace Satchel.Reflected
{
    /// <summary>
    /// A class that allows you to access PD directly while also using PlayerData.Get/Set functions
    /// </summary>
    public static class PlayerDataR
    { 
        public static string version
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.version));
            set => PlayerData.instance.SetString(nameof(PlayerData.version), value);
		}

		public static bool awardAllAchievements
        {
			get => PlayerData.instance.GetBool(nameof(PlayerData.awardAllAchievements));
			set => PlayerData.instance.SetBool(nameof(PlayerData.awardAllAchievements), value);
		}

        public static int profileID
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.profileID));
           set => PlayerData.instance.SetInt(nameof(PlayerData.profileID), value);
        }

        public static float playTime
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.playTime));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.playTime), value);
        }

        public static float completionPercent
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.completionPercent));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.completionPercent), value);
        }

        public static bool openingCreditsPlayed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openingCreditsPlayed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openingCreditsPlayed), value);
        }

        public static int permadeathMode
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.permadeathMode));
           set => PlayerData.instance.SetInt(nameof(PlayerData.permadeathMode), value);
        }

        public static int health
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.health));
           set => PlayerData.instance.SetInt(nameof(PlayerData.health), value);
        }

        public static int maxHealth
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.maxHealth));
           set => PlayerData.instance.SetInt(nameof(PlayerData.maxHealth), value);
        }

        public static int maxHealthBase
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.maxHealthBase));
           set => PlayerData.instance.SetInt(nameof(PlayerData.maxHealthBase), value);
        }

        public static int healthBlue
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.healthBlue));
           set => PlayerData.instance.SetInt(nameof(PlayerData.healthBlue), value);
        }

        public static int joniHealthBlue
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.joniHealthBlue));
           set => PlayerData.instance.SetInt(nameof(PlayerData.joniHealthBlue), value);
        }

        public static bool damagedBlue
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.damagedBlue));
            set => PlayerData.instance.SetBool(nameof(PlayerData.damagedBlue), value);
        }

        public static int heartPieces
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.heartPieces));
           set => PlayerData.instance.SetInt(nameof(PlayerData.heartPieces), value);
        }

        public static bool heartPieceCollected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.heartPieceCollected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.heartPieceCollected), value);
        }

        public static int maxHealthCap
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.maxHealthCap));
           set => PlayerData.instance.SetInt(nameof(PlayerData.maxHealthCap), value);
        }

        public static bool heartPieceMax
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.heartPieceMax));
            set => PlayerData.instance.SetBool(nameof(PlayerData.heartPieceMax), value);
        }

        public static int prevHealth
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.prevHealth));
           set => PlayerData.instance.SetInt(nameof(PlayerData.prevHealth), value);
        }

        public static int blockerHits
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.blockerHits));
           set => PlayerData.instance.SetInt(nameof(PlayerData.blockerHits), value);
        }

        public static bool firstGeo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.firstGeo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.firstGeo), value);
        }

        public static int geo
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.geo));
           set => PlayerData.instance.SetInt(nameof(PlayerData.geo), value);
        }

        public static int maxMP
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.maxMP));
           set => PlayerData.instance.SetInt(nameof(PlayerData.maxMP), value);
        }

        public static int MPCharge
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.MPCharge));
           set => PlayerData.instance.SetInt(nameof(PlayerData.MPCharge), value);
        }

        public static int MPReserve
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.MPReserve));
           set => PlayerData.instance.SetInt(nameof(PlayerData.MPReserve), value);
        }

        public static int MPReserveMax
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.MPReserveMax));
           set => PlayerData.instance.SetInt(nameof(PlayerData.MPReserveMax), value);
        }

        public static bool soulLimited
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.soulLimited));
            set => PlayerData.instance.SetBool(nameof(PlayerData.soulLimited), value);
        }

        public static int vesselFragments
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.vesselFragments));
           set => PlayerData.instance.SetInt(nameof(PlayerData.vesselFragments), value);
        }

        public static bool vesselFragmentCollected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.vesselFragmentCollected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.vesselFragmentCollected), value);
        }

        public static int MPReserveCap
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.MPReserveCap));
           set => PlayerData.instance.SetInt(nameof(PlayerData.MPReserveCap), value);
        }

        public static bool vesselFragmentMax
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.vesselFragmentMax));
            set => PlayerData.instance.SetBool(nameof(PlayerData.vesselFragmentMax), value);
        }

        public static int focusMP_amount
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.focusMP_amount));
           set => PlayerData.instance.SetInt(nameof(PlayerData.focusMP_amount), value);
        }

        public static bool atBench
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.atBench));
            set => PlayerData.instance.SetBool(nameof(PlayerData.atBench), value);
        }

        public static string respawnScene
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.respawnScene));
            set => PlayerData.instance.SetString(nameof(PlayerData.respawnScene), value);
        }

        public static GlobalEnums.MapZone mapZone
        {
            get => PlayerData.instance.GetVariable<GlobalEnums.MapZone>(nameof(PlayerData.mapZone));
            set => PlayerData.instance.SetVariable<GlobalEnums.MapZone>(nameof(PlayerData.mapZone), value);
        }

        public static string respawnMarkerName
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.respawnMarkerName));
            set => PlayerData.instance.SetString(nameof(PlayerData.respawnMarkerName), value);
        }

        public static int respawnType
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.respawnType));
           set => PlayerData.instance.SetInt(nameof(PlayerData.respawnType), value);
        }

        public static bool respawnFacingRight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.respawnFacingRight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.respawnFacingRight), value);
        }

        public static UnityEngine.Vector3 hazardRespawnLocation
        {
            get => PlayerData.instance.GetVector3(nameof(PlayerData.hazardRespawnLocation));
            set => PlayerData.instance.SetVector3(nameof(PlayerData.hazardRespawnLocation), value);
        }

        public static bool hazardRespawnFacingRight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hazardRespawnFacingRight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hazardRespawnFacingRight), value);
        }

        public static string shadeScene
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.shadeScene));
            set => PlayerData.instance.SetString(nameof(PlayerData.shadeScene), value);
        }

        public static string shadeMapZone
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.shadeMapZone));
            set => PlayerData.instance.SetString(nameof(PlayerData.shadeMapZone), value);
        }

        public static float shadePositionX
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.shadePositionX));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.shadePositionX), value);
        }

        public static float shadePositionY
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.shadePositionY));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.shadePositionY), value);
        }

        public static int shadeHealth
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.shadeHealth));
           set => PlayerData.instance.SetInt(nameof(PlayerData.shadeHealth), value);
        }

        public static int shadeMP
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.shadeMP));
           set => PlayerData.instance.SetInt(nameof(PlayerData.shadeMP), value);
        }

        public static int shadeFireballLevel
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.shadeFireballLevel));
           set => PlayerData.instance.SetInt(nameof(PlayerData.shadeFireballLevel), value);
        }

        public static int shadeQuakeLevel
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.shadeQuakeLevel));
           set => PlayerData.instance.SetInt(nameof(PlayerData.shadeQuakeLevel), value);
        }

        public static int shadeScreamLevel
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.shadeScreamLevel));
           set => PlayerData.instance.SetInt(nameof(PlayerData.shadeScreamLevel), value);
        }

        public static int shadeSpecialType
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.shadeSpecialType));
           set => PlayerData.instance.SetInt(nameof(PlayerData.shadeSpecialType), value);
        }

        public static UnityEngine.Vector3 shadeMapPos
        {
            get => PlayerData.instance.GetVector3(nameof(PlayerData.shadeMapPos));
            set => PlayerData.instance.SetVector3(nameof(PlayerData.shadeMapPos), value);
        }

        public static UnityEngine.Vector3 dreamgateMapPos
        {
            get => PlayerData.instance.GetVector3(nameof(PlayerData.dreamgateMapPos));
            set => PlayerData.instance.SetVector3(nameof(PlayerData.dreamgateMapPos), value);
        }

        public static int geoPool
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.geoPool));
           set => PlayerData.instance.SetInt(nameof(PlayerData.geoPool), value);
        }

        public static int nailDamage
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.nailDamage));
           set => PlayerData.instance.SetInt(nameof(PlayerData.nailDamage), value);
        }

        public static int nailRange
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.nailRange));
           set => PlayerData.instance.SetInt(nameof(PlayerData.nailRange), value);
        }

        public static int beamDamage
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.beamDamage));
           set => PlayerData.instance.SetInt(nameof(PlayerData.beamDamage), value);
        }

        public static bool canDash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.canDash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.canDash), value);
        }

        public static bool canBackDash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.canBackDash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.canBackDash), value);
        }

        public static bool canWallJump
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.canWallJump));
            set => PlayerData.instance.SetBool(nameof(PlayerData.canWallJump), value);
        }

        public static bool canSuperDash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.canSuperDash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.canSuperDash), value);
        }

        public static bool canShadowDash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.canShadowDash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.canShadowDash), value);
        }

        public static bool hasSpell
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasSpell));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasSpell), value);
        }

        public static int fireballLevel
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.fireballLevel));
           set => PlayerData.instance.SetInt(nameof(PlayerData.fireballLevel), value);
        }

        public static int quakeLevel
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.quakeLevel));
           set => PlayerData.instance.SetInt(nameof(PlayerData.quakeLevel), value);
        }

        public static int screamLevel
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.screamLevel));
           set => PlayerData.instance.SetInt(nameof(PlayerData.screamLevel), value);
        }

        public static bool hasNailArt
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasNailArt));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasNailArt), value);
        }

        public static bool hasCyclone
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasCyclone));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasCyclone), value);
        }

        public static bool hasDashSlash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasDashSlash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasDashSlash), value);
        }

        public static bool hasUpwardSlash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasUpwardSlash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasUpwardSlash), value);
        }

        public static bool hasAllNailArts
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasAllNailArts));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasAllNailArts), value);
        }

        public static bool hasDreamNail
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasDreamNail));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasDreamNail), value);
        }

        public static bool hasDreamGate
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasDreamGate));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasDreamGate), value);
        }

        public static bool dreamNailUpgraded
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamNailUpgraded));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamNailUpgraded), value);
        }

        public static int dreamOrbs
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.dreamOrbs));
           set => PlayerData.instance.SetInt(nameof(PlayerData.dreamOrbs), value);
        }

        public static int dreamOrbsSpent
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.dreamOrbsSpent));
           set => PlayerData.instance.SetInt(nameof(PlayerData.dreamOrbsSpent), value);
        }

        public static string dreamGateScene
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.dreamGateScene));
            set => PlayerData.instance.SetString(nameof(PlayerData.dreamGateScene), value);
        }

        public static float dreamGateX
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.dreamGateX));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.dreamGateX), value);
        }

        public static float dreamGateY
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.dreamGateY));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.dreamGateY), value);
        }

        public static bool hasDash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasDash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasDash), value);
        }

        public static bool hasWalljump
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasWalljump));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasWalljump), value);
        }

        public static bool hasSuperDash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasSuperDash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasSuperDash), value);
        }

        public static bool hasShadowDash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasShadowDash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasShadowDash), value);
        }

        public static bool hasAcidArmour
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasAcidArmour));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasAcidArmour), value);
        }

        public static bool hasDoubleJump
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasDoubleJump));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasDoubleJump), value);
        }

        public static bool hasLantern
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasLantern));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasLantern), value);
        }

        public static bool hasTramPass
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasTramPass));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasTramPass), value);
        }

        public static bool hasQuill
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasQuill));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasQuill), value);
        }

        public static bool hasCityKey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasCityKey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasCityKey), value);
        }

        public static bool hasSlykey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasSlykey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasSlykey), value);
        }

        public static bool gaveSlykey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gaveSlykey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gaveSlykey), value);
        }

        public static bool hasWhiteKey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasWhiteKey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasWhiteKey), value);
        }

        public static bool usedWhiteKey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.usedWhiteKey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.usedWhiteKey), value);
        }

        public static bool hasMenderKey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasMenderKey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasMenderKey), value);
        }

        public static bool hasWaterwaysKey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasWaterwaysKey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasWaterwaysKey), value);
        }

        public static bool hasSpaKey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasSpaKey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasSpaKey), value);
        }

        public static bool hasLoveKey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasLoveKey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasLoveKey), value);
        }

        public static bool hasKingsBrand
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasKingsBrand));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasKingsBrand), value);
        }

        public static bool hasXunFlower
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasXunFlower));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasXunFlower), value);
        }

        public static int ghostCoins
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.ghostCoins));
           set => PlayerData.instance.SetInt(nameof(PlayerData.ghostCoins), value);
        }

        public static int ore
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.ore));
           set => PlayerData.instance.SetInt(nameof(PlayerData.ore), value);
        }

        public static bool foundGhostCoin
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.foundGhostCoin));
            set => PlayerData.instance.SetBool(nameof(PlayerData.foundGhostCoin), value);
        }

        public static int trinket1
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.trinket1));
           set => PlayerData.instance.SetInt(nameof(PlayerData.trinket1), value);
        }

        public static bool foundTrinket1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.foundTrinket1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.foundTrinket1), value);
        }

        public static int trinket2
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.trinket2));
           set => PlayerData.instance.SetInt(nameof(PlayerData.trinket2), value);
        }

        public static bool foundTrinket2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.foundTrinket2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.foundTrinket2), value);
        }

        public static int trinket3
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.trinket3));
           set => PlayerData.instance.SetInt(nameof(PlayerData.trinket3), value);
        }

        public static bool foundTrinket3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.foundTrinket3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.foundTrinket3), value);
        }

        public static int trinket4
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.trinket4));
           set => PlayerData.instance.SetInt(nameof(PlayerData.trinket4), value);
        }

        public static bool foundTrinket4
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.foundTrinket4));
            set => PlayerData.instance.SetBool(nameof(PlayerData.foundTrinket4), value);
        }

        public static bool noTrinket1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.noTrinket1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.noTrinket1), value);
        }

        public static bool noTrinket2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.noTrinket2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.noTrinket2), value);
        }

        public static bool noTrinket3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.noTrinket3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.noTrinket3), value);
        }

        public static bool noTrinket4
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.noTrinket4));
            set => PlayerData.instance.SetBool(nameof(PlayerData.noTrinket4), value);
        }

        public static int soldTrinket1
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.soldTrinket1));
           set => PlayerData.instance.SetInt(nameof(PlayerData.soldTrinket1), value);
        }

        public static int soldTrinket2
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.soldTrinket2));
           set => PlayerData.instance.SetInt(nameof(PlayerData.soldTrinket2), value);
        }

        public static int soldTrinket3
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.soldTrinket3));
           set => PlayerData.instance.SetInt(nameof(PlayerData.soldTrinket3), value);
        }

        public static int soldTrinket4
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.soldTrinket4));
           set => PlayerData.instance.SetInt(nameof(PlayerData.soldTrinket4), value);
        }

        public static int simpleKeys
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.simpleKeys));
           set => PlayerData.instance.SetInt(nameof(PlayerData.simpleKeys), value);
        }

        public static int rancidEggs
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.rancidEggs));
           set => PlayerData.instance.SetInt(nameof(PlayerData.rancidEggs), value);
        }

        public static bool notchShroomOgres
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.notchShroomOgres));
            set => PlayerData.instance.SetBool(nameof(PlayerData.notchShroomOgres), value);
        }

        public static bool notchFogCanyon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.notchFogCanyon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.notchFogCanyon), value);
        }

        public static bool gotLurkerKey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotLurkerKey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotLurkerKey), value);
        }

        public static float gMap_doorX
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.gMap_doorX));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.gMap_doorX), value);
        }

        public static float gMap_doorY
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.gMap_doorY));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.gMap_doorY), value);
        }

        public static string gMap_doorScene
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.gMap_doorScene));
            set => PlayerData.instance.SetString(nameof(PlayerData.gMap_doorScene), value);
        }

        public static string gMap_doorMapZone
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.gMap_doorMapZone));
            set => PlayerData.instance.SetString(nameof(PlayerData.gMap_doorMapZone), value);
        }

        public static float gMap_doorOriginOffsetX
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.gMap_doorOriginOffsetX));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.gMap_doorOriginOffsetX), value);
        }

        public static float gMap_doorOriginOffsetY
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.gMap_doorOriginOffsetY));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.gMap_doorOriginOffsetY), value);
        }

        public static float gMap_doorSceneWidth
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.gMap_doorSceneWidth));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.gMap_doorSceneWidth), value);
        }

        public static float gMap_doorSceneHeight
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.gMap_doorSceneHeight));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.gMap_doorSceneHeight), value);
        }

        public static int guardiansDefeated
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.guardiansDefeated));
           set => PlayerData.instance.SetInt(nameof(PlayerData.guardiansDefeated), value);
        }

        public static bool lurienDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.lurienDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.lurienDefeated), value);
        }

        public static bool hegemolDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hegemolDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hegemolDefeated), value);
        }

        public static bool monomonDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.monomonDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.monomonDefeated), value);
        }

        public static bool maskBrokenLurien
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskBrokenLurien));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskBrokenLurien), value);
        }

        public static bool maskBrokenHegemol
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskBrokenHegemol));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskBrokenHegemol), value);
        }

        public static bool maskBrokenMonomon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskBrokenMonomon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskBrokenMonomon), value);
        }

        public static int maskToBreak
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.maskToBreak));
           set => PlayerData.instance.SetInt(nameof(PlayerData.maskToBreak), value);
        }

        public static int elderbug
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.elderbug));
           set => PlayerData.instance.SetInt(nameof(PlayerData.elderbug), value);
        }

        public static bool metElderbug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metElderbug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metElderbug), value);
        }

        public static bool elderbugReintro
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugReintro));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugReintro), value);
        }

        public static int elderbugHistory
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.elderbugHistory));
           set => PlayerData.instance.SetInt(nameof(PlayerData.elderbugHistory), value);
        }

        public static bool elderbugHistory1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugHistory1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugHistory1), value);
        }

        public static bool elderbugHistory2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugHistory2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugHistory2), value);
        }

        public static bool elderbugHistory3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugHistory3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugHistory3), value);
        }

        public static bool elderbugSpeechSly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechSly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechSly), value);
        }

        public static bool elderbugSpeechStation
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechStation));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechStation), value);
        }

        public static bool elderbugSpeechEggTemple
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechEggTemple));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechEggTemple), value);
        }

        public static bool elderbugSpeechMapShop
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechMapShop));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechMapShop), value);
        }

        public static bool elderbugSpeechBretta
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechBretta));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechBretta), value);
        }

        public static bool elderbugSpeechJiji
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechJiji));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechJiji), value);
        }

        public static bool elderbugSpeechMinesLift
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechMinesLift));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechMinesLift), value);
        }

        public static bool elderbugSpeechKingsPass
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechKingsPass));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechKingsPass), value);
        }

        public static bool elderbugSpeechInfectedCrossroads
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechInfectedCrossroads));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechInfectedCrossroads), value);
        }

        public static bool elderbugSpeechFinalBossDoor
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugSpeechFinalBossDoor));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugSpeechFinalBossDoor), value);
        }

        public static bool elderbugRequestedFlower
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugRequestedFlower));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugRequestedFlower), value);
        }

        public static bool elderbugGaveFlower
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugGaveFlower));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugGaveFlower), value);
        }

        public static bool elderbugFirstCall
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugFirstCall));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugFirstCall), value);
        }

        public static bool metQuirrel
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metQuirrel));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metQuirrel), value);
        }

        public static int quirrelEggTemple
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.quirrelEggTemple));
           set => PlayerData.instance.SetInt(nameof(PlayerData.quirrelEggTemple), value);
        }

        public static int quirrelSlugShrine
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.quirrelSlugShrine));
           set => PlayerData.instance.SetInt(nameof(PlayerData.quirrelSlugShrine), value);
        }

        public static int quirrelRuins
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.quirrelRuins));
           set => PlayerData.instance.SetInt(nameof(PlayerData.quirrelRuins), value);
        }

        public static int quirrelMines
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.quirrelMines));
           set => PlayerData.instance.SetInt(nameof(PlayerData.quirrelMines), value);
        }

        public static bool quirrelLeftStation
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelLeftStation));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelLeftStation), value);
        }

        public static bool quirrelLeftEggTemple
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelLeftEggTemple));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelLeftEggTemple), value);
        }

        public static bool quirrelCityEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelCityEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelCityEncountered), value);
        }

        public static bool quirrelCityLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelCityLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelCityLeft), value);
        }

        public static bool quirrelMinesEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelMinesEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelMinesEncountered), value);
        }

        public static bool quirrelMinesLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelMinesLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelMinesLeft), value);
        }

        public static bool quirrelMantisEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelMantisEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelMantisEncountered), value);
        }

        public static bool enteredMantisLordArea
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.enteredMantisLordArea));
            set => PlayerData.instance.SetBool(nameof(PlayerData.enteredMantisLordArea), value);
        }

        public static bool visitedDeepnestSpa
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedDeepnestSpa));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedDeepnestSpa), value);
        }

        public static bool quirrelSpaReady
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelSpaReady));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelSpaReady), value);
        }

        public static bool quirrelSpaEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelSpaEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelSpaEncountered), value);
        }

        public static bool quirrelArchiveEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelArchiveEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelArchiveEncountered), value);
        }

        public static bool quirrelEpilogueCompleted
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.quirrelEpilogueCompleted));
            set => PlayerData.instance.SetBool(nameof(PlayerData.quirrelEpilogueCompleted), value);
        }

        public static bool metRelicDealer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metRelicDealer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metRelicDealer), value);
        }

        public static bool metRelicDealerShop
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metRelicDealerShop));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metRelicDealerShop), value);
        }

        public static bool marmOutside
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.marmOutside));
            set => PlayerData.instance.SetBool(nameof(PlayerData.marmOutside), value);
        }

        public static bool marmOutsideConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.marmOutsideConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.marmOutsideConvo), value);
        }

        public static bool marmConvo1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.marmConvo1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.marmConvo1), value);
        }

        public static bool marmConvo2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.marmConvo2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.marmConvo2), value);
        }

        public static bool marmConvo3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.marmConvo3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.marmConvo3), value);
        }

        public static bool marmConvoNailsmith
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.marmConvoNailsmith));
            set => PlayerData.instance.SetBool(nameof(PlayerData.marmConvoNailsmith), value);
        }

        public static int cornifer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.cornifer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.cornifer), value);
        }

        public static bool metCornifer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metCornifer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metCornifer), value);
        }

        public static bool corniferIntroduced
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corniferIntroduced));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corniferIntroduced), value);
        }

        public static bool corniferAtHome
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corniferAtHome));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corniferAtHome), value);
        }

        public static bool corn_crossroadsEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_crossroadsEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_crossroadsEncountered), value);
        }

        public static bool corn_crossroadsLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_crossroadsLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_crossroadsLeft), value);
        }

        public static bool corn_greenpathEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_greenpathEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_greenpathEncountered), value);
        }

        public static bool corn_greenpathLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_greenpathLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_greenpathLeft), value);
        }

        public static bool corn_fogCanyonEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_fogCanyonEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_fogCanyonEncountered), value);
        }

        public static bool corn_fogCanyonLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_fogCanyonLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_fogCanyonLeft), value);
        }

        public static bool corn_fungalWastesEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_fungalWastesEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_fungalWastesEncountered), value);
        }

        public static bool corn_fungalWastesLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_fungalWastesLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_fungalWastesLeft), value);
        }

        public static bool corn_cityEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_cityEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_cityEncountered), value);
        }

        public static bool corn_cityLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_cityLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_cityLeft), value);
        }

        public static bool corn_waterwaysEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_waterwaysEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_waterwaysEncountered), value);
        }

        public static bool corn_waterwaysLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_waterwaysLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_waterwaysLeft), value);
        }

        public static bool corn_minesEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_minesEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_minesEncountered), value);
        }

        public static bool corn_minesLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_minesLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_minesLeft), value);
        }

        public static bool corn_cliffsEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_cliffsEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_cliffsEncountered), value);
        }

        public static bool corn_cliffsLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_cliffsLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_cliffsLeft), value);
        }

        public static bool corn_deepnestEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_deepnestEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_deepnestEncountered), value);
        }

        public static bool corn_deepnestLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_deepnestLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_deepnestLeft), value);
        }

        public static bool corn_deepnestMet1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_deepnestMet1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_deepnestMet1), value);
        }

        public static bool corn_deepnestMet2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_deepnestMet2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_deepnestMet2), value);
        }

        public static bool corn_outskirtsEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_outskirtsEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_outskirtsEncountered), value);
        }

        public static bool corn_outskirtsLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_outskirtsLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_outskirtsLeft), value);
        }

        public static bool corn_royalGardensEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_royalGardensEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_royalGardensEncountered), value);
        }

        public static bool corn_royalGardensLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_royalGardensLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_royalGardensLeft), value);
        }

        public static bool corn_abyssEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_abyssEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_abyssEncountered), value);
        }

        public static bool corn_abyssLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.corn_abyssLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.corn_abyssLeft), value);
        }

        public static bool metIselda
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metIselda));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metIselda), value);
        }

        public static bool iseldaCorniferHomeConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.iseldaCorniferHomeConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.iseldaCorniferHomeConvo), value);
        }

        public static bool iseldaConvo1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.iseldaConvo1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.iseldaConvo1), value);
        }

        public static bool brettaRescued
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brettaRescued));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brettaRescued), value);
        }

        public static int brettaPosition
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.brettaPosition));
           set => PlayerData.instance.SetInt(nameof(PlayerData.brettaPosition), value);
        }

        public static int brettaState
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.brettaState));
           set => PlayerData.instance.SetInt(nameof(PlayerData.brettaState), value);
        }

        public static bool brettaSeenBench
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brettaSeenBench));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brettaSeenBench), value);
        }

        public static bool brettaSeenBed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brettaSeenBed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brettaSeenBed), value);
        }

        public static bool brettaSeenBenchDiary
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brettaSeenBenchDiary));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brettaSeenBenchDiary), value);
        }

        public static bool brettaSeenBedDiary
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brettaSeenBedDiary));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brettaSeenBedDiary), value);
        }

        public static bool brettaLeftTown
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brettaLeftTown));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brettaLeftTown), value);
        }

        public static bool slyRescued
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyRescued));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyRescued), value);
        }

        public static bool slyBeta
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyBeta));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyBeta), value);
        }

        public static bool metSlyShop
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metSlyShop));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metSlyShop), value);
        }

        public static bool gotSlyCharm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotSlyCharm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotSlyCharm), value);
        }

        public static bool slyShellFrag1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyShellFrag1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyShellFrag1), value);
        }

        public static bool slyShellFrag2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyShellFrag2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyShellFrag2), value);
        }

        public static bool slyShellFrag3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyShellFrag3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyShellFrag3), value);
        }

        public static bool slyShellFrag4
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyShellFrag4));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyShellFrag4), value);
        }

        public static bool slyVesselFrag1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyVesselFrag1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyVesselFrag1), value);
        }

        public static bool slyVesselFrag2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyVesselFrag2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyVesselFrag2), value);
        }

        public static bool slyVesselFrag3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyVesselFrag3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyVesselFrag3), value);
        }

        public static bool slyVesselFrag4
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyVesselFrag4));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyVesselFrag4), value);
        }

        public static bool slyNotch1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyNotch1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyNotch1), value);
        }

        public static bool slyNotch2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyNotch2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyNotch2), value);
        }

        public static bool slySimpleKey
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slySimpleKey));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slySimpleKey), value);
        }

        public static bool slyRancidEgg
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyRancidEgg));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyRancidEgg), value);
        }

        public static bool slyConvoNailArt
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyConvoNailArt));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyConvoNailArt), value);
        }

        public static bool slyConvoMapper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyConvoMapper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyConvoMapper), value);
        }

        public static bool slyConvoNailHoned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyConvoNailHoned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyConvoNailHoned), value);
        }

        public static bool jijiDoorUnlocked
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jijiDoorUnlocked));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jijiDoorUnlocked), value);
        }

        public static bool jijiMet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jijiMet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jijiMet), value);
        }

        public static bool jijiShadeOffered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jijiShadeOffered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jijiShadeOffered), value);
        }

        public static bool jijiShadeCharmConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jijiShadeCharmConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jijiShadeCharmConvo), value);
        }

        public static bool metJinn
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metJinn));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metJinn), value);
        }

        public static bool jinnConvo1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jinnConvo1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jinnConvo1), value);
        }

        public static bool jinnConvo2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jinnConvo2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jinnConvo2), value);
        }

        public static bool jinnConvo3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jinnConvo3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jinnConvo3), value);
        }

        public static bool jinnConvoKingBrand
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jinnConvoKingBrand));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jinnConvoKingBrand), value);
        }

        public static bool jinnConvoShadeCharm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jinnConvoShadeCharm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jinnConvoShadeCharm), value);
        }

        public static int jinnEggsSold
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.jinnEggsSold));
           set => PlayerData.instance.SetInt(nameof(PlayerData.jinnEggsSold), value);
        }

        public static int zote
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.zote));
           set => PlayerData.instance.SetInt(nameof(PlayerData.zote), value);
        }

        public static bool zoteRescuedBuzzer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.zoteRescuedBuzzer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.zoteRescuedBuzzer), value);
        }

        public static bool zoteDead
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.zoteDead));
            set => PlayerData.instance.SetBool(nameof(PlayerData.zoteDead), value);
        }

        public static int zoteDeathPos
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.zoteDeathPos));
           set => PlayerData.instance.SetInt(nameof(PlayerData.zoteDeathPos), value);
        }

        public static bool zoteSpokenCity
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.zoteSpokenCity));
            set => PlayerData.instance.SetBool(nameof(PlayerData.zoteSpokenCity), value);
        }

        public static bool zoteLeftCity
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.zoteLeftCity));
            set => PlayerData.instance.SetBool(nameof(PlayerData.zoteLeftCity), value);
        }

        public static bool zoteTrappedDeepnest
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.zoteTrappedDeepnest));
            set => PlayerData.instance.SetBool(nameof(PlayerData.zoteTrappedDeepnest), value);
        }

        public static bool zoteRescuedDeepnest
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.zoteRescuedDeepnest));
            set => PlayerData.instance.SetBool(nameof(PlayerData.zoteRescuedDeepnest), value);
        }

        public static bool zoteDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.zoteDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.zoteDefeated), value);
        }

        public static bool zoteSpokenColosseum
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.zoteSpokenColosseum));
            set => PlayerData.instance.SetBool(nameof(PlayerData.zoteSpokenColosseum), value);
        }

        public static int zotePrecept
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.zotePrecept));
           set => PlayerData.instance.SetInt(nameof(PlayerData.zotePrecept), value);
        }

        public static int zoteTownConvo
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.zoteTownConvo));
           set => PlayerData.instance.SetInt(nameof(PlayerData.zoteTownConvo), value);
        }

        public static int shaman
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.shaman));
           set => PlayerData.instance.SetInt(nameof(PlayerData.shaman), value);
        }

        public static bool shamanScreamConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.shamanScreamConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.shamanScreamConvo), value);
        }

        public static bool shamanQuakeConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.shamanQuakeConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.shamanQuakeConvo), value);
        }

        public static bool shamanFireball2Convo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.shamanFireball2Convo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.shamanFireball2Convo), value);
        }

        public static bool shamanScream2Convo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.shamanScream2Convo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.shamanScream2Convo), value);
        }

        public static bool shamanQuake2Convo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.shamanQuake2Convo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.shamanQuake2Convo), value);
        }

        public static bool metMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metMiner), value);
        }

        public static int miner
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.miner));
           set => PlayerData.instance.SetInt(nameof(PlayerData.miner), value);
        }

        public static int minerEarly
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.minerEarly));
           set => PlayerData.instance.SetInt(nameof(PlayerData.minerEarly), value);
        }

        public static int hornetGreenpath
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.hornetGreenpath));
           set => PlayerData.instance.SetInt(nameof(PlayerData.hornetGreenpath), value);
        }

        public static int hornetFung
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.hornetFung));
           set => PlayerData.instance.SetInt(nameof(PlayerData.hornetFung), value);
        }

        public static bool hornet_f19
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hornet_f19));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hornet_f19), value);
        }

        public static bool hornetFountainEncounter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hornetFountainEncounter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hornetFountainEncounter), value);
        }

        public static bool hornetCityBridge_ready
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hornetCityBridge_ready));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hornetCityBridge_ready), value);
        }

        public static bool hornetCityBridge_completed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hornetCityBridge_completed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hornetCityBridge_completed), value);
        }

        public static bool hornetAbyssEncounter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hornetAbyssEncounter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hornetAbyssEncounter), value);
        }

        public static bool hornetDenEncounter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hornetDenEncounter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hornetDenEncounter), value);
        }

        public static bool metMoth
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metMoth));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metMoth), value);
        }

        public static bool ignoredMoth
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.ignoredMoth));
            set => PlayerData.instance.SetBool(nameof(PlayerData.ignoredMoth), value);
        }

        public static bool gladeDoorOpened
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gladeDoorOpened));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gladeDoorOpened), value);
        }

        public static bool mothDeparted
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mothDeparted));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mothDeparted), value);
        }

        public static bool completedRGDreamPlant
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.completedRGDreamPlant));
            set => PlayerData.instance.SetBool(nameof(PlayerData.completedRGDreamPlant), value);
        }

        public static bool dreamReward1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward1), value);
        }

        public static bool dreamReward2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward2), value);
        }

        public static bool dreamReward3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward3), value);
        }

        public static bool dreamReward4
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward4));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward4), value);
        }

        public static bool dreamReward5
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward5));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward5), value);
        }

        public static bool dreamReward5b
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward5b));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward5b), value);
        }

        public static bool dreamReward6
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward6));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward6), value);
        }

        public static bool dreamReward7
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward7));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward7), value);
        }

        public static bool dreamReward8
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward8));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward8), value);
        }

        public static bool dreamReward9
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamReward9));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamReward9), value);
        }

        public static bool dreamMothConvo1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamMothConvo1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamMothConvo1), value);
        }

        public static bool bankerAccountPurchased
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bankerAccountPurchased));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bankerAccountPurchased), value);
        }

        public static bool metBanker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metBanker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metBanker), value);
        }

        public static int bankerBalance
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.bankerBalance));
           set => PlayerData.instance.SetInt(nameof(PlayerData.bankerBalance), value);
        }

        public static bool bankerDeclined
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bankerDeclined));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bankerDeclined), value);
        }

        public static bool bankerTheftCheck
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bankerTheftCheck));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bankerTheftCheck), value);
        }

        public static int bankerTheft
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.bankerTheft));
           set => PlayerData.instance.SetInt(nameof(PlayerData.bankerTheft), value);
        }

        public static bool bankerSpaMet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bankerSpaMet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bankerSpaMet), value);
        }

        public static bool metGiraffe
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metGiraffe));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metGiraffe), value);
        }

        public static bool metCharmSlug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metCharmSlug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metCharmSlug), value);
        }

        public static bool salubraNotch1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.salubraNotch1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.salubraNotch1), value);
        }

        public static bool salubraNotch2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.salubraNotch2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.salubraNotch2), value);
        }

        public static bool salubraNotch3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.salubraNotch3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.salubraNotch3), value);
        }

        public static bool salubraNotch4
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.salubraNotch4));
            set => PlayerData.instance.SetBool(nameof(PlayerData.salubraNotch4), value);
        }

        public static bool salubraBlessing
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.salubraBlessing));
            set => PlayerData.instance.SetBool(nameof(PlayerData.salubraBlessing), value);
        }

        public static bool salubraConvoCombo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.salubraConvoCombo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.salubraConvoCombo), value);
        }

        public static bool salubraConvoOvercharm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.salubraConvoOvercharm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.salubraConvoOvercharm), value);
        }

        public static bool salubraConvoTruth
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.salubraConvoTruth));
            set => PlayerData.instance.SetBool(nameof(PlayerData.salubraConvoTruth), value);
        }

        public static bool cultistTransformed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.cultistTransformed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.cultistTransformed), value);
        }

        public static bool metNailsmith
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metNailsmith));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metNailsmith), value);
        }

        public static int nailSmithUpgrades
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.nailSmithUpgrades));
           set => PlayerData.instance.SetInt(nameof(PlayerData.nailSmithUpgrades), value);
        }

        public static bool honedNail
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.honedNail));
            set => PlayerData.instance.SetBool(nameof(PlayerData.honedNail), value);
        }

        public static bool nailsmithCliff
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nailsmithCliff));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nailsmithCliff), value);
        }

        public static bool nailsmithKilled
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nailsmithKilled));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nailsmithKilled), value);
        }

        public static bool nailsmithSpared
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nailsmithSpared));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nailsmithSpared), value);
        }

        public static bool nailsmithKillSpeech
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nailsmithKillSpeech));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nailsmithKillSpeech), value);
        }

        public static bool nailsmithSheo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nailsmithSheo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nailsmithSheo), value);
        }

        public static bool nailsmithConvoArt
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nailsmithConvoArt));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nailsmithConvoArt), value);
        }

        public static bool metNailmasterMato
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metNailmasterMato));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metNailmasterMato), value);
        }

        public static bool metNailmasterSheo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metNailmasterSheo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metNailmasterSheo), value);
        }

        public static bool metNailmasterOro
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metNailmasterOro));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metNailmasterOro), value);
        }

        public static bool matoConvoSheo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.matoConvoSheo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.matoConvoSheo), value);
        }

        public static bool matoConvoOro
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.matoConvoOro));
            set => PlayerData.instance.SetBool(nameof(PlayerData.matoConvoOro), value);
        }

        public static bool matoConvoSly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.matoConvoSly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.matoConvoSly), value);
        }

        public static bool sheoConvoMato
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.sheoConvoMato));
            set => PlayerData.instance.SetBool(nameof(PlayerData.sheoConvoMato), value);
        }

        public static bool sheoConvoOro
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.sheoConvoOro));
            set => PlayerData.instance.SetBool(nameof(PlayerData.sheoConvoOro), value);
        }

        public static bool sheoConvoSly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.sheoConvoSly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.sheoConvoSly), value);
        }

        public static bool sheoConvoNailsmith
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.sheoConvoNailsmith));
            set => PlayerData.instance.SetBool(nameof(PlayerData.sheoConvoNailsmith), value);
        }

        public static bool oroConvoSheo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.oroConvoSheo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.oroConvoSheo), value);
        }

        public static bool oroConvoMato
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.oroConvoMato));
            set => PlayerData.instance.SetBool(nameof(PlayerData.oroConvoMato), value);
        }

        public static bool oroConvoSly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.oroConvoSly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.oroConvoSly), value);
        }

        public static bool hunterRoared
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hunterRoared));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hunterRoared), value);
        }

        public static bool metHunter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metHunter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metHunter), value);
        }

        public static bool hunterRewardOffered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hunterRewardOffered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hunterRewardOffered), value);
        }

        public static bool huntersMarkOffered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.huntersMarkOffered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.huntersMarkOffered), value);
        }

        public static bool hasHuntersMark
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasHuntersMark));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasHuntersMark), value);
        }

        public static bool metLegEater
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metLegEater));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metLegEater), value);
        }

        public static bool paidLegEater
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.paidLegEater));
            set => PlayerData.instance.SetBool(nameof(PlayerData.paidLegEater), value);
        }

        public static bool refusedLegEater
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.refusedLegEater));
            set => PlayerData.instance.SetBool(nameof(PlayerData.refusedLegEater), value);
        }

        public static bool legEaterConvo1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.legEaterConvo1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.legEaterConvo1), value);
        }

        public static bool legEaterConvo2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.legEaterConvo2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.legEaterConvo2), value);
        }

        public static bool legEaterConvo3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.legEaterConvo3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.legEaterConvo3), value);
        }

        public static bool legEaterBrokenConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.legEaterBrokenConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.legEaterBrokenConvo), value);
        }

        public static bool legEaterDungConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.legEaterDungConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.legEaterDungConvo), value);
        }

        public static bool legEaterInfectedCrossroadConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.legEaterInfectedCrossroadConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.legEaterInfectedCrossroadConvo), value);
        }

        public static bool legEaterBoughtConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.legEaterBoughtConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.legEaterBoughtConvo), value);
        }

        public static bool legEaterGoldConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.legEaterGoldConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.legEaterGoldConvo), value);
        }

        public static bool legEaterLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.legEaterLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.legEaterLeft), value);
        }

        public static bool tukMet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tukMet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tukMet), value);
        }

        public static int tukEggPrice
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.tukEggPrice));
           set => PlayerData.instance.SetInt(nameof(PlayerData.tukEggPrice), value);
        }

        public static bool tukDungEgg
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tukDungEgg));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tukDungEgg), value);
        }

        public static bool metEmilitia
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metEmilitia));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metEmilitia), value);
        }

        public static bool emilitiaKingsBrandConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.emilitiaKingsBrandConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.emilitiaKingsBrandConvo), value);
        }

        public static bool metCloth
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metCloth));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metCloth), value);
        }

        public static bool clothEnteredTramRoom
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.clothEnteredTramRoom));
            set => PlayerData.instance.SetBool(nameof(PlayerData.clothEnteredTramRoom), value);
        }

        public static bool savedCloth
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.savedCloth));
            set => PlayerData.instance.SetBool(nameof(PlayerData.savedCloth), value);
        }

        public static bool clothEncounteredQueensGarden
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.clothEncounteredQueensGarden));
            set => PlayerData.instance.SetBool(nameof(PlayerData.clothEncounteredQueensGarden), value);
        }

        public static bool clothKilled
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.clothKilled));
            set => PlayerData.instance.SetBool(nameof(PlayerData.clothKilled), value);
        }

        public static bool clothInTown
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.clothInTown));
            set => PlayerData.instance.SetBool(nameof(PlayerData.clothInTown), value);
        }

        public static bool clothLeftTown
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.clothLeftTown));
            set => PlayerData.instance.SetBool(nameof(PlayerData.clothLeftTown), value);
        }

        public static bool clothGhostSpoken
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.clothGhostSpoken));
            set => PlayerData.instance.SetBool(nameof(PlayerData.clothGhostSpoken), value);
        }

        public static bool bigCatHitTail
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bigCatHitTail));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bigCatHitTail), value);
        }

        public static bool bigCatHitTailConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bigCatHitTailConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bigCatHitTailConvo), value);
        }

        public static bool bigCatMeet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bigCatMeet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bigCatMeet), value);
        }

        public static bool bigCatTalk1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bigCatTalk1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bigCatTalk1), value);
        }

        public static bool bigCatTalk2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bigCatTalk2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bigCatTalk2), value);
        }

        public static bool bigCatTalk3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bigCatTalk3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bigCatTalk3), value);
        }

        public static bool bigCatKingsBrandConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bigCatKingsBrandConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bigCatKingsBrandConvo), value);
        }

        public static bool bigCatShadeConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bigCatShadeConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bigCatShadeConvo), value);
        }

        public static bool tisoEncounteredTown
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tisoEncounteredTown));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tisoEncounteredTown), value);
        }

        public static bool tisoEncounteredBench
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tisoEncounteredBench));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tisoEncounteredBench), value);
        }

        public static bool tisoEncounteredLake
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tisoEncounteredLake));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tisoEncounteredLake), value);
        }

        public static bool tisoEncounteredColosseum
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tisoEncounteredColosseum));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tisoEncounteredColosseum), value);
        }

        public static bool tisoDead
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tisoDead));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tisoDead), value);
        }

        public static bool tisoShieldConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tisoShieldConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tisoShieldConvo), value);
        }

        public static int mossCultist
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.mossCultist));
           set => PlayerData.instance.SetInt(nameof(PlayerData.mossCultist), value);
        }

        public static bool maskmakerMet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskmakerMet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskmakerMet), value);
        }

        public static bool maskmakerConvo1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskmakerConvo1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskmakerConvo1), value);
        }

        public static bool maskmakerConvo2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskmakerConvo2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskmakerConvo2), value);
        }

        public static bool maskmakerUnmasked1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskmakerUnmasked1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskmakerUnmasked1), value);
        }

        public static bool maskmakerUnmasked2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskmakerUnmasked2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskmakerUnmasked2), value);
        }

        public static bool maskmakerShadowDash
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskmakerShadowDash));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskmakerShadowDash), value);
        }

        public static bool maskmakerKingsBrand
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.maskmakerKingsBrand));
            set => PlayerData.instance.SetBool(nameof(PlayerData.maskmakerKingsBrand), value);
        }

        public static bool dungDefenderConvo1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderConvo1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderConvo1), value);
        }

        public static bool dungDefenderConvo2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderConvo2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderConvo2), value);
        }

        public static bool dungDefenderConvo3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderConvo3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderConvo3), value);
        }

        public static bool dungDefenderCharmConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderCharmConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderCharmConvo), value);
        }

        public static bool dungDefenderIsmaConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderIsmaConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderIsmaConvo), value);
        }

        public static bool dungDefenderAwoken
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderAwoken));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderAwoken), value);
        }

        public static bool dungDefenderLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderLeft), value);
        }

        public static bool dungDefenderAwakeConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderAwakeConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderAwakeConvo), value);
        }

        public static bool midwifeMet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.midwifeMet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.midwifeMet), value);
        }

        public static bool midwifeConvo1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.midwifeConvo1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.midwifeConvo1), value);
        }

        public static bool midwifeConvo2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.midwifeConvo2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.midwifeConvo2), value);
        }

        public static bool metQueen
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metQueen));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metQueen), value);
        }

        public static bool queenTalk1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queenTalk1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queenTalk1), value);
        }

        public static bool queenTalk2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queenTalk2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queenTalk2), value);
        }

        public static bool queenDung1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queenDung1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queenDung1), value);
        }

        public static bool queenDung2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queenDung2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queenDung2), value);
        }

        public static bool queenHornet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queenHornet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queenHornet), value);
        }

        public static bool queenTalkExtra
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queenTalkExtra));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queenTalkExtra), value);
        }

        public static bool gotQueenFragment
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotQueenFragment));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotQueenFragment), value);
        }

        public static bool queenConvo_grimm1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queenConvo_grimm1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queenConvo_grimm1), value);
        }

        public static bool queenConvo_grimm2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queenConvo_grimm2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queenConvo_grimm2), value);
        }

        public static bool gotKingFragment
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotKingFragment));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotKingFragment), value);
        }

        public static bool metXun
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metXun));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metXun), value);
        }

        public static bool xunFailedConvo1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.xunFailedConvo1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.xunFailedConvo1), value);
        }

        public static bool xunFailedConvo2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.xunFailedConvo2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.xunFailedConvo2), value);
        }

        public static bool xunFlowerBroken
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.xunFlowerBroken));
            set => PlayerData.instance.SetBool(nameof(PlayerData.xunFlowerBroken), value);
        }

        public static int xunFlowerBrokeTimes
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.xunFlowerBrokeTimes));
           set => PlayerData.instance.SetInt(nameof(PlayerData.xunFlowerBrokeTimes), value);
        }

        public static bool xunFlowerGiven
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.xunFlowerGiven));
            set => PlayerData.instance.SetBool(nameof(PlayerData.xunFlowerGiven), value);
        }

        public static bool xunRewardGiven
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.xunRewardGiven));
            set => PlayerData.instance.SetBool(nameof(PlayerData.xunRewardGiven), value);
        }

        public static int menderState
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.menderState));
           set => PlayerData.instance.SetInt(nameof(PlayerData.menderState), value);
        }

        public static bool menderSignBroken
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.menderSignBroken));
            set => PlayerData.instance.SetBool(nameof(PlayerData.menderSignBroken), value);
        }

        public static bool allBelieverTabletsDestroyed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.allBelieverTabletsDestroyed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.allBelieverTabletsDestroyed), value);
        }

        public static int mrMushroomState
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.mrMushroomState));
           set => PlayerData.instance.SetInt(nameof(PlayerData.mrMushroomState), value);
        }

        public static bool openedMapperShop
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedMapperShop));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedMapperShop), value);
        }

        public static bool openedSlyShop
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedSlyShop));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedSlyShop), value);
        }

        public static bool metStag
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metStag));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metStag), value);
        }

        public static bool travelling
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.travelling));
            set => PlayerData.instance.SetBool(nameof(PlayerData.travelling), value);
        }

        public static int stagPosition
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.stagPosition));
           set => PlayerData.instance.SetInt(nameof(PlayerData.stagPosition), value);
        }

        public static int stationsOpened
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.stationsOpened));
           set => PlayerData.instance.SetInt(nameof(PlayerData.stationsOpened), value);
        }

        public static bool stagConvoTram
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.stagConvoTram));
            set => PlayerData.instance.SetBool(nameof(PlayerData.stagConvoTram), value);
        }

        public static bool stagConvoTiso
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.stagConvoTiso));
            set => PlayerData.instance.SetBool(nameof(PlayerData.stagConvoTiso), value);
        }

        public static bool stagRemember1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.stagRemember1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.stagRemember1), value);
        }

        public static bool stagRemember2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.stagRemember2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.stagRemember2), value);
        }

        public static bool stagRemember3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.stagRemember3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.stagRemember3), value);
        }

        public static bool stagEggInspected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.stagEggInspected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.stagEggInspected), value);
        }

        public static bool stagHopeConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.stagHopeConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.stagHopeConvo), value);
        }

        public static string nextScene
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.nextScene));
            set => PlayerData.instance.SetString(nameof(PlayerData.nextScene), value);
        }

        public static bool littleFoolMet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.littleFoolMet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.littleFoolMet), value);
        }

        public static bool ranAway
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.ranAway));
            set => PlayerData.instance.SetBool(nameof(PlayerData.ranAway), value);
        }

        public static bool seenColosseumTitle
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.seenColosseumTitle));
            set => PlayerData.instance.SetBool(nameof(PlayerData.seenColosseumTitle), value);
        }

        public static bool colosseumBronzeOpened
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.colosseumBronzeOpened));
            set => PlayerData.instance.SetBool(nameof(PlayerData.colosseumBronzeOpened), value);
        }

        public static bool colosseumBronzeCompleted
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.colosseumBronzeCompleted));
            set => PlayerData.instance.SetBool(nameof(PlayerData.colosseumBronzeCompleted), value);
        }

        public static bool colosseumSilverOpened
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.colosseumSilverOpened));
            set => PlayerData.instance.SetBool(nameof(PlayerData.colosseumSilverOpened), value);
        }

        public static bool colosseumSilverCompleted
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.colosseumSilverCompleted));
            set => PlayerData.instance.SetBool(nameof(PlayerData.colosseumSilverCompleted), value);
        }

        public static bool colosseumGoldOpened
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.colosseumGoldOpened));
            set => PlayerData.instance.SetBool(nameof(PlayerData.colosseumGoldOpened), value);
        }

        public static bool colosseumGoldCompleted
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.colosseumGoldCompleted));
            set => PlayerData.instance.SetBool(nameof(PlayerData.colosseumGoldCompleted), value);
        }

        public static bool openedTown
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedTown));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedTown), value);
        }

        public static bool openedTownBuilding
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedTownBuilding));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedTownBuilding), value);
        }

        public static bool openedCrossroads
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedCrossroads));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedCrossroads), value);
        }

        public static bool openedGreenpath
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedGreenpath));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedGreenpath), value);
        }

        public static bool openedRuins1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedRuins1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedRuins1), value);
        }

        public static bool openedRuins2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedRuins2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedRuins2), value);
        }

        public static bool openedFungalWastes
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedFungalWastes));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedFungalWastes), value);
        }

        public static bool openedRoyalGardens
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedRoyalGardens));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedRoyalGardens), value);
        }

        public static bool openedRestingGrounds
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedRestingGrounds));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedRestingGrounds), value);
        }

        public static bool openedDeepnest
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedDeepnest));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedDeepnest), value);
        }

        public static bool openedStagNest
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedStagNest));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedStagNest), value);
        }

        public static bool openedHiddenStation
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedHiddenStation));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedHiddenStation), value);
        }

        public static string dreamReturnScene
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.dreamReturnScene));
            set => PlayerData.instance.SetString(nameof(PlayerData.dreamReturnScene), value);
        }

        public static int charmSlots
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmSlots));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmSlots), value);
        }

        public static int charmSlotsFilled
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmSlotsFilled));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmSlotsFilled), value);
        }

        public static bool hasCharm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasCharm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasCharm), value);
        }

        public static List<System.Int32> equippedCharms
        {
            get => PlayerData.instance.GetVariable<List<System.Int32>>(nameof(PlayerData.equippedCharms));
            set => PlayerData.instance.SetVariable<List<System.Int32>>(nameof(PlayerData.equippedCharms), value);
        }

        public static bool charmBenchMsg
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.charmBenchMsg));
            set => PlayerData.instance.SetBool(nameof(PlayerData.charmBenchMsg), value);
        }

        public static int charmsOwned
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmsOwned));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmsOwned), value);
        }

        public static bool canOvercharm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.canOvercharm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.canOvercharm), value);
        }

        public static bool overcharmed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.overcharmed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.overcharmed), value);
        }

        public static bool gotCharm_1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_1), value);
        }

        public static bool equippedCharm_1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_1), value);
        }

        public static int charmCost_1
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_1));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_1), value);
        }

        public static bool newCharm_1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_1), value);
        }

        public static bool gotCharm_2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_2), value);
        }

        public static bool equippedCharm_2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_2), value);
        }

        public static int charmCost_2
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_2));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_2), value);
        }

        public static bool newCharm_2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_2), value);
        }

        public static bool gotCharm_3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_3), value);
        }

        public static bool equippedCharm_3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_3), value);
        }

        public static int charmCost_3
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_3));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_3), value);
        }

        public static bool newCharm_3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_3), value);
        }

        public static bool gotCharm_4
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_4));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_4), value);
        }

        public static bool equippedCharm_4
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_4));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_4), value);
        }

        public static int charmCost_4
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_4));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_4), value);
        }

        public static bool newCharm_4
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_4));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_4), value);
        }

        public static bool gotCharm_5
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_5));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_5), value);
        }

        public static bool equippedCharm_5
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_5));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_5), value);
        }

        public static int charmCost_5
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_5));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_5), value);
        }

        public static bool newCharm_5
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_5));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_5), value);
        }

        public static bool gotCharm_6
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_6));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_6), value);
        }

        public static bool equippedCharm_6
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_6));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_6), value);
        }

        public static int charmCost_6
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_6));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_6), value);
        }

        public static bool newCharm_6
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_6));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_6), value);
        }

        public static bool gotCharm_7
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_7));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_7), value);
        }

        public static bool equippedCharm_7
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_7));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_7), value);
        }

        public static int charmCost_7
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_7));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_7), value);
        }

        public static bool newCharm_7
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_7));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_7), value);
        }

        public static bool gotCharm_8
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_8));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_8), value);
        }

        public static bool equippedCharm_8
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_8));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_8), value);
        }

        public static int charmCost_8
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_8));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_8), value);
        }

        public static bool newCharm_8
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_8));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_8), value);
        }

        public static bool gotCharm_9
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_9));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_9), value);
        }

        public static bool equippedCharm_9
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_9));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_9), value);
        }

        public static int charmCost_9
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_9));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_9), value);
        }

        public static bool newCharm_9
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_9));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_9), value);
        }

        public static bool gotCharm_10
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_10));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_10), value);
        }

        public static bool equippedCharm_10
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_10));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_10), value);
        }

        public static int charmCost_10
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_10));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_10), value);
        }

        public static bool newCharm_10
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_10));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_10), value);
        }

        public static bool gotCharm_11
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_11));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_11), value);
        }

        public static bool equippedCharm_11
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_11));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_11), value);
        }

        public static int charmCost_11
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_11));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_11), value);
        }

        public static bool newCharm_11
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_11));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_11), value);
        }

        public static bool gotCharm_12
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_12));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_12), value);
        }

        public static bool equippedCharm_12
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_12));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_12), value);
        }

        public static int charmCost_12
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_12));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_12), value);
        }

        public static bool newCharm_12
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_12));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_12), value);
        }

        public static bool gotCharm_13
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_13));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_13), value);
        }

        public static bool equippedCharm_13
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_13));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_13), value);
        }

        public static int charmCost_13
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_13));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_13), value);
        }

        public static bool newCharm_13
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_13));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_13), value);
        }

        public static bool gotCharm_14
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_14));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_14), value);
        }

        public static bool equippedCharm_14
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_14));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_14), value);
        }

        public static int charmCost_14
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_14));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_14), value);
        }

        public static bool newCharm_14
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_14));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_14), value);
        }

        public static bool gotCharm_15
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_15));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_15), value);
        }

        public static bool equippedCharm_15
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_15));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_15), value);
        }

        public static int charmCost_15
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_15));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_15), value);
        }

        public static bool newCharm_15
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_15));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_15), value);
        }

        public static bool gotCharm_16
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_16));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_16), value);
        }

        public static bool equippedCharm_16
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_16));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_16), value);
        }

        public static int charmCost_16
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_16));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_16), value);
        }

        public static bool newCharm_16
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_16));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_16), value);
        }

        public static bool gotCharm_17
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_17));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_17), value);
        }

        public static bool equippedCharm_17
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_17));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_17), value);
        }

        public static int charmCost_17
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_17));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_17), value);
        }

        public static bool newCharm_17
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_17));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_17), value);
        }

        public static bool gotCharm_18
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_18));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_18), value);
        }

        public static bool equippedCharm_18
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_18));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_18), value);
        }

        public static int charmCost_18
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_18));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_18), value);
        }

        public static bool newCharm_18
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_18));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_18), value);
        }

        public static bool gotCharm_19
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_19));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_19), value);
        }

        public static bool equippedCharm_19
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_19));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_19), value);
        }

        public static int charmCost_19
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_19));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_19), value);
        }

        public static bool newCharm_19
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_19));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_19), value);
        }

        public static bool gotCharm_20
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_20));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_20), value);
        }

        public static bool equippedCharm_20
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_20));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_20), value);
        }

        public static int charmCost_20
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_20));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_20), value);
        }

        public static bool newCharm_20
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_20));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_20), value);
        }

        public static bool gotCharm_21
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_21));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_21), value);
        }

        public static bool equippedCharm_21
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_21));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_21), value);
        }

        public static int charmCost_21
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_21));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_21), value);
        }

        public static bool newCharm_21
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_21));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_21), value);
        }

        public static bool gotCharm_22
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_22));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_22), value);
        }

        public static bool equippedCharm_22
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_22));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_22), value);
        }

        public static int charmCost_22
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_22));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_22), value);
        }

        public static bool newCharm_22
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_22));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_22), value);
        }

        public static bool gotCharm_23
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_23));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_23), value);
        }

        public static bool equippedCharm_23
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_23));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_23), value);
        }

        public static bool brokenCharm_23
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brokenCharm_23));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brokenCharm_23), value);
        }

        public static int charmCost_23
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_23));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_23), value);
        }

        public static bool newCharm_23
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_23));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_23), value);
        }

        public static bool gotCharm_24
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_24));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_24), value);
        }

        public static bool equippedCharm_24
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_24));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_24), value);
        }

        public static bool brokenCharm_24
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brokenCharm_24));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brokenCharm_24), value);
        }

        public static int charmCost_24
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_24));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_24), value);
        }

        public static bool newCharm_24
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_24));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_24), value);
        }

        public static bool gotCharm_25
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_25));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_25), value);
        }

        public static bool equippedCharm_25
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_25));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_25), value);
        }

        public static bool brokenCharm_25
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brokenCharm_25));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brokenCharm_25), value);
        }

        public static int charmCost_25
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_25));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_25), value);
        }

        public static bool newCharm_25
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_25));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_25), value);
        }

        public static bool gotCharm_26
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_26));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_26), value);
        }

        public static bool equippedCharm_26
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_26));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_26), value);
        }

        public static int charmCost_26
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_26));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_26), value);
        }

        public static bool newCharm_26
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_26));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_26), value);
        }

        public static bool gotCharm_27
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_27));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_27), value);
        }

        public static bool equippedCharm_27
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_27));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_27), value);
        }

        public static int charmCost_27
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_27));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_27), value);
        }

        public static bool newCharm_27
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_27));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_27), value);
        }

        public static bool gotCharm_28
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_28));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_28), value);
        }

        public static bool equippedCharm_28
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_28));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_28), value);
        }

        public static int charmCost_28
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_28));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_28), value);
        }

        public static bool newCharm_28
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_28));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_28), value);
        }

        public static bool gotCharm_29
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_29));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_29), value);
        }

        public static bool equippedCharm_29
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_29));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_29), value);
        }

        public static int charmCost_29
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_29));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_29), value);
        }

        public static bool newCharm_29
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_29));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_29), value);
        }

        public static bool gotCharm_30
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_30));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_30), value);
        }

        public static bool equippedCharm_30
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_30));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_30), value);
        }

        public static int charmCost_30
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_30));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_30), value);
        }

        public static bool newCharm_30
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_30));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_30), value);
        }

        public static bool gotCharm_31
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_31));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_31), value);
        }

        public static bool equippedCharm_31
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_31));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_31), value);
        }

        public static int charmCost_31
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_31));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_31), value);
        }

        public static bool newCharm_31
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_31));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_31), value);
        }

        public static bool gotCharm_32
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_32));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_32), value);
        }

        public static bool equippedCharm_32
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_32));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_32), value);
        }

        public static int charmCost_32
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_32));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_32), value);
        }

        public static bool newCharm_32
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_32));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_32), value);
        }

        public static bool gotCharm_33
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_33));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_33), value);
        }

        public static bool equippedCharm_33
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_33));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_33), value);
        }

        public static int charmCost_33
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_33));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_33), value);
        }

        public static bool newCharm_33
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_33));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_33), value);
        }

        public static bool gotCharm_34
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_34));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_34), value);
        }

        public static bool equippedCharm_34
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_34));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_34), value);
        }

        public static int charmCost_34
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_34));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_34), value);
        }

        public static bool newCharm_34
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_34));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_34), value);
        }

        public static bool gotCharm_35
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_35));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_35), value);
        }

        public static bool equippedCharm_35
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_35));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_35), value);
        }

        public static int charmCost_35
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_35));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_35), value);
        }

        public static bool newCharm_35
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_35));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_35), value);
        }

        public static bool gotCharm_36
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_36));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_36), value);
        }

        public static bool equippedCharm_36
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_36));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_36), value);
        }

        public static int charmCost_36
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_36));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_36), value);
        }

        public static bool newCharm_36
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_36));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_36), value);
        }

        public static bool gotCharm_37
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_37));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_37), value);
        }

        public static bool equippedCharm_37
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_37));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_37), value);
        }

        public static int charmCost_37
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_37));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_37), value);
        }

        public static bool newCharm_37
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_37));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_37), value);
        }

        public static bool gotCharm_38
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_38));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_38), value);
        }

        public static bool equippedCharm_38
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_38));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_38), value);
        }

        public static int charmCost_38
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_38));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_38), value);
        }

        public static bool newCharm_38
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_38));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_38), value);
        }

        public static bool gotCharm_39
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_39));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_39), value);
        }

        public static bool equippedCharm_39
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_39));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_39), value);
        }

        public static int charmCost_39
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_39));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_39), value);
        }

        public static bool newCharm_39
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_39));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_39), value);
        }

        public static bool gotCharm_40
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotCharm_40));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotCharm_40), value);
        }

        public static bool equippedCharm_40
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.equippedCharm_40));
            set => PlayerData.instance.SetBool(nameof(PlayerData.equippedCharm_40), value);
        }

        public static int charmCost_40
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.charmCost_40));
           set => PlayerData.instance.SetInt(nameof(PlayerData.charmCost_40), value);
        }

        public static bool newCharm_40
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newCharm_40));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newCharm_40), value);
        }

        public static bool fragileHealth_unbreakable
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.fragileHealth_unbreakable));
            set => PlayerData.instance.SetBool(nameof(PlayerData.fragileHealth_unbreakable), value);
        }

        public static bool fragileGreed_unbreakable
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.fragileGreed_unbreakable));
            set => PlayerData.instance.SetBool(nameof(PlayerData.fragileGreed_unbreakable), value);
        }

        public static bool fragileStrength_unbreakable
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.fragileStrength_unbreakable));
            set => PlayerData.instance.SetBool(nameof(PlayerData.fragileStrength_unbreakable), value);
        }

        public static int royalCharmState
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.royalCharmState));
           set => PlayerData.instance.SetInt(nameof(PlayerData.royalCharmState), value);
        }

        public static bool hasJournal
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasJournal));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasJournal), value);
        }

        public static int lastJournalItem
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.lastJournalItem));
           set => PlayerData.instance.SetInt(nameof(PlayerData.lastJournalItem), value);
        }

        public static bool killedDummy
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedDummy));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedDummy), value);
        }

        public static int killsDummy
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsDummy));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsDummy), value);
        }

        public static bool newDataDummy
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataDummy));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataDummy), value);
        }

        public static bool seenJournalMsg
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.seenJournalMsg));
            set => PlayerData.instance.SetBool(nameof(PlayerData.seenJournalMsg), value);
        }

        public static bool seenHunterMsg
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.seenHunterMsg));
            set => PlayerData.instance.SetBool(nameof(PlayerData.seenHunterMsg), value);
        }

        public static bool fillJournal
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.fillJournal));
            set => PlayerData.instance.SetBool(nameof(PlayerData.fillJournal), value);
        }

        public static int journalEntriesCompleted
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.journalEntriesCompleted));
           set => PlayerData.instance.SetInt(nameof(PlayerData.journalEntriesCompleted), value);
        }

        public static int journalNotesCompleted
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.journalNotesCompleted));
           set => PlayerData.instance.SetInt(nameof(PlayerData.journalNotesCompleted), value);
        }

        public static int journalEntriesTotal
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.journalEntriesTotal));
           set => PlayerData.instance.SetInt(nameof(PlayerData.journalEntriesTotal), value);
        }

        public static bool killedCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedCrawler), value);
        }

        public static int killsCrawler
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsCrawler));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsCrawler), value);
        }

        public static bool newDataCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataCrawler), value);
        }

        public static bool killedBuzzer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBuzzer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBuzzer), value);
        }

        public static int killsBuzzer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBuzzer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBuzzer), value);
        }

        public static bool newDataBuzzer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBuzzer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBuzzer), value);
        }

        public static bool killedBouncer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBouncer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBouncer), value);
        }

        public static int killsBouncer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBouncer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBouncer), value);
        }

        public static bool newDataBouncer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBouncer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBouncer), value);
        }

        public static bool killedClimber
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedClimber));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedClimber), value);
        }

        public static int killsClimber
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsClimber));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsClimber), value);
        }

        public static bool newDataClimber
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataClimber));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataClimber), value);
        }

        public static bool killedHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHopper), value);
        }

        public static int killsHopper
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHopper));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHopper), value);
        }

        public static bool newDataHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHopper), value);
        }

        public static bool killedWorm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedWorm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedWorm), value);
        }

        public static int killsWorm
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsWorm));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsWorm), value);
        }

        public static bool newDataWorm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataWorm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataWorm), value);
        }

        public static bool killedSpitter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSpitter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSpitter), value);
        }

        public static int killsSpitter
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSpitter));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSpitter), value);
        }

        public static bool newDataSpitter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSpitter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSpitter), value);
        }

        public static bool killedHatcher
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHatcher));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHatcher), value);
        }

        public static int killsHatcher
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHatcher));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHatcher), value);
        }

        public static bool newDataHatcher
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHatcher));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHatcher), value);
        }

        public static bool killedHatchling
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHatchling));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHatchling), value);
        }

        public static int killsHatchling
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHatchling));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHatchling), value);
        }

        public static bool newDataHatchling
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHatchling));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHatchling), value);
        }

        public static bool killedZombieRunner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZombieRunner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZombieRunner), value);
        }

        public static int killsZombieRunner
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZombieRunner));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZombieRunner), value);
        }

        public static bool newDataZombieRunner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZombieRunner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZombieRunner), value);
        }

        public static bool killedZombieHornhead
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZombieHornhead));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZombieHornhead), value);
        }

        public static int killsZombieHornhead
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZombieHornhead));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZombieHornhead), value);
        }

        public static bool newDataZombieHornhead
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZombieHornhead));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZombieHornhead), value);
        }

        public static bool killedZombieLeaper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZombieLeaper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZombieLeaper), value);
        }

        public static int killsZombieLeaper
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZombieLeaper));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZombieLeaper), value);
        }

        public static bool newDataZombieLeaper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZombieLeaper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZombieLeaper), value);
        }

        public static bool killedZombieBarger
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZombieBarger));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZombieBarger), value);
        }

        public static int killsZombieBarger
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZombieBarger));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZombieBarger), value);
        }

        public static bool newDataZombieBarger
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZombieBarger));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZombieBarger), value);
        }

        public static bool killedZombieShield
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZombieShield));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZombieShield), value);
        }

        public static int killsZombieShield
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZombieShield));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZombieShield), value);
        }

        public static bool newDataZombieShield
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZombieShield));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZombieShield), value);
        }

        public static bool killedZombieGuard
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZombieGuard));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZombieGuard), value);
        }

        public static int killsZombieGuard
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZombieGuard));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZombieGuard), value);
        }

        public static bool newDataZombieGuard
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZombieGuard));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZombieGuard), value);
        }

        public static bool killedBigBuzzer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBigBuzzer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBigBuzzer), value);
        }

        public static int killsBigBuzzer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBigBuzzer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBigBuzzer), value);
        }

        public static bool newDataBigBuzzer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBigBuzzer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBigBuzzer), value);
        }

        public static bool killedBigFly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBigFly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBigFly), value);
        }

        public static int killsBigFly
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBigFly));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBigFly), value);
        }

        public static bool newDataBigFly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBigFly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBigFly), value);
        }

        public static bool killedMawlek
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMawlek));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMawlek), value);
        }

        public static int killsMawlek
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMawlek));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMawlek), value);
        }

        public static bool newDataMawlek
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMawlek));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMawlek), value);
        }

        public static bool killedFalseKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFalseKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFalseKnight), value);
        }

        public static int killsFalseKnight
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFalseKnight));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFalseKnight), value);
        }

        public static bool newDataFalseKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFalseKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFalseKnight), value);
        }

        public static bool killedRoller
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedRoller));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedRoller), value);
        }

        public static int killsRoller
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsRoller));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsRoller), value);
        }

        public static bool newDataRoller
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataRoller));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataRoller), value);
        }

        public static bool killedBlocker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBlocker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBlocker), value);
        }

        public static int killsBlocker
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBlocker));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBlocker), value);
        }

        public static bool newDataBlocker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBlocker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBlocker), value);
        }

        public static bool killedPrayerSlug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedPrayerSlug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedPrayerSlug), value);
        }

        public static int killsPrayerSlug
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsPrayerSlug));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsPrayerSlug), value);
        }

        public static bool newDataPrayerSlug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataPrayerSlug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataPrayerSlug), value);
        }

        public static bool killedMenderBug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMenderBug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMenderBug), value);
        }

        public static int killsMenderBug
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMenderBug));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMenderBug), value);
        }

        public static bool newDataMenderBug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMenderBug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMenderBug), value);
        }

        public static bool killedMossmanRunner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMossmanRunner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMossmanRunner), value);
        }

        public static int killsMossmanRunner
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMossmanRunner));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMossmanRunner), value);
        }

        public static bool newDataMossmanRunner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMossmanRunner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMossmanRunner), value);
        }

        public static bool killedMossmanShaker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMossmanShaker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMossmanShaker), value);
        }

        public static int killsMossmanShaker
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMossmanShaker));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMossmanShaker), value);
        }

        public static bool newDataMossmanShaker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMossmanShaker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMossmanShaker), value);
        }

        public static bool killedMosquito
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMosquito));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMosquito), value);
        }

        public static int killsMosquito
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMosquito));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMosquito), value);
        }

        public static bool newDataMosquito
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMosquito));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMosquito), value);
        }

        public static bool killedBlobFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBlobFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBlobFlyer), value);
        }

        public static int killsBlobFlyer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBlobFlyer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBlobFlyer), value);
        }

        public static bool newDataBlobFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBlobFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBlobFlyer), value);
        }

        public static bool killedFungifiedZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFungifiedZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFungifiedZombie), value);
        }

        public static int killsFungifiedZombie
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFungifiedZombie));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFungifiedZombie), value);
        }

        public static bool newDataFungifiedZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFungifiedZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFungifiedZombie), value);
        }

        public static bool killedPlantShooter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedPlantShooter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedPlantShooter), value);
        }

        public static int killsPlantShooter
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsPlantShooter));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsPlantShooter), value);
        }

        public static bool newDataPlantShooter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataPlantShooter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataPlantShooter), value);
        }

        public static bool killedMossCharger
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMossCharger));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMossCharger), value);
        }

        public static int killsMossCharger
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMossCharger));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMossCharger), value);
        }

        public static bool newDataMossCharger
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMossCharger));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMossCharger), value);
        }

        public static bool killedMegaMossCharger
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMegaMossCharger));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMegaMossCharger), value);
        }

        public static int killsMegaMossCharger
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMegaMossCharger));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMegaMossCharger), value);
        }

        public static bool newDataMegaMossCharger
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMegaMossCharger));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMegaMossCharger), value);
        }

        public static bool killedSnapperTrap
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSnapperTrap));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSnapperTrap), value);
        }

        public static int killsSnapperTrap
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSnapperTrap));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSnapperTrap), value);
        }

        public static bool newDataSnapperTrap
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSnapperTrap));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSnapperTrap), value);
        }

        public static bool killedMossKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMossKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMossKnight), value);
        }

        public static int killsMossKnight
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMossKnight));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMossKnight), value);
        }

        public static bool newDataMossKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMossKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMossKnight), value);
        }

        public static bool killedGrassHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGrassHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGrassHopper), value);
        }

        public static int killsGrassHopper
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGrassHopper));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGrassHopper), value);
        }

        public static bool newDataGrassHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGrassHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGrassHopper), value);
        }

        public static bool killedAcidFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedAcidFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedAcidFlyer), value);
        }

        public static int killsAcidFlyer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsAcidFlyer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsAcidFlyer), value);
        }

        public static bool newDataAcidFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataAcidFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataAcidFlyer), value);
        }

        public static bool killedAcidWalker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedAcidWalker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedAcidWalker), value);
        }

        public static int killsAcidWalker
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsAcidWalker));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsAcidWalker), value);
        }

        public static bool newDataAcidWalker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataAcidWalker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataAcidWalker), value);
        }

        public static bool killedMossFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMossFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMossFlyer), value);
        }

        public static int killsMossFlyer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMossFlyer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMossFlyer), value);
        }

        public static bool newDataMossFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMossFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMossFlyer), value);
        }

        public static bool killedMossKnightFat
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMossKnightFat));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMossKnightFat), value);
        }

        public static int killsMossKnightFat
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMossKnightFat));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMossKnightFat), value);
        }

        public static bool newDataMossKnightFat
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMossKnightFat));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMossKnightFat), value);
        }

        public static bool killedMossWalker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMossWalker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMossWalker), value);
        }

        public static int killsMossWalker
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMossWalker));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMossWalker), value);
        }

        public static bool newDataMossWalker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMossWalker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMossWalker), value);
        }

        public static bool killedInfectedKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedInfectedKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedInfectedKnight), value);
        }

        public static int killsInfectedKnight
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsInfectedKnight));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsInfectedKnight), value);
        }

        public static bool newDataInfectedKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataInfectedKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataInfectedKnight), value);
        }

        public static bool killedLazyFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedLazyFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedLazyFlyer), value);
        }

        public static int killsLazyFlyer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsLazyFlyer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsLazyFlyer), value);
        }

        public static bool newDataLazyFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataLazyFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataLazyFlyer), value);
        }

        public static bool killedZapBug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZapBug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZapBug), value);
        }

        public static int killsZapBug
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZapBug));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZapBug), value);
        }

        public static bool newDataZapBug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZapBug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZapBug), value);
        }

        public static bool killedJellyfish
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedJellyfish));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedJellyfish), value);
        }

        public static int killsJellyfish
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsJellyfish));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsJellyfish), value);
        }

        public static bool newDataJellyfish
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataJellyfish));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataJellyfish), value);
        }

        public static bool killedJellyCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedJellyCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedJellyCrawler), value);
        }

        public static int killsJellyCrawler
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsJellyCrawler));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsJellyCrawler), value);
        }

        public static bool newDataJellyCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataJellyCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataJellyCrawler), value);
        }

        public static bool killedMegaJellyfish
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMegaJellyfish));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMegaJellyfish), value);
        }

        public static int killsMegaJellyfish
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMegaJellyfish));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMegaJellyfish), value);
        }

        public static bool newDataMegaJellyfish
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMegaJellyfish));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMegaJellyfish), value);
        }

        public static bool killedFungoonBaby
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFungoonBaby));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFungoonBaby), value);
        }

        public static int killsFungoonBaby
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFungoonBaby));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFungoonBaby), value);
        }

        public static bool newDataFungoonBaby
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFungoonBaby));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFungoonBaby), value);
        }

        public static bool killedMushroomTurret
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMushroomTurret));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMushroomTurret), value);
        }

        public static int killsMushroomTurret
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMushroomTurret));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMushroomTurret), value);
        }

        public static bool newDataMushroomTurret
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMushroomTurret));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMushroomTurret), value);
        }

        public static bool killedMantis
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMantis));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMantis), value);
        }

        public static int killsMantis
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMantis));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMantis), value);
        }

        public static bool newDataMantis
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMantis));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMantis), value);
        }

        public static bool killedMushroomRoller
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMushroomRoller));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMushroomRoller), value);
        }

        public static int killsMushroomRoller
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMushroomRoller));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMushroomRoller), value);
        }

        public static bool newDataMushroomRoller
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMushroomRoller));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMushroomRoller), value);
        }

        public static bool killedMushroomBrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMushroomBrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMushroomBrawler), value);
        }

        public static int killsMushroomBrawler
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMushroomBrawler));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMushroomBrawler), value);
        }

        public static bool newDataMushroomBrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMushroomBrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMushroomBrawler), value);
        }

        public static bool killedMushroomBaby
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMushroomBaby));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMushroomBaby), value);
        }

        public static int killsMushroomBaby
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMushroomBaby));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMushroomBaby), value);
        }

        public static bool newDataMushroomBaby
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMushroomBaby));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMushroomBaby), value);
        }

        public static bool killedMantisFlyerChild
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMantisFlyerChild));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMantisFlyerChild), value);
        }

        public static int killsMantisFlyerChild
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMantisFlyerChild));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMantisFlyerChild), value);
        }

        public static bool newDataMantisFlyerChild
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMantisFlyerChild));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMantisFlyerChild), value);
        }

        public static bool killedFungusFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFungusFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFungusFlyer), value);
        }

        public static int killsFungusFlyer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFungusFlyer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFungusFlyer), value);
        }

        public static bool newDataFungusFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFungusFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFungusFlyer), value);
        }

        public static bool killedFungCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFungCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFungCrawler), value);
        }

        public static int killsFungCrawler
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFungCrawler));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFungCrawler), value);
        }

        public static bool newDataFungCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFungCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFungCrawler), value);
        }

        public static bool killedMantisLord
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMantisLord));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMantisLord), value);
        }

        public static int killsMantisLord
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMantisLord));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMantisLord), value);
        }

        public static bool newDataMantisLord
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMantisLord));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMantisLord), value);
        }

        public static bool killedBlackKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBlackKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBlackKnight), value);
        }

        public static int killsBlackKnight
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBlackKnight));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBlackKnight), value);
        }

        public static bool newDataBlackKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBlackKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBlackKnight), value);
        }

        public static bool killedElectricMage
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedElectricMage));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedElectricMage), value);
        }

        public static int killsElectricMage
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsElectricMage));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsElectricMage), value);
        }

        public static bool newDataElectricMage
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataElectricMage));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataElectricMage), value);
        }

        public static bool killedMage
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMage));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMage), value);
        }

        public static int killsMage
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMage));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMage), value);
        }

        public static bool newDataMage
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMage));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMage), value);
        }

        public static bool killedMageKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMageKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMageKnight), value);
        }

        public static int killsMageKnight
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMageKnight));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMageKnight), value);
        }

        public static bool newDataMageKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMageKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMageKnight), value);
        }

        public static bool killedRoyalDandy
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedRoyalDandy));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedRoyalDandy), value);
        }

        public static int killsRoyalDandy
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsRoyalDandy));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsRoyalDandy), value);
        }

        public static bool newDataRoyalDandy
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataRoyalDandy));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataRoyalDandy), value);
        }

        public static bool killedRoyalCoward
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedRoyalCoward));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedRoyalCoward), value);
        }

        public static int killsRoyalCoward
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsRoyalCoward));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsRoyalCoward), value);
        }

        public static bool newDataRoyalCoward
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataRoyalCoward));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataRoyalCoward), value);
        }

        public static bool killedRoyalPlumper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedRoyalPlumper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedRoyalPlumper), value);
        }

        public static int killsRoyalPlumper
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsRoyalPlumper));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsRoyalPlumper), value);
        }

        public static bool newDataRoyalPlumper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataRoyalPlumper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataRoyalPlumper), value);
        }

        public static bool killedFlyingSentrySword
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFlyingSentrySword));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFlyingSentrySword), value);
        }

        public static int killsFlyingSentrySword
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFlyingSentrySword));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFlyingSentrySword), value);
        }

        public static bool newDataFlyingSentrySword
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFlyingSentrySword));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFlyingSentrySword), value);
        }

        public static bool killedFlyingSentryJavelin
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFlyingSentryJavelin));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFlyingSentryJavelin), value);
        }

        public static int killsFlyingSentryJavelin
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFlyingSentryJavelin));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFlyingSentryJavelin), value);
        }

        public static bool newDataFlyingSentryJavelin
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFlyingSentryJavelin));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFlyingSentryJavelin), value);
        }

        public static bool killedSentry
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSentry));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSentry), value);
        }

        public static int killsSentry
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSentry));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSentry), value);
        }

        public static bool newDataSentry
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSentry));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSentry), value);
        }

        public static bool killedSentryFat
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSentryFat));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSentryFat), value);
        }

        public static int killsSentryFat
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSentryFat));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSentryFat), value);
        }

        public static bool newDataSentryFat
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSentryFat));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSentryFat), value);
        }

        public static bool killedMageBlob
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMageBlob));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMageBlob), value);
        }

        public static int killsMageBlob
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMageBlob));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMageBlob), value);
        }

        public static bool newDataMageBlob
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMageBlob));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMageBlob), value);
        }

        public static bool killedGreatShieldZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGreatShieldZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGreatShieldZombie), value);
        }

        public static int killsGreatShieldZombie
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGreatShieldZombie));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGreatShieldZombie), value);
        }

        public static bool newDataGreatShieldZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGreatShieldZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGreatShieldZombie), value);
        }

        public static bool killedJarCollector
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedJarCollector));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedJarCollector), value);
        }

        public static int killsJarCollector
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsJarCollector));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsJarCollector), value);
        }

        public static bool newDataJarCollector
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataJarCollector));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataJarCollector), value);
        }

        public static bool killedMageBalloon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMageBalloon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMageBalloon), value);
        }

        public static int killsMageBalloon
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMageBalloon));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMageBalloon), value);
        }

        public static bool newDataMageBalloon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMageBalloon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMageBalloon), value);
        }

        public static bool killedMageLord
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMageLord));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMageLord), value);
        }

        public static int killsMageLord
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMageLord));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMageLord), value);
        }

        public static bool newDataMageLord
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMageLord));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMageLord), value);
        }

        public static bool killedGorgeousHusk
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGorgeousHusk));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGorgeousHusk), value);
        }

        public static int killsGorgeousHusk
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGorgeousHusk));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGorgeousHusk), value);
        }

        public static bool newDataGorgeousHusk
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGorgeousHusk));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGorgeousHusk), value);
        }

        public static bool killedFlipHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFlipHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFlipHopper), value);
        }

        public static int killsFlipHopper
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFlipHopper));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFlipHopper), value);
        }

        public static bool newDataFlipHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFlipHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFlipHopper), value);
        }

        public static bool killedFlukeman
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFlukeman));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFlukeman), value);
        }

        public static int killsFlukeman
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFlukeman));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFlukeman), value);
        }

        public static bool newDataFlukeman
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFlukeman));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFlukeman), value);
        }

        public static bool killedInflater
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedInflater));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedInflater), value);
        }

        public static int killsInflater
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsInflater));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsInflater), value);
        }

        public static bool newDataInflater
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataInflater));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataInflater), value);
        }

        public static bool killedFlukefly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFlukefly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFlukefly), value);
        }

        public static int killsFlukefly
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFlukefly));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFlukefly), value);
        }

        public static bool newDataFlukefly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFlukefly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFlukefly), value);
        }

        public static bool killedFlukeMother
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFlukeMother));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFlukeMother), value);
        }

        public static int killsFlukeMother
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFlukeMother));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFlukeMother), value);
        }

        public static bool newDataFlukeMother
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFlukeMother));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFlukeMother), value);
        }

        public static bool killedDungDefender
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedDungDefender));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedDungDefender), value);
        }

        public static int killsDungDefender
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsDungDefender));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsDungDefender), value);
        }

        public static bool newDataDungDefender
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataDungDefender));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataDungDefender), value);
        }

        public static bool killedCrystalCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedCrystalCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedCrystalCrawler), value);
        }

        public static int killsCrystalCrawler
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsCrystalCrawler));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsCrystalCrawler), value);
        }

        public static bool newDataCrystalCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataCrystalCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataCrystalCrawler), value);
        }

        public static bool killedCrystalFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedCrystalFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedCrystalFlyer), value);
        }

        public static int killsCrystalFlyer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsCrystalFlyer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsCrystalFlyer), value);
        }

        public static bool newDataCrystalFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataCrystalFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataCrystalFlyer), value);
        }

        public static bool killedLaserBug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedLaserBug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedLaserBug), value);
        }

        public static int killsLaserBug
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsLaserBug));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsLaserBug), value);
        }

        public static bool newDataLaserBug
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataLaserBug));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataLaserBug), value);
        }

        public static bool killedBeamMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBeamMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBeamMiner), value);
        }

        public static int killsBeamMiner
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBeamMiner));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBeamMiner), value);
        }

        public static bool newDataBeamMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBeamMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBeamMiner), value);
        }

        public static bool killedZombieMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZombieMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZombieMiner), value);
        }

        public static int killsZombieMiner
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZombieMiner));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZombieMiner), value);
        }

        public static bool newDataZombieMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZombieMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZombieMiner), value);
        }

        public static bool killedMegaBeamMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMegaBeamMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMegaBeamMiner), value);
        }

        public static int killsMegaBeamMiner
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMegaBeamMiner));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMegaBeamMiner), value);
        }

        public static bool newDataMegaBeamMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMegaBeamMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMegaBeamMiner), value);
        }

        public static bool killedMinesCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMinesCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMinesCrawler), value);
        }

        public static int killsMinesCrawler
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMinesCrawler));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMinesCrawler), value);
        }

        public static bool newDataMinesCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMinesCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMinesCrawler), value);
        }

        public static bool killedAngryBuzzer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedAngryBuzzer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedAngryBuzzer), value);
        }

        public static int killsAngryBuzzer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsAngryBuzzer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsAngryBuzzer), value);
        }

        public static bool newDataAngryBuzzer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataAngryBuzzer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataAngryBuzzer), value);
        }

        public static bool killedBurstingBouncer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBurstingBouncer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBurstingBouncer), value);
        }

        public static int killsBurstingBouncer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBurstingBouncer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBurstingBouncer), value);
        }

        public static bool newDataBurstingBouncer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBurstingBouncer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBurstingBouncer), value);
        }

        public static bool killedBurstingZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBurstingZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBurstingZombie), value);
        }

        public static int killsBurstingZombie
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBurstingZombie));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBurstingZombie), value);
        }

        public static bool newDataBurstingZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBurstingZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBurstingZombie), value);
        }

        public static bool killedSpittingZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSpittingZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSpittingZombie), value);
        }

        public static int killsSpittingZombie
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSpittingZombie));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSpittingZombie), value);
        }

        public static bool newDataSpittingZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSpittingZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSpittingZombie), value);
        }

        public static bool killedBabyCentipede
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBabyCentipede));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBabyCentipede), value);
        }

        public static int killsBabyCentipede
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBabyCentipede));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBabyCentipede), value);
        }

        public static bool newDataBabyCentipede
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBabyCentipede));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBabyCentipede), value);
        }

        public static bool killedBigCentipede
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBigCentipede));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBigCentipede), value);
        }

        public static int killsBigCentipede
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBigCentipede));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBigCentipede), value);
        }

        public static bool newDataBigCentipede
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBigCentipede));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBigCentipede), value);
        }

        public static bool killedCentipedeHatcher
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedCentipedeHatcher));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedCentipedeHatcher), value);
        }

        public static int killsCentipedeHatcher
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsCentipedeHatcher));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsCentipedeHatcher), value);
        }

        public static bool newDataCentipedeHatcher
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataCentipedeHatcher));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataCentipedeHatcher), value);
        }

        public static bool killedLesserMawlek
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedLesserMawlek));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedLesserMawlek), value);
        }

        public static int killsLesserMawlek
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsLesserMawlek));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsLesserMawlek), value);
        }

        public static bool newDataLesserMawlek
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataLesserMawlek));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataLesserMawlek), value);
        }

        public static bool killedSlashSpider
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSlashSpider));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSlashSpider), value);
        }

        public static int killsSlashSpider
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSlashSpider));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSlashSpider), value);
        }

        public static bool newDataSlashSpider
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSlashSpider));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSlashSpider), value);
        }

        public static bool killedSpiderCorpse
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSpiderCorpse));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSpiderCorpse), value);
        }

        public static int killsSpiderCorpse
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSpiderCorpse));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSpiderCorpse), value);
        }

        public static bool newDataSpiderCorpse
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSpiderCorpse));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSpiderCorpse), value);
        }

        public static bool killedShootSpider
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedShootSpider));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedShootSpider), value);
        }

        public static int killsShootSpider
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsShootSpider));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsShootSpider), value);
        }

        public static bool newDataShootSpider
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataShootSpider));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataShootSpider), value);
        }

        public static bool killedMiniSpider
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMiniSpider));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMiniSpider), value);
        }

        public static int killsMiniSpider
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMiniSpider));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMiniSpider), value);
        }

        public static bool newDataMiniSpider
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMiniSpider));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMiniSpider), value);
        }

        public static bool killedSpiderFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSpiderFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSpiderFlyer), value);
        }

        public static int killsSpiderFlyer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSpiderFlyer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSpiderFlyer), value);
        }

        public static bool newDataSpiderFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSpiderFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSpiderFlyer), value);
        }

        public static bool killedMimicSpider
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMimicSpider));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMimicSpider), value);
        }

        public static int killsMimicSpider
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMimicSpider));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMimicSpider), value);
        }

        public static bool newDataMimicSpider
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMimicSpider));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMimicSpider), value);
        }

        public static bool killedBeeHatchling
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBeeHatchling));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBeeHatchling), value);
        }

        public static int killsBeeHatchling
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBeeHatchling));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBeeHatchling), value);
        }

        public static bool newDataBeeHatchling
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBeeHatchling));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBeeHatchling), value);
        }

        public static bool killedBeeStinger
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBeeStinger));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBeeStinger), value);
        }

        public static int killsBeeStinger
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBeeStinger));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBeeStinger), value);
        }

        public static bool newDataBeeStinger
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBeeStinger));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBeeStinger), value);
        }

        public static bool killedBigBee
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBigBee));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBigBee), value);
        }

        public static int killsBigBee
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBigBee));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBigBee), value);
        }

        public static bool newDataBigBee
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBigBee));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBigBee), value);
        }

        public static bool killedHiveKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHiveKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHiveKnight), value);
        }

        public static int killsHiveKnight
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHiveKnight));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHiveKnight), value);
        }

        public static bool newDataHiveKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHiveKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHiveKnight), value);
        }

        public static bool killedBlowFly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBlowFly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBlowFly), value);
        }

        public static int killsBlowFly
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBlowFly));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBlowFly), value);
        }

        public static bool newDataBlowFly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBlowFly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBlowFly), value);
        }

        public static bool killedCeilingDropper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedCeilingDropper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedCeilingDropper), value);
        }

        public static int killsCeilingDropper
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsCeilingDropper));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsCeilingDropper), value);
        }

        public static bool newDataCeilingDropper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataCeilingDropper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataCeilingDropper), value);
        }

        public static bool killedGiantHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGiantHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGiantHopper), value);
        }

        public static int killsGiantHopper
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGiantHopper));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGiantHopper), value);
        }

        public static bool newDataGiantHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGiantHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGiantHopper), value);
        }

        public static bool killedGrubMimic
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGrubMimic));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGrubMimic), value);
        }

        public static int killsGrubMimic
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGrubMimic));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGrubMimic), value);
        }

        public static bool newDataGrubMimic
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGrubMimic));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGrubMimic), value);
        }

        public static bool killedMawlekTurret
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMawlekTurret));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMawlekTurret), value);
        }

        public static int killsMawlekTurret
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMawlekTurret));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMawlekTurret), value);
        }

        public static bool newDataMawlekTurret
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMawlekTurret));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMawlekTurret), value);
        }

        public static bool killedOrangeScuttler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedOrangeScuttler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedOrangeScuttler), value);
        }

        public static int killsOrangeScuttler
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsOrangeScuttler));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsOrangeScuttler), value);
        }

        public static bool newDataOrangeScuttler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataOrangeScuttler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataOrangeScuttler), value);
        }

        public static bool killedHealthScuttler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHealthScuttler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHealthScuttler), value);
        }

        public static int killsHealthScuttler
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHealthScuttler));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHealthScuttler), value);
        }

        public static bool newDataHealthScuttler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHealthScuttler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHealthScuttler), value);
        }

        public static bool killedPigeon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedPigeon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedPigeon), value);
        }

        public static int killsPigeon
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsPigeon));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsPigeon), value);
        }

        public static bool newDataPigeon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataPigeon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataPigeon), value);
        }

        public static bool killedZombieHive
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZombieHive));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZombieHive), value);
        }

        public static int killsZombieHive
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZombieHive));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZombieHive), value);
        }

        public static bool newDataZombieHive
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZombieHive));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZombieHive), value);
        }

        public static bool killedDreamGuard
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedDreamGuard));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedDreamGuard), value);
        }

        public static int killsDreamGuard
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsDreamGuard));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsDreamGuard), value);
        }

        public static bool newDataDreamGuard
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataDreamGuard));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataDreamGuard), value);
        }

        public static bool killedHornet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHornet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHornet), value);
        }

        public static int killsHornet
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHornet));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHornet), value);
        }

        public static bool newDataHornet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHornet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHornet), value);
        }

        public static bool killedAbyssCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedAbyssCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedAbyssCrawler), value);
        }

        public static int killsAbyssCrawler
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsAbyssCrawler));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsAbyssCrawler), value);
        }

        public static bool newDataAbyssCrawler
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataAbyssCrawler));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataAbyssCrawler), value);
        }

        public static bool killedSuperSpitter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSuperSpitter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSuperSpitter), value);
        }

        public static int killsSuperSpitter
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSuperSpitter));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSuperSpitter), value);
        }

        public static bool newDataSuperSpitter
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSuperSpitter));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSuperSpitter), value);
        }

        public static bool killedSibling
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedSibling));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedSibling), value);
        }

        public static int killsSibling
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsSibling));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsSibling), value);
        }

        public static bool newDataSibling
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataSibling));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataSibling), value);
        }

        public static bool killedPalaceFly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedPalaceFly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedPalaceFly), value);
        }

        public static int killsPalaceFly
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsPalaceFly));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsPalaceFly), value);
        }

        public static bool newDataPalaceFly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataPalaceFly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataPalaceFly), value);
        }

        public static bool killedEggSac
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedEggSac));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedEggSac), value);
        }

        public static int killsEggSac
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsEggSac));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsEggSac), value);
        }

        public static bool newDataEggSac
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataEggSac));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataEggSac), value);
        }

        public static bool killedMummy
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMummy));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMummy), value);
        }

        public static int killsMummy
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMummy));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMummy), value);
        }

        public static bool newDataMummy
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMummy));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMummy), value);
        }

        public static bool killedOrangeBalloon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedOrangeBalloon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedOrangeBalloon), value);
        }

        public static int killsOrangeBalloon
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsOrangeBalloon));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsOrangeBalloon), value);
        }

        public static bool newDataOrangeBalloon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataOrangeBalloon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataOrangeBalloon), value);
        }

        public static bool killedAbyssTendril
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedAbyssTendril));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedAbyssTendril), value);
        }

        public static int killsAbyssTendril
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsAbyssTendril));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsAbyssTendril), value);
        }

        public static bool newDataAbyssTendril
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataAbyssTendril));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataAbyssTendril), value);
        }

        public static bool killedHeavyMantis
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHeavyMantis));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHeavyMantis), value);
        }

        public static int killsHeavyMantis
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHeavyMantis));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHeavyMantis), value);
        }

        public static bool newDataHeavyMantis
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHeavyMantis));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHeavyMantis), value);
        }

        public static bool killedTraitorLord
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedTraitorLord));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedTraitorLord), value);
        }

        public static int killsTraitorLord
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsTraitorLord));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsTraitorLord), value);
        }

        public static bool newDataTraitorLord
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataTraitorLord));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataTraitorLord), value);
        }

        public static bool killedMantisHeavyFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedMantisHeavyFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedMantisHeavyFlyer), value);
        }

        public static int killsMantisHeavyFlyer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsMantisHeavyFlyer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsMantisHeavyFlyer), value);
        }

        public static bool newDataMantisHeavyFlyer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataMantisHeavyFlyer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataMantisHeavyFlyer), value);
        }

        public static bool killedGardenZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGardenZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGardenZombie), value);
        }

        public static int killsGardenZombie
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGardenZombie));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGardenZombie), value);
        }

        public static bool newDataGardenZombie
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGardenZombie));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGardenZombie), value);
        }

        public static bool killedRoyalGuard
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedRoyalGuard));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedRoyalGuard), value);
        }

        public static int killsRoyalGuard
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsRoyalGuard));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsRoyalGuard), value);
        }

        public static bool newDataRoyalGuard
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataRoyalGuard));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataRoyalGuard), value);
        }

        public static bool killedWhiteRoyal
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedWhiteRoyal));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedWhiteRoyal), value);
        }

        public static int killsWhiteRoyal
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsWhiteRoyal));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsWhiteRoyal), value);
        }

        public static bool newDataWhiteRoyal
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataWhiteRoyal));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataWhiteRoyal), value);
        }

        public static bool openedPalaceGrounds
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedPalaceGrounds));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedPalaceGrounds), value);
        }

        public static bool killedOblobble
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedOblobble));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedOblobble), value);
        }

        public static int killsOblobble
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsOblobble));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsOblobble), value);
        }

        public static bool newDataOblobble
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataOblobble));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataOblobble), value);
        }

        public static bool killedZote
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZote));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZote), value);
        }

        public static int killsZote
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZote));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZote), value);
        }

        public static bool newDataZote
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZote));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZote), value);
        }

        public static bool killedBlobble
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBlobble));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBlobble), value);
        }

        public static int killsBlobble
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBlobble));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBlobble), value);
        }

        public static bool newDataBlobble
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBlobble));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBlobble), value);
        }

        public static bool killedColMosquito
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedColMosquito));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedColMosquito), value);
        }

        public static int killsColMosquito
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsColMosquito));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsColMosquito), value);
        }

        public static bool newDataColMosquito
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataColMosquito));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataColMosquito), value);
        }

        public static bool killedColRoller
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedColRoller));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedColRoller), value);
        }

        public static int killsColRoller
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsColRoller));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsColRoller), value);
        }

        public static bool newDataColRoller
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataColRoller));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataColRoller), value);
        }

        public static bool killedColFlyingSentry
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedColFlyingSentry));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedColFlyingSentry), value);
        }

        public static int killsColFlyingSentry
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsColFlyingSentry));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsColFlyingSentry), value);
        }

        public static bool newDataColFlyingSentry
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataColFlyingSentry));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataColFlyingSentry), value);
        }

        public static bool killedColMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedColMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedColMiner), value);
        }

        public static int killsColMiner
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsColMiner));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsColMiner), value);
        }

        public static bool newDataColMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataColMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataColMiner), value);
        }

        public static bool killedColShield
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedColShield));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedColShield), value);
        }

        public static int killsColShield
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsColShield));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsColShield), value);
        }

        public static bool newDataColShield
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataColShield));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataColShield), value);
        }

        public static bool killedColWorm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedColWorm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedColWorm), value);
        }

        public static int killsColWorm
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsColWorm));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsColWorm), value);
        }

        public static bool newDataColWorm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataColWorm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataColWorm), value);
        }

        public static bool killedColHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedColHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedColHopper), value);
        }

        public static int killsColHopper
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsColHopper));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsColHopper), value);
        }

        public static bool newDataColHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataColHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataColHopper), value);
        }

        public static bool killedLobsterLancer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedLobsterLancer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedLobsterLancer), value);
        }

        public static int killsLobsterLancer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsLobsterLancer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsLobsterLancer), value);
        }

        public static bool newDataLobsterLancer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataLobsterLancer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataLobsterLancer), value);
        }

        public static bool killedGhostAladar
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGhostAladar));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGhostAladar), value);
        }

        public static int killsGhostAladar
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGhostAladar));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGhostAladar), value);
        }

        public static bool newDataGhostAladar
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGhostAladar));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGhostAladar), value);
        }

        public static bool killedGhostXero
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGhostXero));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGhostXero), value);
        }

        public static int killsGhostXero
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGhostXero));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGhostXero), value);
        }

        public static bool newDataGhostXero
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGhostXero));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGhostXero), value);
        }

        public static bool killedGhostHu
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGhostHu));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGhostHu), value);
        }

        public static int killsGhostHu
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGhostHu));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGhostHu), value);
        }

        public static bool newDataGhostHu
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGhostHu));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGhostHu), value);
        }

        public static bool killedGhostMarmu
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGhostMarmu));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGhostMarmu), value);
        }

        public static int killsGhostMarmu
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGhostMarmu));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGhostMarmu), value);
        }

        public static bool newDataGhostMarmu
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGhostMarmu));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGhostMarmu), value);
        }

        public static bool killedGhostNoEyes
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGhostNoEyes));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGhostNoEyes), value);
        }

        public static int killsGhostNoEyes
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGhostNoEyes));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGhostNoEyes), value);
        }

        public static bool newDataGhostNoEyes
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGhostNoEyes));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGhostNoEyes), value);
        }

        public static bool killedGhostMarkoth
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGhostMarkoth));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGhostMarkoth), value);
        }

        public static int killsGhostMarkoth
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGhostMarkoth));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGhostMarkoth), value);
        }

        public static bool newDataGhostMarkoth
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGhostMarkoth));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGhostMarkoth), value);
        }

        public static bool killedGhostGalien
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGhostGalien));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGhostGalien), value);
        }

        public static int killsGhostGalien
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGhostGalien));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGhostGalien), value);
        }

        public static bool newDataGhostGalien
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGhostGalien));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGhostGalien), value);
        }

        public static bool killedWhiteDefender
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedWhiteDefender));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedWhiteDefender), value);
        }

        public static int killsWhiteDefender
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsWhiteDefender));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsWhiteDefender), value);
        }

        public static bool newDataWhiteDefender
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataWhiteDefender));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataWhiteDefender), value);
        }

        public static bool killedGreyPrince
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGreyPrince));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGreyPrince), value);
        }

        public static int killsGreyPrince
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGreyPrince));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGreyPrince), value);
        }

        public static bool newDataGreyPrince
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGreyPrince));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGreyPrince), value);
        }

        public static bool killedZotelingBalloon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZotelingBalloon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZotelingBalloon), value);
        }

        public static int killsZotelingBalloon
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZotelingBalloon));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZotelingBalloon), value);
        }

        public static bool newDataZotelingBalloon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZotelingBalloon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZotelingBalloon), value);
        }

        public static bool killedZotelingHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZotelingHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZotelingHopper), value);
        }

        public static int killsZotelingHopper
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZotelingHopper));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZotelingHopper), value);
        }

        public static bool newDataZotelingHopper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZotelingHopper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZotelingHopper), value);
        }

        public static bool killedZotelingBuzzer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedZotelingBuzzer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedZotelingBuzzer), value);
        }

        public static int killsZotelingBuzzer
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsZotelingBuzzer));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsZotelingBuzzer), value);
        }

        public static bool newDataZotelingBuzzer
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataZotelingBuzzer));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataZotelingBuzzer), value);
        }

        public static bool killedHollowKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHollowKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHollowKnight), value);
        }

        public static int killsHollowKnight
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHollowKnight));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHollowKnight), value);
        }

        public static bool newDataHollowKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHollowKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHollowKnight), value);
        }

        public static bool killedFinalBoss
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFinalBoss));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFinalBoss), value);
        }

        public static int killsFinalBoss
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFinalBoss));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFinalBoss), value);
        }

        public static bool newDataFinalBoss
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFinalBoss));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFinalBoss), value);
        }

        public static bool killedHunterMark
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHunterMark));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHunterMark), value);
        }

        public static int killsHunterMark
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHunterMark));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHunterMark), value);
        }

        public static bool newDataHunterMark
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHunterMark));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHunterMark), value);
        }

        public static bool killedFlameBearerSmall
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFlameBearerSmall));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFlameBearerSmall), value);
        }

        public static int killsFlameBearerSmall
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFlameBearerSmall));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFlameBearerSmall), value);
        }

        public static bool newDataFlameBearerSmall
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFlameBearerSmall));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFlameBearerSmall), value);
        }

        public static bool killedFlameBearerMed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFlameBearerMed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFlameBearerMed), value);
        }

        public static int killsFlameBearerMed
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFlameBearerMed));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFlameBearerMed), value);
        }

        public static bool newDataFlameBearerMed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFlameBearerMed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFlameBearerMed), value);
        }

        public static bool killedFlameBearerLarge
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFlameBearerLarge));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFlameBearerLarge), value);
        }

        public static int killsFlameBearerLarge
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFlameBearerLarge));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFlameBearerLarge), value);
        }

        public static bool newDataFlameBearerLarge
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFlameBearerLarge));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFlameBearerLarge), value);
        }

        public static bool killedGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGrimm), value);
        }

        public static int killsGrimm
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGrimm));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGrimm), value);
        }

        public static bool newDataGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGrimm), value);
        }

        public static bool killedNightmareGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedNightmareGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedNightmareGrimm), value);
        }

        public static int killsNightmareGrimm
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsNightmareGrimm));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsNightmareGrimm), value);
        }

        public static bool newDataNightmareGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataNightmareGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataNightmareGrimm), value);
        }

        public static bool killedBindingSeal
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedBindingSeal));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedBindingSeal), value);
        }

        public static int killsBindingSeal
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsBindingSeal));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsBindingSeal), value);
        }

        public static bool newDataBindingSeal
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataBindingSeal));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataBindingSeal), value);
        }

        public static bool killedFatFluke
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedFatFluke));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedFatFluke), value);
        }

        public static int killsFatFluke
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsFatFluke));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsFatFluke), value);
        }

        public static bool newDataFatFluke
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataFatFluke));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataFatFluke), value);
        }

        public static bool killedPaleLurker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedPaleLurker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedPaleLurker), value);
        }

        public static int killsPaleLurker
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsPaleLurker));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsPaleLurker), value);
        }

        public static bool newDataPaleLurker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataPaleLurker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataPaleLurker), value);
        }

        public static bool killedNailBros
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedNailBros));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedNailBros), value);
        }

        public static int killsNailBros
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsNailBros));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsNailBros), value);
        }

        public static bool newDataNailBros
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataNailBros));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataNailBros), value);
        }

        public static bool killedPaintmaster
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedPaintmaster));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedPaintmaster), value);
        }

        public static int killsPaintmaster
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsPaintmaster));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsPaintmaster), value);
        }

        public static bool newDataPaintmaster
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataPaintmaster));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataPaintmaster), value);
        }

        public static bool killedNailsage
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedNailsage));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedNailsage), value);
        }

        public static int killsNailsage
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsNailsage));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsNailsage), value);
        }

        public static bool newDataNailsage
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataNailsage));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataNailsage), value);
        }

        public static bool killedHollowKnightPrime
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedHollowKnightPrime));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedHollowKnightPrime), value);
        }

        public static int killsHollowKnightPrime
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsHollowKnightPrime));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsHollowKnightPrime), value);
        }

        public static bool newDataHollowKnightPrime
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataHollowKnightPrime));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataHollowKnightPrime), value);
        }

        public static bool killedGodseekerMask
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedGodseekerMask));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedGodseekerMask), value);
        }

        public static int killsGodseekerMask
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsGodseekerMask));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsGodseekerMask), value);
        }

        public static bool newDataGodseekerMask
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataGodseekerMask));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataGodseekerMask), value);
        }

        public static bool killedVoidIdol_1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedVoidIdol_1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedVoidIdol_1), value);
        }

        public static int killsVoidIdol_1
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsVoidIdol_1));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsVoidIdol_1), value);
        }

        public static bool newDataVoidIdol_1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataVoidIdol_1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataVoidIdol_1), value);
        }

        public static bool killedVoidIdol_2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedVoidIdol_2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedVoidIdol_2), value);
        }

        public static int killsVoidIdol_2
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsVoidIdol_2));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsVoidIdol_2), value);
        }

        public static bool newDataVoidIdol_2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataVoidIdol_2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataVoidIdol_2), value);
        }

        public static bool killedVoidIdol_3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.killedVoidIdol_3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.killedVoidIdol_3), value);
        }

        public static int killsVoidIdol_3
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.killsVoidIdol_3));
           set => PlayerData.instance.SetInt(nameof(PlayerData.killsVoidIdol_3), value);
        }

        public static bool newDataVoidIdol_3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDataVoidIdol_3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDataVoidIdol_3), value);
        }

        public static int grubsCollected
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.grubsCollected));
           set => PlayerData.instance.SetInt(nameof(PlayerData.grubsCollected), value);
        }

        public static int grubRewards
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.grubRewards));
           set => PlayerData.instance.SetInt(nameof(PlayerData.grubRewards), value);
        }

        public static bool finalGrubRewardCollected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.finalGrubRewardCollected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.finalGrubRewardCollected), value);
        }

        public static bool fatGrubKing
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.fatGrubKing));
            set => PlayerData.instance.SetBool(nameof(PlayerData.fatGrubKing), value);
        }

        public static bool falseKnightDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.falseKnightDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.falseKnightDefeated), value);
        }

        public static bool falseKnightDreamDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.falseKnightDreamDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.falseKnightDreamDefeated), value);
        }

        public static bool falseKnightOrbsCollected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.falseKnightOrbsCollected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.falseKnightOrbsCollected), value);
        }

        public static bool mawlekDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mawlekDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mawlekDefeated), value);
        }

        public static bool giantBuzzerDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.giantBuzzerDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.giantBuzzerDefeated), value);
        }

        public static bool giantFlyDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.giantFlyDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.giantFlyDefeated), value);
        }

        public static bool blocker1Defeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.blocker1Defeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.blocker1Defeated), value);
        }

        public static bool blocker2Defeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.blocker2Defeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.blocker2Defeated), value);
        }

        public static bool hornet1Defeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hornet1Defeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hornet1Defeated), value);
        }

        public static bool collectorDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.collectorDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.collectorDefeated), value);
        }

        public static bool hornetOutskirtsDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hornetOutskirtsDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hornetOutskirtsDefeated), value);
        }

        public static bool mageLordDreamDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mageLordDreamDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mageLordDreamDefeated), value);
        }

        public static bool mageLordOrbsCollected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mageLordOrbsCollected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mageLordOrbsCollected), value);
        }

        public static bool infectedKnightDreamDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.infectedKnightDreamDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.infectedKnightDreamDefeated), value);
        }

        public static bool infectedKnightOrbsCollected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.infectedKnightOrbsCollected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.infectedKnightOrbsCollected), value);
        }

        public static bool whiteDefenderDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.whiteDefenderDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.whiteDefenderDefeated), value);
        }

        public static bool whiteDefenderOrbsCollected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.whiteDefenderOrbsCollected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.whiteDefenderOrbsCollected), value);
        }

        public static int whiteDefenderDefeats
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.whiteDefenderDefeats));
           set => PlayerData.instance.SetInt(nameof(PlayerData.whiteDefenderDefeats), value);
        }

        public static int greyPrinceDefeats
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.greyPrinceDefeats));
           set => PlayerData.instance.SetInt(nameof(PlayerData.greyPrinceDefeats), value);
        }

        public static bool greyPrinceDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.greyPrinceDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.greyPrinceDefeated), value);
        }

        public static bool greyPrinceOrbsCollected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.greyPrinceOrbsCollected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.greyPrinceOrbsCollected), value);
        }

        public static int aladarSlugDefeated
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.aladarSlugDefeated));
           set => PlayerData.instance.SetInt(nameof(PlayerData.aladarSlugDefeated), value);
        }

        public static int xeroDefeated
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.xeroDefeated));
           set => PlayerData.instance.SetInt(nameof(PlayerData.xeroDefeated), value);
        }

        public static int elderHuDefeated
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.elderHuDefeated));
           set => PlayerData.instance.SetInt(nameof(PlayerData.elderHuDefeated), value);
        }

        public static int mumCaterpillarDefeated
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.mumCaterpillarDefeated));
           set => PlayerData.instance.SetInt(nameof(PlayerData.mumCaterpillarDefeated), value);
        }

        public static int noEyesDefeated
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.noEyesDefeated));
           set => PlayerData.instance.SetInt(nameof(PlayerData.noEyesDefeated), value);
        }

        public static int markothDefeated
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.markothDefeated));
           set => PlayerData.instance.SetInt(nameof(PlayerData.markothDefeated), value);
        }

        public static int galienDefeated
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.galienDefeated));
           set => PlayerData.instance.SetInt(nameof(PlayerData.galienDefeated), value);
        }

        public static bool XERO_encountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.XERO_encountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.XERO_encountered), value);
        }

        public static bool ALADAR_encountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.ALADAR_encountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.ALADAR_encountered), value);
        }

        public static bool HU_encountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.HU_encountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.HU_encountered), value);
        }

        public static bool MUMCAT_encountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.MUMCAT_encountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.MUMCAT_encountered), value);
        }

        public static bool NOEYES_encountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.NOEYES_encountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.NOEYES_encountered), value);
        }

        public static bool MARKOTH_encountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.MARKOTH_encountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.MARKOTH_encountered), value);
        }

        public static bool GALIEN_encountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.GALIEN_encountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.GALIEN_encountered), value);
        }

        public static bool xeroPinned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.xeroPinned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.xeroPinned), value);
        }

        public static bool aladarPinned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.aladarPinned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.aladarPinned), value);
        }

        public static bool huPinned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.huPinned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.huPinned), value);
        }

        public static bool mumCaterpillarPinned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mumCaterpillarPinned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mumCaterpillarPinned), value);
        }

        public static bool noEyesPinned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.noEyesPinned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.noEyesPinned), value);
        }

        public static bool markothPinned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.markothPinned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.markothPinned), value);
        }

        public static bool galienPinned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.galienPinned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.galienPinned), value);
        }

        public static int currentInvPane
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.currentInvPane));
           set => PlayerData.instance.SetInt(nameof(PlayerData.currentInvPane), value);
        }

        public static bool showGeoUI
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.showGeoUI));
            set => PlayerData.instance.SetBool(nameof(PlayerData.showGeoUI), value);
        }

        public static bool showHealthUI
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.showHealthUI));
            set => PlayerData.instance.SetBool(nameof(PlayerData.showHealthUI), value);
        }

        public static bool promptFocus
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.promptFocus));
            set => PlayerData.instance.SetBool(nameof(PlayerData.promptFocus), value);
        }

        public static bool seenFocusTablet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.seenFocusTablet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.seenFocusTablet), value);
        }

        public static bool seenDreamNailPrompt
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.seenDreamNailPrompt));
            set => PlayerData.instance.SetBool(nameof(PlayerData.seenDreamNailPrompt), value);
        }

        public static bool isFirstGame
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.isFirstGame));
            set => PlayerData.instance.SetBool(nameof(PlayerData.isFirstGame), value);
        }

        public static bool enteredTutorialFirstTime
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.enteredTutorialFirstTime));
            set => PlayerData.instance.SetBool(nameof(PlayerData.enteredTutorialFirstTime), value);
        }

        public static bool isInvincible
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.isInvincible));
            set => PlayerData.instance.SetBool(nameof(PlayerData.isInvincible), value);
        }

        public static bool infiniteAirJump
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.infiniteAirJump));
            set => PlayerData.instance.SetBool(nameof(PlayerData.infiniteAirJump), value);
        }

        public static bool invinciTest
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.invinciTest));
            set => PlayerData.instance.SetBool(nameof(PlayerData.invinciTest), value);
        }

        public static int currentArea
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.currentArea));
           set => PlayerData.instance.SetInt(nameof(PlayerData.currentArea), value);
        }

        public static bool visitedDirtmouth
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedDirtmouth));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedDirtmouth), value);
        }

        public static bool visitedCrossroads
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedCrossroads));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedCrossroads), value);
        }

        public static bool visitedGreenpath
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedGreenpath));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedGreenpath), value);
        }

        public static bool visitedFungus
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedFungus));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedFungus), value);
        }

        public static bool visitedHive
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedHive));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedHive), value);
        }

        public static bool visitedCrossroadsInfected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedCrossroadsInfected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedCrossroadsInfected), value);
        }

        public static bool visitedRuins
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedRuins));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedRuins), value);
        }

        public static bool visitedMines
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedMines));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedMines), value);
        }

        public static bool visitedRoyalGardens
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedRoyalGardens));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedRoyalGardens), value);
        }

        public static bool visitedFogCanyon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedFogCanyon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedFogCanyon), value);
        }

        public static bool visitedDeepnest
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedDeepnest));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedDeepnest), value);
        }

        public static bool visitedRestingGrounds
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedRestingGrounds));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedRestingGrounds), value);
        }

        public static bool visitedWaterways
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedWaterways));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedWaterways), value);
        }

        public static bool visitedAbyss
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedAbyss));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedAbyss), value);
        }

        public static bool visitedOutskirts
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedOutskirts));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedOutskirts), value);
        }

        public static bool visitedWhitePalace
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedWhitePalace));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedWhitePalace), value);
        }

        public static bool visitedCliffs
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedCliffs));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedCliffs), value);
        }

        public static bool visitedAbyssLower
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedAbyssLower));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedAbyssLower), value);
        }

        public static bool visitedGodhome
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedGodhome));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedGodhome), value);
        }

        public static bool visitedMines10
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.visitedMines10));
            set => PlayerData.instance.SetBool(nameof(PlayerData.visitedMines10), value);
        }

        public static List<System.String> scenesVisited
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.scenesVisited));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.scenesVisited), value);
        }

        public static List<System.String> scenesMapped
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.scenesMapped));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.scenesMapped), value);
        }

        public static List<System.String> scenesEncounteredBench
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.scenesEncounteredBench));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.scenesEncounteredBench), value);
        }

        public static List<System.String> scenesGrubRescued
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.scenesGrubRescued));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.scenesGrubRescued), value);
        }

        public static List<System.String> scenesFlameCollected
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.scenesFlameCollected));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.scenesFlameCollected), value);
        }

        public static List<System.String> scenesEncounteredCocoon
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.scenesEncounteredCocoon));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.scenesEncounteredCocoon), value);
        }

        public static List<System.String> scenesEncounteredDreamPlant
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.scenesEncounteredDreamPlant));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.scenesEncounteredDreamPlant), value);
        }

        public static List<System.String> scenesEncounteredDreamPlantC
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.scenesEncounteredDreamPlantC));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.scenesEncounteredDreamPlantC), value);
        }

        public static bool hasMap
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasMap));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasMap), value);
        }

        public static bool mapAllRooms
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapAllRooms));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapAllRooms), value);
        }

        public static bool atMapPrompt
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.atMapPrompt));
            set => PlayerData.instance.SetBool(nameof(PlayerData.atMapPrompt), value);
        }

        public static bool mapDirtmouth
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapDirtmouth));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapDirtmouth), value);
        }

        public static bool mapCrossroads
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapCrossroads));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapCrossroads), value);
        }

        public static bool mapGreenpath
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapGreenpath));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapGreenpath), value);
        }

        public static bool mapFogCanyon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapFogCanyon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapFogCanyon), value);
        }

        public static bool mapRoyalGardens
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapRoyalGardens));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapRoyalGardens), value);
        }

        public static bool mapFungalWastes
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapFungalWastes));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapFungalWastes), value);
        }

        public static bool mapCity
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapCity));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapCity), value);
        }

        public static bool mapWaterways
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapWaterways));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapWaterways), value);
        }

        public static bool mapMines
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapMines));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapMines), value);
        }

        public static bool mapDeepnest
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapDeepnest));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapDeepnest), value);
        }

        public static bool mapCliffs
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapCliffs));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapCliffs), value);
        }

        public static bool mapOutskirts
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapOutskirts));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapOutskirts), value);
        }

        public static bool mapRestingGrounds
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapRestingGrounds));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapRestingGrounds), value);
        }

        public static bool mapAbyss
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mapAbyss));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mapAbyss), value);
        }

        public static bool hasPin
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPin));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPin), value);
        }

        public static bool hasPinBench
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinBench));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinBench), value);
        }

        public static bool hasPinCocoon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinCocoon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinCocoon), value);
        }

        public static bool hasPinDreamPlant
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinDreamPlant));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinDreamPlant), value);
        }

        public static bool hasPinGuardian
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinGuardian));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinGuardian), value);
        }

        public static bool hasPinBlackEgg
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinBlackEgg));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinBlackEgg), value);
        }

        public static bool hasPinShop
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinShop));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinShop), value);
        }

        public static bool hasPinSpa
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinSpa));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinSpa), value);
        }

        public static bool hasPinStag
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinStag));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinStag), value);
        }

        public static bool hasPinTram
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinTram));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinTram), value);
        }

        public static bool hasPinGhost
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinGhost));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinGhost), value);
        }

        public static bool hasPinGrub
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasPinGrub));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasPinGrub), value);
        }

        public static bool hasMarker
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasMarker));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasMarker), value);
        }

        public static bool hasMarker_r
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasMarker_r));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasMarker_r), value);
        }

        public static bool hasMarker_b
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasMarker_b));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasMarker_b), value);
        }

        public static bool hasMarker_y
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasMarker_y));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasMarker_y), value);
        }

        public static bool hasMarker_w
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasMarker_w));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasMarker_w), value);
        }

        public static int spareMarkers_r
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.spareMarkers_r));
           set => PlayerData.instance.SetInt(nameof(PlayerData.spareMarkers_r), value);
        }

        public static int spareMarkers_b
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.spareMarkers_b));
           set => PlayerData.instance.SetInt(nameof(PlayerData.spareMarkers_b), value);
        }

        public static int spareMarkers_y
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.spareMarkers_y));
           set => PlayerData.instance.SetInt(nameof(PlayerData.spareMarkers_y), value);
        }

        public static int spareMarkers_w
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.spareMarkers_w));
           set => PlayerData.instance.SetInt(nameof(PlayerData.spareMarkers_w), value);
        }

        public static List<UnityEngine.Vector3> placedMarkers_r
        {
            get => PlayerData.instance.GetVariable<List<UnityEngine.Vector3>>(nameof(PlayerData.placedMarkers_r));
            set => PlayerData.instance.SetVariable<List<UnityEngine.Vector3>>(nameof(PlayerData.placedMarkers_r), value);
        }

        public static List<UnityEngine.Vector3> placedMarkers_b
        {
            get => PlayerData.instance.GetVariable<List<UnityEngine.Vector3>>(nameof(PlayerData.placedMarkers_b));
            set => PlayerData.instance.SetVariable<List<UnityEngine.Vector3>>(nameof(PlayerData.placedMarkers_b), value);
        }

        public static List<UnityEngine.Vector3> placedMarkers_y
        {
            get => PlayerData.instance.GetVariable<List<UnityEngine.Vector3>>(nameof(PlayerData.placedMarkers_y));
            set => PlayerData.instance.SetVariable<List<UnityEngine.Vector3>>(nameof(PlayerData.placedMarkers_y), value);
        }

        public static List<UnityEngine.Vector3> placedMarkers_w
        {
            get => PlayerData.instance.GetVariable<List<UnityEngine.Vector3>>(nameof(PlayerData.placedMarkers_w));
            set => PlayerData.instance.SetVariable<List<UnityEngine.Vector3>>(nameof(PlayerData.placedMarkers_w), value);
        }

        public static int environmentType
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.environmentType));
           set => PlayerData.instance.SetInt(nameof(PlayerData.environmentType), value);
        }

        public static int environmentTypeDefault
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.environmentTypeDefault));
           set => PlayerData.instance.SetInt(nameof(PlayerData.environmentTypeDefault), value);
        }

        public static int previousDarkness
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.previousDarkness));
           set => PlayerData.instance.SetInt(nameof(PlayerData.previousDarkness), value);
        }

        public static bool openedTramLower
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedTramLower));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedTramLower), value);
        }

        public static bool openedTramRestingGrounds
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedTramRestingGrounds));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedTramRestingGrounds), value);
        }

        public static int tramLowerPosition
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.tramLowerPosition));
           set => PlayerData.instance.SetInt(nameof(PlayerData.tramLowerPosition), value);
        }

        public static int tramRestingGroundsPosition
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.tramRestingGroundsPosition));
           set => PlayerData.instance.SetInt(nameof(PlayerData.tramRestingGroundsPosition), value);
        }

        public static bool mineLiftOpened
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mineLiftOpened));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mineLiftOpened), value);
        }

        public static bool menderDoorOpened
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.menderDoorOpened));
            set => PlayerData.instance.SetBool(nameof(PlayerData.menderDoorOpened), value);
        }

        public static bool vesselFragStagNest
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.vesselFragStagNest));
            set => PlayerData.instance.SetBool(nameof(PlayerData.vesselFragStagNest), value);
        }

        public static bool shamanPillar
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.shamanPillar));
            set => PlayerData.instance.SetBool(nameof(PlayerData.shamanPillar), value);
        }

        public static bool crossroadsMawlekWall
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.crossroadsMawlekWall));
            set => PlayerData.instance.SetBool(nameof(PlayerData.crossroadsMawlekWall), value);
        }

        public static bool eggTempleVisited
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.eggTempleVisited));
            set => PlayerData.instance.SetBool(nameof(PlayerData.eggTempleVisited), value);
        }

        public static bool crossroadsInfected
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.crossroadsInfected));
            set => PlayerData.instance.SetBool(nameof(PlayerData.crossroadsInfected), value);
        }

        public static bool falseKnightFirstPlop
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.falseKnightFirstPlop));
            set => PlayerData.instance.SetBool(nameof(PlayerData.falseKnightFirstPlop), value);
        }

        public static bool falseKnightWallRepaired
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.falseKnightWallRepaired));
            set => PlayerData.instance.SetBool(nameof(PlayerData.falseKnightWallRepaired), value);
        }

        public static bool falseKnightWallBroken
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.falseKnightWallBroken));
            set => PlayerData.instance.SetBool(nameof(PlayerData.falseKnightWallBroken), value);
        }

        public static bool falseKnightGhostDeparted
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.falseKnightGhostDeparted));
            set => PlayerData.instance.SetBool(nameof(PlayerData.falseKnightGhostDeparted), value);
        }

        public static bool spaBugsEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.spaBugsEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.spaBugsEncountered), value);
        }

        public static bool hornheadVinePlat
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hornheadVinePlat));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hornheadVinePlat), value);
        }

        public static bool infectedKnightEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.infectedKnightEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.infectedKnightEncountered), value);
        }

        public static bool megaMossChargerEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.megaMossChargerEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.megaMossChargerEncountered), value);
        }

        public static bool megaMossChargerDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.megaMossChargerDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.megaMossChargerDefeated), value);
        }

        public static bool dreamerScene1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamerScene1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamerScene1), value);
        }

        public static bool slugEncounterComplete
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slugEncounterComplete));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slugEncounterComplete), value);
        }

        public static bool defeatedDoubleBlockers
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.defeatedDoubleBlockers));
            set => PlayerData.instance.SetBool(nameof(PlayerData.defeatedDoubleBlockers), value);
        }

        public static bool oneWayArchive
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.oneWayArchive));
            set => PlayerData.instance.SetBool(nameof(PlayerData.oneWayArchive), value);
        }

        public static bool defeatedMegaJelly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.defeatedMegaJelly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.defeatedMegaJelly), value);
        }

        public static bool summonedMonomon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.summonedMonomon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.summonedMonomon), value);
        }

        public static bool sawWoundedQuirrel
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.sawWoundedQuirrel));
            set => PlayerData.instance.SetBool(nameof(PlayerData.sawWoundedQuirrel), value);
        }

        public static bool encounteredMegaJelly
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.encounteredMegaJelly));
            set => PlayerData.instance.SetBool(nameof(PlayerData.encounteredMegaJelly), value);
        }

        public static bool defeatedMantisLords
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.defeatedMantisLords));
            set => PlayerData.instance.SetBool(nameof(PlayerData.defeatedMantisLords), value);
        }

        public static bool encounteredGatekeeper
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.encounteredGatekeeper));
            set => PlayerData.instance.SetBool(nameof(PlayerData.encounteredGatekeeper), value);
        }

        public static bool deepnestWall
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.deepnestWall));
            set => PlayerData.instance.SetBool(nameof(PlayerData.deepnestWall), value);
        }

        public static bool queensStationNonDisplay
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queensStationNonDisplay));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queensStationNonDisplay), value);
        }

        public static bool cityBridge1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.cityBridge1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.cityBridge1), value);
        }

        public static bool cityBridge2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.cityBridge2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.cityBridge2), value);
        }

        public static bool cityLift1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.cityLift1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.cityLift1), value);
        }

        public static bool cityLift1_isUp
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.cityLift1_isUp));
            set => PlayerData.instance.SetBool(nameof(PlayerData.cityLift1_isUp), value);
        }

        public static bool liftArrival
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.liftArrival));
            set => PlayerData.instance.SetBool(nameof(PlayerData.liftArrival), value);
        }

        public static bool openedMageDoor
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedMageDoor));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedMageDoor), value);
        }

        public static bool openedMageDoor_v2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedMageDoor_v2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedMageDoor_v2), value);
        }

        public static bool brokenMageWindow
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brokenMageWindow));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brokenMageWindow), value);
        }

        public static bool brokenMageWindowGlass
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brokenMageWindowGlass));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brokenMageWindowGlass), value);
        }

        public static bool mageLordEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mageLordEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mageLordEncountered), value);
        }

        public static bool mageLordEncountered_2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mageLordEncountered_2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mageLordEncountered_2), value);
        }

        public static bool mageLordDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.mageLordDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.mageLordDefeated), value);
        }

        public static bool ruins1_5_tripleDoor
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.ruins1_5_tripleDoor));
            set => PlayerData.instance.SetBool(nameof(PlayerData.ruins1_5_tripleDoor), value);
        }

        public static bool openedCityGate
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedCityGate));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedCityGate), value);
        }

        public static bool cityGateClosed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.cityGateClosed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.cityGateClosed), value);
        }

        public static bool bathHouseOpened
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bathHouseOpened));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bathHouseOpened), value);
        }

        public static bool bathHouseWall
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bathHouseWall));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bathHouseWall), value);
        }

        public static bool cityLift2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.cityLift2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.cityLift2), value);
        }

        public static bool cityLift2_isUp
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.cityLift2_isUp));
            set => PlayerData.instance.SetBool(nameof(PlayerData.cityLift2_isUp), value);
        }

        public static bool city2_sewerDoor
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.city2_sewerDoor));
            set => PlayerData.instance.SetBool(nameof(PlayerData.city2_sewerDoor), value);
        }

        public static bool openedLoveDoor
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedLoveDoor));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedLoveDoor), value);
        }

        public static bool watcherChandelier
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.watcherChandelier));
            set => PlayerData.instance.SetBool(nameof(PlayerData.watcherChandelier), value);
        }

        public static bool completedQuakeArea
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.completedQuakeArea));
            set => PlayerData.instance.SetBool(nameof(PlayerData.completedQuakeArea), value);
        }

        public static bool kingsStationNonDisplay
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.kingsStationNonDisplay));
            set => PlayerData.instance.SetBool(nameof(PlayerData.kingsStationNonDisplay), value);
        }

        public static bool tollBenchCity
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tollBenchCity));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tollBenchCity), value);
        }

        public static bool waterwaysGate
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.waterwaysGate));
            set => PlayerData.instance.SetBool(nameof(PlayerData.waterwaysGate), value);
        }

        public static bool defeatedDungDefender
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.defeatedDungDefender));
            set => PlayerData.instance.SetBool(nameof(PlayerData.defeatedDungDefender), value);
        }

        public static bool dungDefenderEncounterReady
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderEncounterReady));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderEncounterReady), value);
        }

        public static bool flukeMotherEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.flukeMotherEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.flukeMotherEncountered), value);
        }

        public static bool flukeMotherDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.flukeMotherDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.flukeMotherDefeated), value);
        }

        public static bool openedWaterwaysManhole
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedWaterwaysManhole));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedWaterwaysManhole), value);
        }

        public static bool waterwaysAcidDrained
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.waterwaysAcidDrained));
            set => PlayerData.instance.SetBool(nameof(PlayerData.waterwaysAcidDrained), value);
        }

        public static bool dungDefenderWallBroken
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderWallBroken));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderWallBroken), value);
        }

        public static bool dungDefenderSleeping
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dungDefenderSleeping));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dungDefenderSleeping), value);
        }

        public static bool defeatedMegaBeamMiner
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.defeatedMegaBeamMiner));
            set => PlayerData.instance.SetBool(nameof(PlayerData.defeatedMegaBeamMiner), value);
        }

        public static bool defeatedMegaBeamMiner2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.defeatedMegaBeamMiner2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.defeatedMegaBeamMiner2), value);
        }

        public static bool brokeMinersWall
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brokeMinersWall));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brokeMinersWall), value);
        }

        public static bool encounteredMimicSpider
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.encounteredMimicSpider));
            set => PlayerData.instance.SetBool(nameof(PlayerData.encounteredMimicSpider), value);
        }

        public static bool steppedBeyondBridge
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.steppedBeyondBridge));
            set => PlayerData.instance.SetBool(nameof(PlayerData.steppedBeyondBridge), value);
        }

        public static bool deepnestBridgeCollapsed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.deepnestBridgeCollapsed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.deepnestBridgeCollapsed), value);
        }

        public static bool spiderCapture
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.spiderCapture));
            set => PlayerData.instance.SetBool(nameof(PlayerData.spiderCapture), value);
        }

        public static bool deepnest26b_switch
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.deepnest26b_switch));
            set => PlayerData.instance.SetBool(nameof(PlayerData.deepnest26b_switch), value);
        }

        public static bool openedRestingGrounds02
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedRestingGrounds02));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedRestingGrounds02), value);
        }

        public static bool restingGroundsCryptWall
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.restingGroundsCryptWall));
            set => PlayerData.instance.SetBool(nameof(PlayerData.restingGroundsCryptWall), value);
        }

        public static bool dreamNailConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.dreamNailConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.dreamNailConvo), value);
        }

        public static int gladeGhostsKilled
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.gladeGhostsKilled));
           set => PlayerData.instance.SetInt(nameof(PlayerData.gladeGhostsKilled), value);
        }

        public static bool openedGardensStagStation
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedGardensStagStation));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedGardensStagStation), value);
        }

        public static bool extendedGramophone
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.extendedGramophone));
            set => PlayerData.instance.SetBool(nameof(PlayerData.extendedGramophone), value);
        }

        public static bool tollBenchQueensGardens
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tollBenchQueensGardens));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tollBenchQueensGardens), value);
        }

        public static bool blizzardEnded
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.blizzardEnded));
            set => PlayerData.instance.SetBool(nameof(PlayerData.blizzardEnded), value);
        }

        public static bool encounteredHornet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.encounteredHornet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.encounteredHornet), value);
        }

        public static bool savedByHornet
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.savedByHornet));
            set => PlayerData.instance.SetBool(nameof(PlayerData.savedByHornet), value);
        }

        public static bool outskirtsWall
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.outskirtsWall));
            set => PlayerData.instance.SetBool(nameof(PlayerData.outskirtsWall), value);
        }

        public static bool abyssGateOpened
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.abyssGateOpened));
            set => PlayerData.instance.SetBool(nameof(PlayerData.abyssGateOpened), value);
        }

        public static bool abyssLighthouse
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.abyssLighthouse));
            set => PlayerData.instance.SetBool(nameof(PlayerData.abyssLighthouse), value);
        }

        public static bool blueVineDoor
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.blueVineDoor));
            set => PlayerData.instance.SetBool(nameof(PlayerData.blueVineDoor), value);
        }

        public static bool gotShadeCharm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotShadeCharm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotShadeCharm), value);
        }

        public static bool tollBenchAbyss
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tollBenchAbyss));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tollBenchAbyss), value);
        }

        public static int fountainGeo
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.fountainGeo));
           set => PlayerData.instance.SetInt(nameof(PlayerData.fountainGeo), value);
        }

        public static bool fountainVesselSummoned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.fountainVesselSummoned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.fountainVesselSummoned), value);
        }

        public static bool openedBlackEggPath
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedBlackEggPath));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedBlackEggPath), value);
        }

        public static bool enteredDreamWorld
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.enteredDreamWorld));
            set => PlayerData.instance.SetBool(nameof(PlayerData.enteredDreamWorld), value);
        }

        public static bool duskKnightDefeated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.duskKnightDefeated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.duskKnightDefeated), value);
        }

        public static bool whitePalaceOrb_1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.whitePalaceOrb_1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.whitePalaceOrb_1), value);
        }

        public static bool whitePalaceOrb_2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.whitePalaceOrb_2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.whitePalaceOrb_2), value);
        }

        public static bool whitePalaceOrb_3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.whitePalaceOrb_3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.whitePalaceOrb_3), value);
        }

        public static bool whitePalace05_lever
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.whitePalace05_lever));
            set => PlayerData.instance.SetBool(nameof(PlayerData.whitePalace05_lever), value);
        }

        public static bool whitePalaceMidWarp
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.whitePalaceMidWarp));
            set => PlayerData.instance.SetBool(nameof(PlayerData.whitePalaceMidWarp), value);
        }

        public static bool whitePalaceSecretRoomVisited
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.whitePalaceSecretRoomVisited));
            set => PlayerData.instance.SetBool(nameof(PlayerData.whitePalaceSecretRoomVisited), value);
        }

        public static bool tramOpenedDeepnest
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tramOpenedDeepnest));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tramOpenedDeepnest), value);
        }

        public static bool tramOpenedCrossroads
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.tramOpenedCrossroads));
            set => PlayerData.instance.SetBool(nameof(PlayerData.tramOpenedCrossroads), value);
        }

        public static bool openedBlackEggDoor
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.openedBlackEggDoor));
            set => PlayerData.instance.SetBool(nameof(PlayerData.openedBlackEggDoor), value);
        }

        public static bool unchainedHollowKnight
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.unchainedHollowKnight));
            set => PlayerData.instance.SetBool(nameof(PlayerData.unchainedHollowKnight), value);
        }

        public static int flamesCollected
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.flamesCollected));
           set => PlayerData.instance.SetInt(nameof(PlayerData.flamesCollected), value);
        }

        public static int flamesRequired
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.flamesRequired));
           set => PlayerData.instance.SetInt(nameof(PlayerData.flamesRequired), value);
        }

        public static bool nightmareLanternAppeared
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nightmareLanternAppeared));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nightmareLanternAppeared), value);
        }

        public static bool nightmareLanternLit
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nightmareLanternLit));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nightmareLanternLit), value);
        }

        public static bool troupeInTown
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.troupeInTown));
            set => PlayerData.instance.SetBool(nameof(PlayerData.troupeInTown), value);
        }

        public static bool divineInTown
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.divineInTown));
            set => PlayerData.instance.SetBool(nameof(PlayerData.divineInTown), value);
        }

        public static int grimmChildLevel
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.grimmChildLevel));
           set => PlayerData.instance.SetInt(nameof(PlayerData.grimmChildLevel), value);
        }

        public static bool elderbugConvoGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugConvoGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugConvoGrimm), value);
        }

        public static bool slyConvoGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyConvoGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyConvoGrimm), value);
        }

        public static bool iseldaConvoGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.iseldaConvoGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.iseldaConvoGrimm), value);
        }

        public static bool midwifeWeaverlingConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.midwifeWeaverlingConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.midwifeWeaverlingConvo), value);
        }

        public static bool metGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metGrimm), value);
        }

        public static bool foughtGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.foughtGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.foughtGrimm), value);
        }

        public static bool metBrum
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metBrum));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metBrum), value);
        }

        public static bool defeatedNightmareGrimm
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.defeatedNightmareGrimm));
            set => PlayerData.instance.SetBool(nameof(PlayerData.defeatedNightmareGrimm), value);
        }

        public static bool grimmchildAwoken
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.grimmchildAwoken));
            set => PlayerData.instance.SetBool(nameof(PlayerData.grimmchildAwoken), value);
        }

        public static bool gotBrummsFlame
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotBrummsFlame));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotBrummsFlame), value);
        }

        public static bool brummBrokeBrazier
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.brummBrokeBrazier));
            set => PlayerData.instance.SetBool(nameof(PlayerData.brummBrokeBrazier), value);
        }

        public static bool destroyedNightmareLantern
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.destroyedNightmareLantern));
            set => PlayerData.instance.SetBool(nameof(PlayerData.destroyedNightmareLantern), value);
        }

        public static bool gotGrimmNotch
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gotGrimmNotch));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gotGrimmNotch), value);
        }

        public static bool nymmInTown
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nymmInTown));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nymmInTown), value);
        }

        public static bool nymmSpoken
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nymmSpoken));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nymmSpoken), value);
        }

        public static bool nymmCharmConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nymmCharmConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nymmCharmConvo), value);
        }

        public static bool nymmFinalConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nymmFinalConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nymmFinalConvo), value);
        }

        public static bool elderbugNymmConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugNymmConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugNymmConvo), value);
        }

        public static bool slyNymmConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.slyNymmConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.slyNymmConvo), value);
        }

        public static bool iseldaNymmConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.iseldaNymmConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.iseldaNymmConvo), value);
        }

        public static bool nymmMissedEggOpen
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nymmMissedEggOpen));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nymmMissedEggOpen), value);
        }

        public static bool elderbugTroupeLeftConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugTroupeLeftConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugTroupeLeftConvo), value);
        }

        public static bool elderbugBrettaLeft
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.elderbugBrettaLeft));
            set => PlayerData.instance.SetBool(nameof(PlayerData.elderbugBrettaLeft), value);
        }

        public static bool jijiGrimmConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.jijiGrimmConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.jijiGrimmConvo), value);
        }

        public static bool metDivine
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.metDivine));
            set => PlayerData.instance.SetBool(nameof(PlayerData.metDivine), value);
        }

        public static bool divineFinalConvo
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.divineFinalConvo));
            set => PlayerData.instance.SetBool(nameof(PlayerData.divineFinalConvo), value);
        }

        public static bool gaveFragileHeart
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gaveFragileHeart));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gaveFragileHeart), value);
        }

        public static bool gaveFragileGreed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gaveFragileGreed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gaveFragileGreed), value);
        }

        public static bool gaveFragileStrength
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.gaveFragileStrength));
            set => PlayerData.instance.SetBool(nameof(PlayerData.gaveFragileStrength), value);
        }

        public static int divineEatenConvos
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.divineEatenConvos));
           set => PlayerData.instance.SetInt(nameof(PlayerData.divineEatenConvos), value);
        }

        public static bool pooedFragileHeart
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.pooedFragileHeart));
            set => PlayerData.instance.SetBool(nameof(PlayerData.pooedFragileHeart), value);
        }

        public static bool pooedFragileGreed
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.pooedFragileGreed));
            set => PlayerData.instance.SetBool(nameof(PlayerData.pooedFragileGreed), value);
        }

        public static bool pooedFragileStrength
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.pooedFragileStrength));
            set => PlayerData.instance.SetBool(nameof(PlayerData.pooedFragileStrength), value);
        }

        public static float completionPercentage
        {
            get => PlayerData.instance.GetFloat(nameof(PlayerData.completionPercentage));
            set => PlayerData.instance.SetFloat(nameof(PlayerData.completionPercentage), value);
        }

        public static bool disablePause
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.disablePause));
            set => PlayerData.instance.SetBool(nameof(PlayerData.disablePause), value);
        }

        public static bool backerCredits
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.backerCredits));
            set => PlayerData.instance.SetBool(nameof(PlayerData.backerCredits), value);
        }

        public static bool unlockedCompletionRate
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.unlockedCompletionRate));
            set => PlayerData.instance.SetBool(nameof(PlayerData.unlockedCompletionRate), value);
        }

        public static int mapKeyPref
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.mapKeyPref));
           set => PlayerData.instance.SetInt(nameof(PlayerData.mapKeyPref), value);
        }

        public static List<System.String> playerStory
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.playerStory));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.playerStory), value);
        }

        public static string playerStoryOutput
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.playerStoryOutput));
            set => PlayerData.instance.SetString(nameof(PlayerData.playerStoryOutput), value);
        }

        public static bool betaEnd
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.betaEnd));
            set => PlayerData.instance.SetBool(nameof(PlayerData.betaEnd), value);
        }

        public static bool newDatTraitorLord
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.newDatTraitorLord));
            set => PlayerData.instance.SetBool(nameof(PlayerData.newDatTraitorLord), value);
        }

        public static string bossReturnEntryGate
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.bossReturnEntryGate));
            set => PlayerData.instance.SetString(nameof(PlayerData.bossReturnEntryGate), value);
        }

        public static BossSequenceDoor.Completion bossDoorStateTier1
        {
            get => PlayerData.instance.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier1));
            set => PlayerData.instance.SetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier1), value);
        }

        public static BossSequenceDoor.Completion bossDoorStateTier2
        {
            get => PlayerData.instance.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier2));
            set => PlayerData.instance.SetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier2), value);
        }

        public static BossSequenceDoor.Completion bossDoorStateTier3
        {
            get => PlayerData.instance.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier3));
            set => PlayerData.instance.SetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier3), value);
        }

        public static BossSequenceDoor.Completion bossDoorStateTier4
        {
            get => PlayerData.instance.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier4));
            set => PlayerData.instance.SetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier4), value);
        }

        public static BossSequenceDoor.Completion bossDoorStateTier5
        {
            get => PlayerData.instance.GetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier5));
            set => PlayerData.instance.SetVariable<BossSequenceDoor.Completion>(nameof(PlayerData.bossDoorStateTier5), value);
        }

        public static int bossStatueTargetLevel
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.bossStatueTargetLevel));
           set => PlayerData.instance.SetInt(nameof(PlayerData.bossStatueTargetLevel), value);
        }

        public static string currentBossStatueCompletionKey
        {
            get => PlayerData.instance.GetString(nameof(PlayerData.currentBossStatueCompletionKey));
            set => PlayerData.instance.SetString(nameof(PlayerData.currentBossStatueCompletionKey), value);
        }

        public static BossStatue.Completion statueStateGruzMother
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGruzMother));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGruzMother), value);
        }

        public static BossStatue.Completion statueStateVengefly
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateVengefly));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateVengefly), value);
        }

        public static BossStatue.Completion statueStateBroodingMawlek
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateBroodingMawlek));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateBroodingMawlek), value);
        }

        public static BossStatue.Completion statueStateFalseKnight
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateFalseKnight));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateFalseKnight), value);
        }

        public static BossStatue.Completion statueStateFailedChampion
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateFailedChampion));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateFailedChampion), value);
        }

        public static BossStatue.Completion statueStateHornet1
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHornet1));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHornet1), value);
        }

        public static BossStatue.Completion statueStateHornet2
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHornet2));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHornet2), value);
        }

        public static BossStatue.Completion statueStateMegaMossCharger
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMegaMossCharger));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMegaMossCharger), value);
        }

        public static BossStatue.Completion statueStateMantisLords
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMantisLords));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMantisLords), value);
        }

        public static BossStatue.Completion statueStateOblobbles
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateOblobbles));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateOblobbles), value);
        }

        public static BossStatue.Completion statueStateGreyPrince
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGreyPrince));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGreyPrince), value);
        }

        public static BossStatue.Completion statueStateBrokenVessel
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateBrokenVessel));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateBrokenVessel), value);
        }

        public static BossStatue.Completion statueStateLostKin
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateLostKin));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateLostKin), value);
        }

        public static BossStatue.Completion statueStateNosk
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNosk));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNosk), value);
        }

        public static BossStatue.Completion statueStateFlukemarm
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateFlukemarm));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateFlukemarm), value);
        }

        public static BossStatue.Completion statueStateCollector
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateCollector));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateCollector), value);
        }

        public static BossStatue.Completion statueStateWatcherKnights
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateWatcherKnights));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateWatcherKnights), value);
        }

        public static BossStatue.Completion statueStateSoulMaster
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateSoulMaster));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateSoulMaster), value);
        }

        public static BossStatue.Completion statueStateSoulTyrant
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateSoulTyrant));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateSoulTyrant), value);
        }

        public static BossStatue.Completion statueStateGodTamer
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGodTamer));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGodTamer), value);
        }

        public static BossStatue.Completion statueStateCrystalGuardian1
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateCrystalGuardian1));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateCrystalGuardian1), value);
        }

        public static BossStatue.Completion statueStateCrystalGuardian2
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateCrystalGuardian2));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateCrystalGuardian2), value);
        }

        public static BossStatue.Completion statueStateUumuu
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateUumuu));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateUumuu), value);
        }

        public static BossStatue.Completion statueStateDungDefender
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateDungDefender));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateDungDefender), value);
        }

        public static BossStatue.Completion statueStateWhiteDefender
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateWhiteDefender));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateWhiteDefender), value);
        }

        public static BossStatue.Completion statueStateHiveKnight
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHiveKnight));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHiveKnight), value);
        }

        public static BossStatue.Completion statueStateTraitorLord
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateTraitorLord));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateTraitorLord), value);
        }

        public static BossStatue.Completion statueStateGrimm
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGrimm));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGrimm), value);
        }

        public static BossStatue.Completion statueStateNightmareGrimm
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNightmareGrimm));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNightmareGrimm), value);
        }

        public static BossStatue.Completion statueStateHollowKnight
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHollowKnight));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateHollowKnight), value);
        }

        public static BossStatue.Completion statueStateElderHu
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateElderHu));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateElderHu), value);
        }

        public static BossStatue.Completion statueStateGalien
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGalien));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGalien), value);
        }

        public static BossStatue.Completion statueStateMarkoth
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMarkoth));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMarkoth), value);
        }

        public static BossStatue.Completion statueStateMarmu
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMarmu));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMarmu), value);
        }

        public static BossStatue.Completion statueStateNoEyes
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNoEyes));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNoEyes), value);
        }

        public static BossStatue.Completion statueStateXero
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateXero));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateXero), value);
        }

        public static BossStatue.Completion statueStateGorb
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGorb));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateGorb), value);
        }

        public static BossStatue.Completion statueStateRadiance
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateRadiance));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateRadiance), value);
        }

        public static BossStatue.Completion statueStateSly
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateSly));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateSly), value);
        }

        public static BossStatue.Completion statueStateNailmasters
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNailmasters));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNailmasters), value);
        }

        public static BossStatue.Completion statueStateMageKnight
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMageKnight));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMageKnight), value);
        }

        public static BossStatue.Completion statueStatePaintmaster
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStatePaintmaster));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStatePaintmaster), value);
        }

        public static BossStatue.Completion statueStateZote
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateZote));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateZote), value);
        }

        public static BossStatue.Completion statueStateNoskHornet
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNoskHornet));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateNoskHornet), value);
        }

        public static BossStatue.Completion statueStateMantisLordsExtra
        {
            get => PlayerData.instance.GetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMantisLordsExtra));
            set => PlayerData.instance.SetVariable<BossStatue.Completion>(nameof(PlayerData.statueStateMantisLordsExtra), value);
        }

        public static bool godseekerUnlocked
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.godseekerUnlocked));
            set => PlayerData.instance.SetBool(nameof(PlayerData.godseekerUnlocked), value);
        }

        public static BossSequenceController.BossSequenceData currentBossSequence
        {
            get => PlayerData.instance.GetVariable<BossSequenceController.BossSequenceData>(nameof(PlayerData.currentBossSequence));
            set => PlayerData.instance.SetVariable<BossSequenceController.BossSequenceData>(nameof(PlayerData.currentBossSequence), value);
        }

        public static bool bossRushMode
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bossRushMode));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bossRushMode), value);
        }

        public static bool bossDoorCageUnlocked
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.bossDoorCageUnlocked));
            set => PlayerData.instance.SetBool(nameof(PlayerData.bossDoorCageUnlocked), value);
        }

        public static bool blueRoomDoorUnlocked
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.blueRoomDoorUnlocked));
            set => PlayerData.instance.SetBool(nameof(PlayerData.blueRoomDoorUnlocked), value);
        }

        public static bool blueRoomActivated
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.blueRoomActivated));
            set => PlayerData.instance.SetBool(nameof(PlayerData.blueRoomActivated), value);
        }

        public static bool finalBossDoorUnlocked
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.finalBossDoorUnlocked));
            set => PlayerData.instance.SetBool(nameof(PlayerData.finalBossDoorUnlocked), value);
        }

        public static bool hasGodfinder
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.hasGodfinder));
            set => PlayerData.instance.SetBool(nameof(PlayerData.hasGodfinder), value);
        }

        public static bool unlockedNewBossStatue
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.unlockedNewBossStatue));
            set => PlayerData.instance.SetBool(nameof(PlayerData.unlockedNewBossStatue), value);
        }

        public static bool scaredFlukeHermitEncountered
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.scaredFlukeHermitEncountered));
            set => PlayerData.instance.SetBool(nameof(PlayerData.scaredFlukeHermitEncountered), value);
        }

        public static bool scaredFlukeHermitReturned
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.scaredFlukeHermitReturned));
            set => PlayerData.instance.SetBool(nameof(PlayerData.scaredFlukeHermitReturned), value);
        }

        public static bool enteredGGAtrium
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.enteredGGAtrium));
            set => PlayerData.instance.SetBool(nameof(PlayerData.enteredGGAtrium), value);
        }

        public static bool extraFlowerAppear
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.extraFlowerAppear));
            set => PlayerData.instance.SetBool(nameof(PlayerData.extraFlowerAppear), value);
        }

        public static bool givenGodseekerFlower
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.givenGodseekerFlower));
            set => PlayerData.instance.SetBool(nameof(PlayerData.givenGodseekerFlower), value);
        }

        public static bool givenOroFlower
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.givenOroFlower));
            set => PlayerData.instance.SetBool(nameof(PlayerData.givenOroFlower), value);
        }

        public static bool givenWhiteLadyFlower
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.givenWhiteLadyFlower));
            set => PlayerData.instance.SetBool(nameof(PlayerData.givenWhiteLadyFlower), value);
        }

        public static bool givenEmilitiaFlower
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.givenEmilitiaFlower));
            set => PlayerData.instance.SetBool(nameof(PlayerData.givenEmilitiaFlower), value);
        }

        public static List<System.String> unlockedBossScenes
        {
            get => PlayerData.instance.GetVariable<List<System.String>>(nameof(PlayerData.unlockedBossScenes));
            set => PlayerData.instance.SetVariable<List<System.String>>(nameof(PlayerData.unlockedBossScenes), value);
        }

        public static bool queuedGodfinderIcon
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.queuedGodfinderIcon));
            set => PlayerData.instance.SetBool(nameof(PlayerData.queuedGodfinderIcon), value);
        }

        public static bool godseekerSpokenAwake
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.godseekerSpokenAwake));
            set => PlayerData.instance.SetBool(nameof(PlayerData.godseekerSpokenAwake), value);
        }

        public static bool nailsmithCorpseAppeared
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.nailsmithCorpseAppeared));
            set => PlayerData.instance.SetBool(nameof(PlayerData.nailsmithCorpseAppeared), value);
        }

        public static int godseekerWaterwaysSeenState
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.godseekerWaterwaysSeenState));
           set => PlayerData.instance.SetInt(nameof(PlayerData.godseekerWaterwaysSeenState), value);
        }

        public static bool godseekerWaterwaysSpoken1
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.godseekerWaterwaysSpoken1));
            set => PlayerData.instance.SetBool(nameof(PlayerData.godseekerWaterwaysSpoken1), value);
        }

        public static bool godseekerWaterwaysSpoken2
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.godseekerWaterwaysSpoken2));
            set => PlayerData.instance.SetBool(nameof(PlayerData.godseekerWaterwaysSpoken2), value);
        }

        public static bool godseekerWaterwaysSpoken3
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.godseekerWaterwaysSpoken3));
            set => PlayerData.instance.SetBool(nameof(PlayerData.godseekerWaterwaysSpoken3), value);
        }

        public static int bossDoorEntranceTextSeen
        {
            get => PlayerData.instance.GetInt(nameof(PlayerData.bossDoorEntranceTextSeen));
           set => PlayerData.instance.SetInt(nameof(PlayerData.bossDoorEntranceTextSeen), value);
        }

        public static bool seenDoor4Finale
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.seenDoor4Finale));
            set => PlayerData.instance.SetBool(nameof(PlayerData.seenDoor4Finale), value);
        }

        public static bool zoteStatueWallBroken
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.zoteStatueWallBroken));
            set => PlayerData.instance.SetBool(nameof(PlayerData.zoteStatueWallBroken), value);
        }

        public static bool seenGGWastes
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.seenGGWastes));
            set => PlayerData.instance.SetBool(nameof(PlayerData.seenGGWastes), value);
        }

        public static bool ordealAchieved
        {
            get => PlayerData.instance.GetBool(nameof(PlayerData.ordealAchieved));
            set => PlayerData.instance.SetBool(nameof(PlayerData.ordealAchieved), value);
        }
    }
}