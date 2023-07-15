
using UnityEngine;

public class LakeMission : Mission
{
    protected override void PerformInteraction()
    {
        if (m_IsThisMissionComplete)
        {
            m_MissionCompletedEvent.Occurred();
            gameObject.GetComponent<LakeMission>().enabled = false;
        }
        else
        {
            m_MissionNoCompletedEvent.Occurred();
        }
    }
}