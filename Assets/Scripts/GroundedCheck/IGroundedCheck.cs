using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGroundedCheck
{
    LayerMask groundMask { get; }
    bool isGround { get; }
}
