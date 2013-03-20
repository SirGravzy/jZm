﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieAPI
{
    class DefaultEvents
    {
        private String[] eventnames =
        {
            "EV_NONE",
            "EV_FOLIAGE_SOUND",
            "EV_STOP_WEAPON_SOUND",
            "EV_STOP_SOUND_ALIAS",
            "EV_SOUND_ALIAS",
            "EV_SOUND_ALIAS_NOTIFY",
            "EV_SOUND_BATTLECHAT_ALIAS",
            "EV_STOPSOUNDS",
            "EV_STANCE_FORCE_STAND",
            "EV_STANCE_FORCE_CROUCH",
            "EV_STANCE_FORCE_PRONE",
            "EV_ITEM_PICKUP",
            "EV_AMMO_PICKUP",
            "EV_NOAMMO",
            "EV_NOAMMO_LEFT",
            "EV_EMPTYCLIP",
            "EV_EMPTY_OFFHAND",
            "EV_RESET_ADS",
            "EV_RELOAD",
            "EV_RELOAD_FROM_EMPTY",
            "EV_RELOAD_START",
            "EV_RELOAD_END",
            "EV_RELOAD_START_NOTIFY",
            "EV_RELOAD_ADDAMMO",
            "EV_RAISE_WEAPON",
            "EV_FIRST_RAISE_WEAPON",
            "EV_RAISE_PICKUP_WEAPON",
            "EV_PUTAWAY_WEAPON",
            "EV_WEAPON_ALT",
            "EV_WEAPON_SWITCH_STARTED",
            "EV_PULLBACK_WEAPON",
            "EV_FIRE_WEAPON_SCRIPTED",
            "EV_FIRE_WEAPON",
            "EV_FIRE_WEAPON_LASTSHOT",
            "EV_FIRE_WEAPON_LEFT",
            "EV_FIRE_WEAPON_LASTSHOT_LEFT",
            "EV_FIRE_RICOCHET",
            "EV_RECHAMBER_WEAPON",
            "EV_EJECT_BRASS",
            "EV_MELEE_SWIPE",
            "EV_FIRE_MELEE",
            "EV_WEAPON_DEPLOYING",
            "EV_WEAPON_FINISH_DEPLOYING",
            "EV_WEAPON_BREAKING_DOWN",
            "EV_WEAPON_FINISH_BREAKING_DOWN",
            "EV_INC_CHARGESHOT_LEVEL",
            "EV_CHARGESHOT_DISCHARGEWEAPON",
            "EV_PREP_OFFHAND",
            "EV_USE_OFFHAND",
            "EV_SWITCH_OFFHAND",
            "EV_PREP_RIOTSHIELD",
            "EV_DEPLOY_RIOTSHIELD",
            "EV_LOWER_RIOTSHIELD",
            "EV_MELEE_HIT",
            "EV_MELEE_MISS",
            "EV_MELEE_BLOOD",
            "EV_FIRE_WEAPON_MOUNTED_TURRET",
            "EV_FIRE_WEAPON_MOUNTED_TURRETA",
            "EV_FIRE_BARREL_1",
            "EV_FIRE_BARREL_2",
            "EV_FIRE_BARREL_3",
            "EV_FIRE_BARREL_4",
            "EV_BULLET_HIT",
            "EV_BULLET_HIT_SHIELD",
            "EV_BULLET_HIT_CLIENT_SHIELD",
            "EV_EXPLOSIVE_IMPACT_ON_SHIELD",
            "EV_EXPLOSIVE_SPLASH_ON_SHIELD",
            "EV_BULLET_HIT_CLIENT_SMALL",
            "EV_BULLET_HIT_CLIENT_LARGE",
            "EV_DESTRUCTIBLE_BULLET_HIT",
            "EV_DESTRUCTIBLE_EXPLOSION_HIT",
            "EV_GRENADE_BOUNCE",
            "EV_GRENADE_EXPLODE",
            "EV_ROCKET_EXPLODE",
            "EV_ROCKET_EXPLODE_NOMARKS",
            "EV_FLASHBANG_EXPLODE",
            "EV_CUSTOM_EXPLODE",
            "EV_CUSTOM_EXPLODE_NOMARKS",
            "EV_SENSOR_GRENADE_EXPLODE",
            "EV_CHANGE_TO_DUD",
            "EV_DUD_EXPLODE",
            "EV_DUD_IMPACT",
            "EV_FIRE_EXPLODE",
            "EV_TIMED_FX",
            "EV_MOLOTOV_FLOAT",
            "EV_FAKE_FIRE",
            "EV_PLAY_FX",
            "EV_PLAY_FX_ON_TAG",
            "EV_PHYS_EXPLOSION_SPHERE",
            "EV_PHYS_EXPLOSION_CYLINDER",
            "EV_PHYS_EXPLOSION_JOLT",
            "EV_PHYS_JET_THRUST",
            "EV_PHYS_LAUNCH",
            "EV_CREATE_DYNENT",
            "EV_CREATE_ROPE",
            "EV_BLOOD_IMPACTS",
            "EV_DETACH_ENTITY",
            "EV_DELETE_ROPE",
            "EV_ROPE_COLLIDE",
            "EV_ROPE_SETFLAG",
            "EV_ROPE_SETPARAM",
            "EV_ROPE_ADDANCHOR",
            "EV_ROPE_REMOVEANCHOR",
            "EV_ROPE_MOVEANCHOR",
            "EV_SETWETNESS",
            "EV_EARTHQUAKE",
            "EV_GRENADE_DROP",
            "EV_GRENADE_SUICIDE",
            "EV_DETONATE",
            "EV_NIGHTVISION_WEAR",
            "EV_NIGHTVISION_REMOVE",
            "EV_MISSILE_REMOTE_BOOST",
            "EV_PLAY_RUMBLE_ON_ENT",
            "EV_PLAY_RUMBLE_ON_POS",
            "EV_PLAY_RUMBLELOOP_ON_ENT",
            "EV_PLAY_RUMBLELOOP_ON_POS",
            "EV_STOP_RUMBLE",
            "EV_STOP_ALL_RUMBLES",
            "EV_OBITUARY",
            "EV_REVIVE_OBITUARY",
            "EV_DIRECTIONAL_HIT_INDICATOR",
            "EV_ANIMATE_UI",
            "EV_KILLSTREAK_DAMAGE",
            "EV_NO_FRAG_GRENADE_HINT",
            "EV_NO_SPECIAL_GRENADE_HINT",
            "EV_TARGET_TOO_CLOSE_HINT",
            "EV_TARGET_NOT_ENOUGH_CLEARANCE",
            "EV_LOCKON_REQUIRED_HINT",
            "EV_FOOTSTEP_SPRINT",
            "EV_FOOTSTEP_RUN",
            "EV_FOOTSTEP_WALK",
            "EV_FOOTSTEP_CROUCHRUN",
            "EV_FOOTSTEP_CROUCHWALK",
            "EV_FOOTSTEP_PRONE",
            "EV_LADDER_HAND_GRAB",
            "EV_MANTLE",
            "EV_JUMP",
            "EV_LANDING_DEFAULT",
            "EV_LANDING_BARK",
            "EV_LANDING_BRICK",
            "EV_LANDING_CARPET",
            "EV_LANDING_CLOTH",
            "EV_LANDING_CONCRETE",
            "EV_LANDING_DIRT",
            "EV_LANDING_FLESH",
            "EV_LANDING_FOLIAGE",
            "EV_LANDING_GLASS",
            "EV_LANDING_GRASS",
            "EV_LANDING_GRAVEL",
            "EV_LANDING_ICE",
            "EV_LANDING_METAL",
            "EV_LANDING_MUD",
            "EV_LANDING_PAPER",
            "EV_LANDING_PLASTER",
            "EV_LANDING_ROCK",
            "EV_LANDING_SAND",
            "EV_LANDING_SNOW",
            "EV_LANDING_WATER",
            "EV_LANDING_WOOD",
            "EV_LANDING_ASPHALT",
            "EV_LANDING_CERAMIC",
            "EV_LANDING_PLASTIC",
            "EV_LANDING_RUBBER",
            "EV_LANDING_CUSHION",
            "EV_LANDING_FRUIT",
            "EV_LANDING_PAINTEDMETAL",
            "EV_LANDING_PLAYER",
            "EV_LANDING_TALLGRASS",
            "EV_LANDING_RIOTSHIELD",
            "EV_LANDING_PAIN_DEFAULT",
            "EV_LANDING_PAIN_BARK",
            "EV_LANDING_PAIN_BRICK",
            "EV_LANDING_PAIN_CARPET",
            "EV_LANDING_PAIN_CLOTH",
            "EV_LANDING_PAIN_CONCRETE",
            "EV_LANDING_PAIN_DIRT",
            "EV_LANDING_PAIN_FLESH",
            "EV_LANDING_PAIN_FOLIAGE",
            "EV_LANDING_PAIN_GLASS",
            "EV_LANDING_PAIN_GRASS",
            "EV_LANDING_PAIN_GRAVEL",
            "EV_LANDING_PAIN_ICE",
            "EV_LANDING_PAIN_METAL",
            "EV_LANDING_PAIN_MUD",
            "EV_LANDING_PAIN_PAPER",
            "EV_LANDING_PAIN_PLASTER",
            "EV_LANDING_PAIN_ROCK",
            "EV_LANDING_PAIN_SAND",
            "EV_LANDING_PAIN_SNOW",
            "EV_LANDING_PAIN_WATER",
            "EV_LANDING_PAIN_WOOD",
            "EV_LANDING_PAIN_ASPHALT",
            "EV_LANDING_PAIN_CERAMIC",
            "EV_LANDING_PAIN_PLASTIC",
            "EV_LANDING_PAIN_RUBBER",
            "EV_LANDING_PAIN_CUSHION",
            "EV_LANDING_PAIN_FRUIT",
            "EV_LANDING_PAIN_PAINTEDMETAL",
            "EV_LANDING_PAIN_PLAYER",
            "EV_LANDING_PAIN_TALLGRASS",
            "EV_LANDING_PAIN_RIOTSHIELD",
            "EV_FIRE_VEHICLE_TURRET",
            "EV_FIRE_GUNNER_1",
            "EV_FIRE_GUNNER_2",
            "EV_FIRE_GUNNER_3",
            "EV_FIRE_GUNNER_4",
            "EV_FIRE_GUNNER_1A",
            "EV_FIRE_GUNNER_2A",
            "EV_FIRE_GUNNER_3A",
            "EV_FIRE_GUNNER_4A",
            "EV_START_CAMERA_TWEEN",
            "EV_DESTRUCTIBLE_DISABLE_PIECES",
            "EV_FOOTPRINT",
            "EV_CANNOTPLANT",
            "EV_CANT_EQUIP_PRONE",
            "EV_DTP_LAUNCH",
            "EV_DTP_LAND",
            "EV_SLIDE_START",
            "EV_SLIDE_STOP",
            "EV_SCOPE_ZOOM",
            "EV_JAM_WEAPON",
            "EV_STACKFIRE",
            "EV_BOLT_IMPACT",
            "EV_BOLT_IMPALE",
            "EV_PLAY_WEAPON_DEATH_EFFECTS",
            "EV_PLAY_WEAPON_DAMAGE_EFFECTS",
            "EV_FACE_EVENT",
            "EV_SETLOCALWIND",
            "EV_FLOAT_LONGER",
            "EV_FORCE_BUOYANCY",
            "EV_DISABLE_DEPTH_BUOYANCY_ADJUSTMENTS",
            "EV_SCALE_BUOYANCY",
            "EV_ALLOWPITCH",
            "EV_GIB",
            "EV_STANCE_INVALID",
            "EV_ENTER_VEHICLE",
            "EV_EXIT_VEHICLE",
            "EV_IMMEDIATE_RAGDOLL",
            "EV_ENT_SPAWNED_SENTINEL"
        };

        private String[] entityTypeNames =
        {
            "General",
            "Player",
            "Corpse",
            "Item",
            "Missile",
            "Invisible entity",
            "Scriptmover",
            "Sound blend",
            "FX",
            "Loop FX",
            "Primary Light",
            "Turret",
            "Helicopter",
            "Plane",
            "Vehicle",
            "Vehicle corpse",
            "Actor",
            "Actor spawner",
            "Actor corpse",
            "Streamer Hint",
            "ZBarrier"
        };

        public String GetEventName(uint eventId)
        {
            if (eventId >= 21)
                return eventnames[eventId - 21];
            else
                return entityTypeNames[eventId];
        }
    }
}