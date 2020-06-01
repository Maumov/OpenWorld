using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CineMachineEvents : MonoBehaviour
{
    public Cinemachine.CinemachineStateDrivenCamera stateDriven;
    public Cinemachine.CinemachineFreeLook freeLook;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReCenter() {
        freeLook.m_XAxis.Value = stateDriven.m_Follow.rotation.eulerAngles.y;
        //freeLook.m_YAxis.Value = 0.5f;
    }
}
