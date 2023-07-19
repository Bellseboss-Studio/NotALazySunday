using UnityEngine;

public class ValveMission : Mission
{
    [SerializeField] private BasicRotator m_ValveRotator;
    protected override void PerformInteraction()
    {
        if (m_IsThisMissionComplete)
        {
            m_MissionCompletedEvent.Occurred();
            m_ValveRotator.enabled = true;
        }
        else
        {
            m_MissionNoCompletedEvent.Occurred();
        }

    }
}