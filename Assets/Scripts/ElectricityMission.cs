using UnityEngine;

public class ElectricityMission : Mission
{
    
    protected override void PerformInteraction()
    {

        if (!m_IsThisMissionComplete)
        {
            m_MissionNoCompletedEvent.Occurred();
        }
        
        Debug.Log("AHAAAAAAA!");
        
        if (m_MissionCompletedEvent != null)
        {
            m_MissionCompletedEvent.Occurred();
        }
        
    }
}