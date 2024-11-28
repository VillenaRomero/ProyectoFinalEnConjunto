using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Camaraprioridad : MonoBehaviour
{
    public CinemachineVirtualCamera currentCamera;
    void Start()
    {
        currentCamera.Priority++;
    }
    public void UpdateCamera(CinemachineVirtualCamera target)
    {
        currentCamera.Priority--;
        currentCamera = target;
        currentCamera.Priority++;
        currentCamera.Priority++;
    }
}
