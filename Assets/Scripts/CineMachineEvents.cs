using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CineMachineEvents : MonoBehaviour
{
    public Cinemachine.CinemachineStateDrivenCamera stateDriven;
    public Cinemachine.CinemachineFreeLook freeLook;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frameou

    void Update()
    {
        
    }

    public void StartMain() {
        freeLook.m_YAxis.Value = 0.5f;
    }

    public void StartAim() {
        freeLook.m_YAxis.Value = 0.5f;
    }
}
