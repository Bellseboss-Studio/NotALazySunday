using UnityEngine;

public class ElectricityMission : Mission
{
    protected override void PerformInteraction()
    {
        if (!m_IsThisMissionComplete)
        {
           m_MissionNoCompletedEvent.Occurred();
           return;
        }
        
        if (m_MissionCompletedEvent != null)
        {
            m_MissionCompletedEvent.Occurred();
        }
    }
}