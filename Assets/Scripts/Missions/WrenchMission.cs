using UnityEngine;

public class WrenchMission : Mission
{
  
    protected override void PerformInteraction()
    {
        if (m_IsThisMissionComplete)
        {
            m_MissionCompletedEvent.Occurred();
            gameObject.SetActive(false);
        }
        else
        {
            m_MissionNoCompletedEvent.Occurred();
        }

    }
}