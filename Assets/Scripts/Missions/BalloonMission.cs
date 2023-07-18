public class BalloonMission : Mission
{
  
    protected override void PerformInteraction()
    {
        if (m_IsThisMissionComplete)
        {
            m_MissionCompletedEvent.Occurred();
        }
        else
        {
            m_MissionNoCompletedEvent.Occurred();
        }

    }
}