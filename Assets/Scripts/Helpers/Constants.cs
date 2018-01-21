using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Helpers
{
    public static class Constants
    {
        public static readonly string TagGround = "Ground";
        public static readonly string TagGroundbeforecrossing = "GroundBeforeCrossing";
        public static readonly string TagCrossing = "Crossing";
        public static readonly string TagMiddlepoint = "MiddlePoint";
        public static readonly string TagGroundaftercrossing = "GroundAfterCrossing";
        public static readonly string TagExit = "Exit";

        public static readonly string PathUserdata = "/userData.json";

        public static readonly int SceneStartmenu = 0;
        public static readonly int SceneMain = 1;
        public static readonly int SceneShop = 2;

        public enum Directions
        {
            Left, Right, Forward, Backward
        }

    }

    public static class CharacterCreationConstants
    {
        public static readonly string EventSelectCoin = "ChooseCoinCharacter";
        public static readonly string EventSelectLuck = "ChooseLuckCharacter";
        public static readonly string EventSelectStrength = "ChooseStrengthCharacter";

        public static readonly string CharacterNameLuck = "San Toro";
        public static readonly string CharacterNameCoin = "Ottoman";
        public static readonly string CharacterNameStrength = "Ristofer";
    }

    public static class ShopSceneConstants
    {
        public static readonly string EventClearselection = "ClearSelection";
        public static readonly string EventSelectBlacksmith = "SelectBlacksmith";
        public static readonly string EventSelectInn = "SelectInn";
        public static readonly string EventSelectEnchanter = "SelectEnchanter";

        public static readonly string TagBlacksmith = "Blacksmith";
        public static readonly string TagInn = "Inn";
        public static readonly string TagEnchanter = "Enchanter";

    }

    public static class StartMenuConstants
    {
        public static readonly string EventSettingsfound = "SettingsFound";
        public static readonly string EventSettingsnotfound = "SettingsNotFound";
    }

    public static class PlayerConstants
    {
        public static readonly string EventRun = "Run";
        public static readonly string EventWalk = "Walk";
        public static readonly string EventHitcrossing = "HitCrossing";
        public static readonly string EventMiddleofcrossing = "MiddleOfCrossing";
        public static readonly string EventLeavecrossing = "LeaveCrossing";
        public static readonly string EventExitcrossing = "ExitCrossing";

        public static readonly string EventGoleft = "GoLeft";
        public static readonly string EventGoright = "GoRight";
        public static readonly string EventGoforward = "GoForward";
        public static readonly string EventGobackward = "GoBackward";
        public static readonly string EventInvalidinput = "InvalidInput";

        public static readonly string StateRunning = "RunningToNextCrossing";
        public static readonly string StateComingtocrossing = "ComingToCrossing";
        public static readonly string StateCrossingboundaries = "CrossingBoundaries";
        public static readonly string StateAtcrossing = "AtCrossing";
        public static readonly string StateLeavingcrossing = "LeavingCrossing";

        public static readonly string StateChooseleft = "ChooseLeft";
        public static readonly string StateChooseright = "ChooseRight";
        public static readonly string StateChooseforward = "ChooseBackward";
        public static readonly string StateChoosebackward = "ChooseForward";
    }
}