using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum Scene
    { 
        Unknown,
        Title,
        GameStage01,
        GameStage02,

    }

    public enum Sound
    { 
        Bgm,
        Effect,
        MaxCount,
    }
    public enum UIEvent
    {
        Click,
        Drag,
    }

    public enum MouseEvent
    { 
        Press,
        Click,
    } 
    public enum CameraMode
    { 
        QuaterView,
        PlaneView,
    }
}
