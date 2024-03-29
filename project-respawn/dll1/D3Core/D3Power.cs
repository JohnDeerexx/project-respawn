using System;
namespace D3Core
{
	public enum D3Power : uint
	{
		Invalid,
		AI_FollowWithWalk = 1728u,
		AI_Wander,
		Barrel_Explode_Instant = 1736u,
		CryptChildEat = 1738u,
		Templar_Heal = 1747u,
		Scavenger_Leap = 1752u,
		UseItem = 1759u,
		Wizard_Electrocute = 1765u,
		Wizard_SlowTime = 1769u,
		ZombieKillerGrab = 1771u,
		AI_Circle = 29986u,
		AI_Circle_Long,
		AI_Close = 29990u,
		AI_Close_Long,
		AI_Follow = 29993u,
		AI_FollowPath,
		AI_Follow_Close,
		AI_Idle,
		AI_Idle_Long,
		AI_Idle_Short,
		AI_ReturnToPath = 30000u,
		AI_RunAway,
		AI_RunAway_Long,
		AI_RunAway_Short,
		AI_RunInFront,
		AI_RunNearby,
		AI_RunNearby_Short = 30008u,
		AI_RunTo,
		AI_WalkTo = 30013u,
		AI_WanderRun,
		AI_Wander_Long,
		Axe_Bad_Data = 30020u,
		Axe_Operate_Gizmo,
		Axe_Operate_NPC,
		Trait_Barbarian_Fury = 30078u,
		Barbarian_GroundStompEffect = 30080u,
		BareHandedPassive = 30145u,
		BeastCharge = 30147u,
		BurrowOut = 30157u,
		BurrowStartBuff,
		ChampionClone = 30166u,
		ChampionTeleport,
		Cooldown = 30176u,
		CorpulentExplode = 30178u,
		CritDebuffCold = 30180u,
		CryptChildLeapOut = 30185u,
		CryptChildLeapOutBuff,
		DebuffChilled = 30195u,
		DestructableObjectChandelier_AOE = 30209u,
		DrinkHealthPotion = 30211u,
		EatCorpse = 30214u,
		GenericArrow_Projectile = 30242u,
		Ghost_Melee_Drain,
		Ghost_SoulSiphon,
		GizmoOperatePortalWithAnimation = 30249u,
		Goatman_Lightning_Shield = 30251u,
		Goatman_Moonclan_Ranged_Projectile,
		GraveDigger_Knockback_Attack = 30255u,
		GraveRobber_Dodge_Left,
		GraveRobber_Dodge_Right,
		graveRobber_Projectile,
		HealingWell_Heal = 30264u,
		Hearth,
		Hearth_Finish,
		ImmuneToFearDuringBuff = 30283u,
		ImmuneToRootDuringBuff,
		ImmuneToSnareDuringBuff,
		ImmuneToStunDuringBuff,
		Interact_Crouching,
		Interact_Normal,
		InvisibileDuringBuff,
		InvulnerableDuringBuff,
		Knockdown = 30296u,
		Laugh = 30307u,
		MagicPainting_Summon_Skeleton = 30313u,
		Monster_Ranged_Projectile = 30334u,
		Monster_Spell_Projectile = 30338u,
		NPC_LookAt = 30342u,
		OnDeathArcane,
		OnDeathCold,
		OnDeathFire,
		OnDeathLightning,
		OnDeathPoison,
		Operate_Helper_Attach,
		Templar_Inspire = 30356u,
		Templar_Loyalty,
		Templar_Guardian = 30359u,
		Templar_ShieldCharge,
		Proxy_Delayed_Power = 30385u,
		Punch = 30391u,
		RangedEscort_Projectile = 30394u,
		Resurrection_Buff = 30424u,
		Rockworm_Web = 30431u,
		RootTryGrab = 30433u,
		SandsharkBurrowIn = 30440u,
		ScavengerBurrowIn = 30450u,
		ScavengerBurrowOut,
		Scoundrel_Anatomy = 30454u,
		Scoundrel_Bandage,
		Scoundrel_Multishot = 30458u,
		Scoundrel_PoisonArrow = 30460u,
		Scoundrel_Vanish = 30464u,
		ScrollBuff = 30469u,
		SetMode_EscortFollow = 30471u,
		ShieldSkeleton_Shield = 30473u,
		Shield_Skeleton_Melee_Instant,
		Shrine_Desecrated_Blessed = 30476u,
		Shrine_Desecrated_Enlightened,
		Shrine_Desecrated_Fortune,
		Shrine_Desecrated_Frenzied,
		SkeletonArcher_Projectile = 30495u,
		SkeletonKing_Summon_Skeleton,
		skeletonMage_poison_death = 30501u,
		SkeletonSummoner_Projectile = 30503u,
		SkeletonKing_Cleave,
		SnakemanCaster_ElectricBurst = 30509u,
		Snakeman_MeleeStealth = 30512u,
		Snakeman_MeleeUnstealth,
		SporeCloud = 30525u,
		StealthBuff = 30527u,
		StitchExplode = 30529u,
		StitchMeleeAlternate,
		StitchPush,
		Suicide_Proc = 30538u,
		Summoned = 30540u,
		Summon_Skeleton = 30543u,
		Summon_Skeleton_OnSpawn = 30545u,
		Summon_Skeleton_Orb,
		Summon_Triune_Demon,
		Summon_Zombie_Crawler = 30550u,
		Thorns = 30554u,
		TransformToActivatedTriune = 30563u,
		TriuneBerserker_Hit = 30567u,
		TriuneSummoner_Projectile = 30570u,
		TriuneSummoner_Shield,
		TriuneSummoner_SplitSummonCast,
		TriuneVesselCharge,
		TriuneVesselOverpower,
		Unburied_Knockback = 30580u,
		Unburied_Melee_Attack,
		UntargetableDuringBuff,
		UseHealthGlyph = 30584u,
		UseManaGlyph,
		Walk = 30588u,
		Warp,
		Weapon_Melee_Instant = 30592u,
		Weapon_Melee_Instant_BothHand,
		Weapon_Melee_Instant_OffHand,
		Weapon_Melee_Obstruction,
		Weapon_Melee_Reach_Instant,
		Weapon_Ranged_Instant = 30598u,
		Weapon_Ranged_Projectile,
		Weapon_Ranged_Wand = 30601u,
		WitchDoctor_Gargantuan = 30624u,
		WitchDoctor_Hex = 30631u,
		Wizard_ArcaneOrb = 30668u,
		Wizard_Blizzard = 30680u,
		Wizard_EnergyShield = 30708u,
		Wizard_FrostNova = 30718u,
		Wizard_Hydra = 30725u,
		Wizard_MagicMissile = 30744u,
		Wizard_ShockPulse = 30783u,
		Wizard_WaveOfForce = 30796u,
		WoodWraithSummonSpores = 30800u,
		Trait_Monk_Spirit = 52753u,
		TreasureGoblinPause = 54055u,
		TreasureGoblin_ThrowPortal = 54836u,
		AI_Orbit = 55433u,
		Generic_Taunt = 60777u,
		Generic_SetUntargetable = 62666u,
		Generic_SetInvulnerable = 62731u,
		TarPitSlowOn = 67106u,
		WitchDoctor_Firebomb = 67567u,
		WitchDoctor_MassConfusion = 67600u,
		WitchDoctor_SoulHarvest = 67616u,
		WitchDoctor_Horrify = 67668u,
		Monk_BreathOfHeaven = 69130u,
		WitchDoctor_GraspOfTheDead = 69182u,
		Wizard_Meteor = 69190u,
		Monk_MantraOfRetribution = 69484u,
		Monk_ResistAura = 69489u,
		Monk_MantraOfHealing,
		WitchDoctor_CorpseSpiders = 69866u,
		WitchDoctor_Locust_Swarm,
		BurrowInSetup = 69949u,
		Barbarian_AncientSpear = 69979u,
		Weapon_Melee_NoClose = 70218u,
		MonsterAffix_Vampiric = 70309u,
		Knockback = 70432u,
		WitchDoctor_AcidCloud = 70455u,
		Barbarian_Rend = 70472u,
		MonsterAffix_ExtraHealth = 70650u,
		MonsterAffix_Knockback = 70655u,
		MonsterAffix_Fast = 70849u,
		MonsterAffix_Shaman = 70959u,
		MonsterAffix_Puppetmaster = 71023u,
		MonsterAffix_Puppetmaster_Minion,
		MonsterAffix_Illusionist = 71108u,
		MonsterAffix_Healthlink = 71239u,
		Wizard_SpectralBlades = 71548u,
		Brickhouse_Enrage = 72713u,
		WitchDoctor_FetishArmy = 72785u,
		Wizard_IceArmor = 73223u,
		HelperArcherProjectile = 73289u,
		SkeletonKing_Whirlwind = 73824u,
		WitchDoctor_ZombieCharger = 74003u,
		Wizard_StormArmor = 74499u,
		BurrowOut_NoFacing = 75226u,
		DemonHunter_SpikeTrap = 75301u,
		Wizard_DiamondSkin = 75599u,
		DemonHunter_EntanglingShot = 75873u,
		Generic_SetInvisible = 76107u,
		Wizard_MagicWeapon,
		Spider_Web_Slow = 76961u,
		Wizard_Hydra_RuneLightning_Prototype = 77065u,
		Wizard_Hydra_RuneAcid_Prototype,
		Wizard_Hydra_RuneArcane_Prototype,
		Wizard_Hydra_DefaultFire_Prototype,
		Wizard_EnergyTwister = 77113u,
		Goatman_Shaman_Lightningbolt = 77342u,
		DemonHunter_FanOfKnives = 77546u,
		DemonHunter_BolaShot = 77552u,
		DemonHunter_Multishot = 77649u,
		Barbarian_Frenzy = 78548u,
		Barbarian_Sprint = 78551u,
		Barbarian_BattleRage = 79076u,
		Barbarian_ThreateningShout,
		Barbarian_Bash = 79242u,
		SkeletonKing_Teleport = 79334u,
		Barbarian_GroundStomp = 79446u,
		UninterruptibleDuringBuff = 79486u,
		Barbarian_IgnorePain = 79528u,
		Barbarian_WrathOfTheBerserker = 79607u,
		Barbarian_HammerOfTheAncients = 80028u,
		Barbarian_CallOfTheAncients = 80049u,
		Barbarian_Cleave = 80263u,
		MonsterAffix_Electrified = 81420u,
		SkeletonKing_Teleport_Away = 81504u,
		Barbarian_WarCry = 81612u,
		Wizard_Hydra_RuneFrost_Prototype = 83040u,
		WitchDoctor_Haunt = 83602u,
		Wizard_Hydra_RuneBig_Prototype = 84030u,
		Enchantress_Cripple = 84469u,
		Laugh_SkeletonKing = 84699u,
		g_levelUp = 85954u,
		DamageAttribute = 86152u,
		EscortingBuff = 86241u,
		DemonHunter_Grenades = 86610u,
		Barbarian_SeismicSlam = 86989u,
		Wizard_EnergyArmor = 86991u,
		Hireling_Callout_BattleCry = 87093u,
		SkeletonKing_KillSummonedSkeletons = 87523u,
		Wizard_ExplosiveBlast = 87525u,
		MonsterAffix_Frozen = 90144u,
		MonsterAffix_Molten = 90314u,
		MonsterAffix_Plagued = 90566u,
		MonsterAffix_MissileDampening = 91028u,
		CopiedVisualEffectsBuff = 91052u,
		MonsterAffix_Ballista = 91098u,
		CalldownGrenade = 91155u,
		MonsterAffix_DieTogether = 91232u,
		trout_tristramfields_punji_trap_aoe = 91261u,
		Wizard_Disintegrate = 91549u,
		Wizard_RayOfFrost = 93395u,
		Barbarian_Leap = 93409u,
		ActorDisabledBuff = 93716u,
		Leah_Vortex = 93831u,
		Barbarian_WeaponThrow = 93885u,
		Templar_Onslaught = 93888u,
		Templar_Intimidate = 93901u,
		Templar_Intervene = 93938u,
		Templar_Intervene_Proc = 94008u,
		Summon_Zombie_Vomit = 94734u,
		Ghost_A_Unique_House1000Undead_Slow = 94972u,
		trout_tristramfields_punji_trap_mirror_aoe = 95387u,
		Monk_MantraOfConviction = 95572u,
		Scoundrel_CripplingShot = 95675u,
		Scoundrel_PowerShot = 95690u,
		DOTDebuff = 95701u,
		Monk_FistsOfThunder = 95940u,
		Monk_DeadlyReach = 96019u,
		Monk_WaveOfLight = 96033u,
		Monk_SweepingWind = 96090u,
		Monk_DashingStrike = 96203u,
		Monk_Serenity = 96215u,
		Barbarian_Whirlwind = 96296u,
		Monk_CripplingWave = 96311u,
		Monk_SevenSidedStrike = 96694u,
		Monk_WayOfTheHundredFists = 97110u,
		Monk_InnerSanctuary = 97222u,
		Monk_ExplodingPalm = 97328u,
		Barbarian_FuriousCharge = 97435u,
		Scoundrel_DirtyFighting,
		GoatmanDrumsBeating = 97497u,
		Wizard_MirrorImage = 98027u,
		Barbarian_Earthquake = 98878u,
		Goatman_Iceball = 99077u,
		GhostWalkThroughWalls = 99094u,
		Wizard_Familiar = 99120u,
		AIEvadeBuff = 99543u,
		Scoundrel_Ranged_Projectile = 99902u,
		Scoundrel_RunAway = 99904u,
		trOut_LogStack_Trap = 100287u,
		DebuffSlowed = 100971u,
		DebuffStunned = 101000u,
		DebuffFeared = 101002u,
		DebuffRooted,
		Enchantress_FocusedMind = 101425u,
		Enchantress_PoweredArmor = 101461u,
		Enchantress_ReflectMissiles_Proc = 101867u,
		Enchantress_ForcefulPush = 101969u,
		Enchantress_Disorient = 101990u,
		Enchantress_Charm = 102057u,
		Enchantress_ReflectMissiles = 102133u,
		Cain_Intro_Swing = 102449u,
		WitchDoctor_Sacrifice = 102572u,
		WitchDoctor_SummonZombieDogs,
		WitchDoctor_PoisonDart = 103181u,
		DebuffBlind = 103216u,
		Quest_CanyonBridge_Player_RevealFootsteps = 103337u,
		Quest_CanyonBridge_Enchantress_RevealFootsteps,
		AI_Follow_MeleeLead = 104514u,
		TreasureGoblin_Escape = 105371u,
		TreasureGoblin_ThrowPortal_Fast = 105665u,
		WitchDoctor_Firebats = 105963u,
		WitchDoctor_SpiritWalk = 106237u,
		AncientSpearKnockback = 106281u,
		WitchDoctor_PlagueOfToads = 106465u,
		WitchDoctor_PlagueOfToads_BigToadAttack = 106592u,
		WitchDoctor_CorpseSpider_Leap = 107103u,
		WitchDoctor_Hex_Fetish = 107301u,
		QuillDemon_Projectile = 107729u,
		WitchDoctor_Hex_Fetish_Heal = 107742u,
		WitchDoctor_SpiritBarrage = 108506u,
		Beast_Weapon_Melee_Instant = 109289u,
		Barbarian_Revenge = 109342u,
		Barbarian_Revenge_Buff = 109344u,
		Trait_WitchDoctor_ZombieDogSpawner_Passive = 109560u,
		MonsterAffix_Electrified_Minion = 109899u,
		ZombieFemale_Projectile = 110518u,
		DemonHunter_Vault = 111215u,
		Monk_LashingTailKick = 111676u,
		Weapon_Melee_Reach_Instant_Freeze_Facing = 115624u,
		Hireling_Callout_BattleFinished = 117323u,
		WitchDoctor_BigBadVoodoo = 117402u,
		Summoning_Machine_Summon = 117580u,
		HellPortalSummoningMachineActivate = 118226u,
		WitchDoctor_FetishArmy_Shaman = 118442u,
		WitchDoctor_FetishArmy_Hunter = 119166u,
		MonsterAffix_VortexCast = 120305u,
		MonsterAffix_VortexBuff,
		MonsterAffix_Pheonix = 120655u,
		Monk_TempestRush = 121442u,
		WitchDoctor_Gargantuan_Cleave = 121942u,
		WitchDoctor_Gargantuan_Slam,
		UnholyShield = 122977u,
		SetItemBonusBuff = 123014u,
		Goatman_Cold_Shield = 123158u,
		Monk_MysticAlly = 123208u,
		Frenzy_Affix = 123843u,
		DemonHunter_Preparation = 129212u,
		DemonHunter_Chakram,
		DemonHunter_ClusterArrow,
		DemonHunter_HungeringArrow,
		DemonHunter_Caltrops,
		DemonHunter_Sentry,
		Generic_SetCannotBeAddedToAITargetList = 129386u,
		Generic_SetObserver = 129393u,
		Generic_SetTakesNoDamage,
		Generic_SetDoesFakeDamage,
		DemonHunter_Sentry_TurretAttack = 129661u,
		DemonHunter_SmokeScreen = 130695u,
		DemonHunter_MarkedForDeath = 130738u,
		DemonFlyer_Projectile = 130798u,
		DemonHunter_ShadowPower = 130830u,
		DemonHunter_RainOfVengeance,
		DemonHunter_RapidFire = 131192u,
		BodyGuard_Teleport,
		DemonHunter_ElementalArrow = 131325u,
		DemonHunter_Impale = 131366u,
		GoatMutantEnrage = 131588u,
		GoatMutantGroundSmash = 131699u,
		PickupNearby = 131976u,
		Charmed_Weapon_Melee_Instant = 132695u,
		Charmed_Monster_Ranged_Projectile = 132698u,
		WarpInMagical = 132910u,
		DemonHunter_Companion = 133695u,
		DH_Companion_ChargeAttack = 133887u,
		DemonHunter_Strafe = 134030u,
		DemonHunter_EvasiveFire = 134209u,
		Callout_Cooldown = 134225u,
		DemonHunter_EvasiveFire_Flip = 134280u,
		Banter_Cooldown = 134334u,
		Wizard_ArcaneTorrent = 134456u,
		CoreElite_DropPod = 134816u,
		WitchDoctor_WallOfZombies = 134837u,
		Wizard_Archon = 134872u,
		Wizard_Archon_ArcaneStrike = 135166u,
		Wizard_Archon_DisintegrationWave = 135238u,
		Wizard_Archon_SlowTime = 135663u,
		Monk_BlindingFlash = 136954u,
		Monk_ResistAura_RuneC_Fire = 143382u,
		Monk_ResistAura_RuneC_Lightning = 144188u,
		Monk_ResistAura_RuneC_Cold = 144197u,
		Monk_ResistAura_RuneC_Poison = 144202u,
		MastaBlasta_Steed_Combine = 144289u,
		Monk_ResistAura_RuneC_Arcane = 144312u,
		Monk_ResistAura_RuneC_Holy = 144322u,
		PlagueOfToadsKnockback = 147876u,
		DH_rainofArrows_shadowBeast_bombDrop = 150075u,
		Camera_Focus_Buff = 151595u,
		Camera_Focus_Pet_Buff = 151604u,
		Unique_Monster_Generic_Projectile = 152540u,
		DemonHunter_Passive_Vengeance = 155714u,
		DemonHunter_Passive_Sharpshooter,
		DemonHunter_Passive_CullTheWeak = 155721u,
		DemonHunter_Passive_Perfectionist,
		DemonHunter_Passive_Ballistics,
		DemonHunter_Passive_HotPursuit = 155725u,
		MonsterAffix_TeleporterBuff = 155958u,
		MonsterAffix_TeleporterCast,
		MonsterAffix_DesecratorCast = 156105u,
		MonsterAffix_DesecratorBuff,
		Monk_Passive_ChantOfResonance = 156467u,
		Monk_Passive_NearDeathExperience = 156484u,
		Monk_Passive_GuidingLight = 156492u,
		Barbarian_Overpower = 159169u,
		AI_WalkTo_Guaranteed = 163333u,
		AI_WalkInFront_Guaranteed,
		AI_SprintTo_Guaranteed,
		AI_SprintInFront_Guaranteed,
		AI_RunTo_Guaranteed = 163338u,
		AI_RunInFront_Guaranteed,
		DemonHunter_Passive_SteadyAim = 164363u,
		UseArcaneGlyph = 165553u,
		Wizard_ArcaneTorrent_RuneC_Mine = 165598u,
		Wizard_Archon_Cancel = 166616u,
		Wizard_Archon_ArcaneBlast = 167355u,
		Wizard_Archon_Teleport = 167648u,
		Summon_Skeleton_Jondar = 168212u,
		Wizard_Teleport = 168344u,
		Barbarian_CallOfTheAncients_Cleave = 168823u,
		Barbarian_CallOfTheAncients_FuriousCharge,
		Barbarian_CallOfTheAncients_Leap,
		Barbarian_CallOfTheAncients_SeismicSlam = 168827u,
		Barbarian_CallOfTheAncients_WeaponThrow,
		Barbarian_CallOfTheAncients_Whirlwind = 168830u,
		Monk_MysticAlly_Pet_Weapon_Melee_Instant = 169081u,
		Monk_MysticAlly_Pet_RuneA_Kick = 169155u,
		Monk_MysticAlly_Pet_RuneB_WaveAttack = 169325u,
		Monk_MysticAlly_Pet_RuneC_GroundPunch = 169715u,
		Monk_MysticAlly_Pet_RuneD_AOEAttack = 169728u,
		a2dun_Cave_Goatmen_Dropping_Log_Trap_attack = 175069u,
		a1dun_Leor_Fire_Gutter_fire = 175159u,
		ZombieEatStart = 178483u,
		ZombieEatStop = 178485u,
		BannerDrop = 185040u,
		EmoteFollow = 185042u,
		EmoteGive = 185081u,
		EmoteThanks,
		EmoteSorry,
		EmoteBye = 185085u,
		EmoteDie = 185087u,
		EmoteHelp = 185093u,
		EmoteRun = 185598u,
		EmoteWait = 185600u,
		EmoteGo = 185629u,
		trOut_LogStack_Short_Damage = 186138u,
		Enchantress_RunAway = 186200u,
		trDun_Cath_WallCollapse_Damage = 186216u,
		WitchDoctor_SpiritBarrage_RuneC_AOE = 186471u,
		WitchDoctor_Gargantuan_Smash = 186851u,
		Barbarian_CallOfTheAncients_Basic_Melee = 187092u,
		EmoteYes = 188251u,
		EmoteNo,
		EmoteStay,
		EmoteAttack,
		EmoteRetreat,
		EmoteHold,
		EmoteTakeObjective,
		EmoteLaugh,
		WitchDoctor_Hex_Explode = 188442u,
		UseStoneOfRecall = 191590u,
		Monk_MantraOfEvasion = 192405u,
		AI_ReturnToGuardObject = 193411u,
		DualWieldBuff = 193438u,
		Hireling_Dismiss_Buff = 196103u,
		Hireling_Dismiss = 196142u,
		Hireling_Dismiss_Buff_Remove = 196251u,
		WitchDoctor_Hex_ChickenWalk = 196974u,
		EnterStoneOfRecall = 200036u,
		ExitStoneOfRecall = 200039u,
		Scoundrel_Hysteria = 200169u,
		Enchantress_MassCharm = 201524u,
		EnterRecallPortal = 201538u,
		ExitRecallPortal = 201570u,
		Unburied_Wreckable_Attack = 202344u,
		Weapon_Melee_Instant_Wreckables,
		PvP_DamageBuff = 202701u,
		Barbarian_Passive_BoonOfBulKathos = 204603u,
		Barbarian_Passive_NoEscape = 204725u,
		Barbarian_Passive_Brawler = 205133u,
		Barbarian_Passive_Ruthless = 205175u,
		Barbarian_Passive_BerserkerRage = 205187u,
		Barbarian_Passive_PoundOfFlesh = 205205u,
		Barbarian_Passive_Bloodthirst = 205217u,
		Barbarian_Passive_Animosity = 205228u,
		Barbarian_Passive_Unforgiving = 205300u,
		Barbarian_Passive_Relentless = 205398u,
		Barbarian_Passive_Superstition = 205491u,
		Barbarian_Passive_InspiringPresence = 205546u,
		Barbarian_Passive_Juggernaut = 205707u,
		Barbarian_Passive_ToughAsNails = 205848u,
		Barbarian_Passive_WeaponsMaster = 206147u,
		Wizard_Passive_Blur = 208468u,
		Wizard_Passive_GlassCannon = 208471u,
		Wizard_Passive_AstralPresence,
		Wizard_Passive_Evocation,
		Wizard_Passive_UnstableAnomaly,
		Wizard_Passive_TemporalFlux = 208477u,
		Wizard_Passive_PowerHungry,
		Wizard_Passive_Prodigy = 208493u,
		Wizard_Passive_GalvanizingWard = 208541u,
		Wizard_Passive_Illusionist = 208547u,
		WitchDoctor_Passive_ZombieHandler = 208563u,
		WitchDoctor_Passive_RushOfEssence = 208565u,
		WitchDoctor_Passive_BloodRitual = 208568u,
		WitchDoctor_Passive_SpiritualAttunement,
		WitchDoctor_Passive_CircleOfLife = 208571u,
		WitchDoctor_Passive_GruesomeFeast = 208594u,
		WitchDoctor_Passive_TribalRites = 208601u,
		DemonHunter_Passive_CustomEngineering = 208610u,
		WitchDoctor_Passive_PierceTheVeil = 208628u,
		WitchDoctor_Passive_FierceLoyalty = 208639u,
		DemonHunter_Passive_Grenadier = 208779u,
		Wizard_Passive_ArcaneDynamo = 208823u,
		Monk_Passive_ExaltedSoul = 209027u,
		Monk_Passive_FleetFooted = 209029u,
		WitchDoctor_Passive_VisionQuest = 209041u,
		Monk_Passive_BeaconOfYtar = 209104u,
		Monk_Passive_Transcendence = 209250u,
		Monk_Passive_SixthSense = 209622u,
		Monk_Passive_SeizeTheInitiative = 209628u,
		Monk_Passive_OneWithEverything = 209656u,
		DemonHunter_Passive_Archery = 209734u,
		Monk_Passive_TheGuardiansPath = 209812u,
		Monk_Passive_Pacifism,
		MonsterAffix_ChampionBuff = 210333u,
		MonsterAffix_EnrageExecute = 210335u,
		DemonHunter_Passive_Brooding = 210801u,
		DemonHunter_Passive_ThrillOfTheHunt = 211225u,
		Monk_Passive_Resolve = 211581u,
		ActorLoadingBuff = 212032u,
		Taunted_Monster_Ranged_Projectile = 212952u,
		Taunted_Weapon_Melee_Instant,
		MonsterAffix_ArcaneEnchanted = 214594u,
		MonsterAffix_ArcaneEnchantedCast = 214791u,
		MonsterAffix_Mortar = 215756u,
		MonsterAffix_MortarCast,
		SelectingSkill = 217340u,
		AI_TownWalkTo_Guaranteed = 217618u,
		Barbarian_Passive_NervesOfSteel = 217819u,
		WitchDoctor_Passive_BadMedicine = 217826u,
		WitchDoctor_Passive_JungleFortitude = 217968u,
		Wizard_Passive_Conflagration = 218044u,
		Wizard_Passive_CriticalMass = 218153u,
		WitchDoctor_Passive_GraveInjustice = 218191u,
		DemonHunter_Passive_NightStalker = 218350u,
		DemonHunter_Passive_TacticalAdvantage = 218385u,
		DemonHunter_Passive_NumbingTraps = 218398u,
		Monk_Passive_CombinationStrike = 218415u,
		WitchDoctor_Passive_SpiritVessel = 218501u,
		WitchDoctor_Passive_FetishSycophants = 218588u,
		MonsterAffix_ArcaneEnchanted_New_PetBasic = 219671u,
		ActorInTownBuff = 220304u,
		UseDungeonStone = 220318u,
		Enchantress_ScorchedEarth = 220872u,
		WitchDoctor_PlagueOfToads_BigToad_TongueSlap = 220908u,
		MonsterAffix_ArcaneEnchanted_Champion = 221130u,
		MonsterAffix_DesecratorBuff_Champion,
		MonsterAffix_VortexBuff_Champion,
		MonsterAffix_ArcaneEnchanted_Minion = 221219u,
		SkillOverrideStartedOrEnded = 221275u,
		MonsterAffix_Jailer = 222743u,
		MonsterAffix_JailerCast,
		MonsterAffix_Jailer_Champion,
		Monk_CycloneStrike = 223473u,
		WorldCreatingBuff = 223604u,
		ActorGhostedBuff = 224639u,
		CannotDieDuringBuff = 225599u,
		MonsterAffix_Avenger_Champion = 226289u,
		MonsterAffix_Avenger_Buff = 226292u,
		MonsterAffix_Waller,
		MonsterAffix_WallerCast,
		Wizard_Passive_ColdBlooded = 226301u,
		Wizard_Passive_Paralysis = 226348u,
		MonsterAffix_Shielding = 226437u,
		MonsterAffix_ShieldingCast,
		MonsterAffix_Linked = 226497u,
		WitchDoctor_FetishArmy_Melee = 226690u,
		WitchDoctor_ZombieDog_Melee = 226692u,
		IdentifyWithCast = 226757u,
		DH_Companion_MeleeAttack = 227240u,
		trDun_Cath_WallCollapse_Damage_offset = 227949u,
		DebuffBleed = 228423u,
		Manual_Walk = 229128u,
		Enchantress_Melee_Instant = 230238u,
		Templar_Melee_Instant,
		g_killElitePack = 230745u,
		MonsterAffix_ReflectsDamage = 230877u,
		AI_Follow_MeleeLead_Pet = 231004u,
		MonsterAffix_PlaguedCast = 231115u,
		MonsterAffix_WallerRare = 231117u,
		MonsterAffix_WallerRareCast,
		MonsterAffix_FrozenCast = 231149u,
		MonsterAffix_FrozenRare = 231157u
	}
}
