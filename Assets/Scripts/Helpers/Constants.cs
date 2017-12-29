using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    public readonly static string TAG_GROUND = "Ground";
    public readonly static string TAG_GROUNDBEFORECROSSING = "GroundBeforeCrossing";
    public readonly static string TAG_CROSSING = "Crossing";
    public readonly static string TAG_MIDDLEPOINT = "MiddlePoint";
    public readonly static string TAG_GROUNDAFTERCROSSING = "GroundAfterCrossing";

    public enum Directions
    {
        Left, Right, Forward, Backward
    }

}

public static class PlayerConstants
{
    public readonly static string EVENT_RUN = "Run";
    public readonly static string EVENT_WALK = "Walk";
    public readonly static string EVENT_HITCROSSING = "HitCrossing";
    public readonly static string EVENT_MIDDLEOFCROSSING = "MiddleOfCrossing";
    public readonly static string EVENT_LEAVECROSSING = "LeaveCrossing";
    public readonly static string EVENT_EXITCROSSING = "ExitCrossing";

    public readonly static string EVENT_GOLEFT = "GoLeft";
    public readonly static string EVENT_GORIGHT = "GoRight";
    public readonly static string EVENT_GOFORWARD = "GoForward";
    public readonly static string EVENT_GOBACKWARD = "GoBackward";
    public readonly static string EVENT_INVALIDINPUT = "InvalidInput";

    public readonly static string STATE_RUNNING = "RunningToNextCrossing";
    public readonly static string STATE_COMINGTOCROSSING = "ComingToCrossing";
    public readonly static string STATE_CROSSINGBOUNDARIES = "CrossingBoundaries";
    public readonly static string STATE_ATCROSSING = "AtCrossing";
    public readonly static string STATE_LEAVINGCROSSING = "LeavingCrossing";

    public readonly static string STATE_CHOOSELEFT = "ChooseLeft";
    public readonly static string STATE_CHOOSERIGHT = "ChooseRight";
    public readonly static string STATE_CHOOSEFORWARD = "ChooseBackward";
    public readonly static string STATE_CHOOSEBACKWARD = "ChooseForward";
}

