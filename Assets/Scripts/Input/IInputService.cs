using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IInputService
{
    event Action OnJump;
    event Action OnShoot;
    event Action OnSwitchCam;
    Vector2 GetMoveDirection();
}
