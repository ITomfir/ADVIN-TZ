using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ICameraView))]
public class CameraViewProvider : MonoBehaviour, ICameraViewProvider
{
    public ICameraView Get() {
        return GetComponent<ICameraView>();
    }
}
