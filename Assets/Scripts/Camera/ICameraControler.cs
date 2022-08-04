using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICameraControler
{
    void Init(ICameraViewProvider provider);
    void SetType(CameraData.CameraType type);
    void SetNextType();
}
