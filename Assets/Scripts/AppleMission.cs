public class AppleMission : Mission
{
    protected override void PerformInteraction()
    {
        m_MissionCompletedEvent.Occurred();
        gameObject.SetActive(false);
    }
}