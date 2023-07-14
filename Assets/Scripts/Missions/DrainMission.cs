using UnityEngine;

public class DrainMission : Mission
{
    [SerializeField] private Animator m_Animator;
    private static readonly int DrainLake = Animator.StringToHash("DrainLake");

    private void Start()
    {
        CheckDependencies();
    }
    protected override void PerformInteraction()
    {
        if (m_IsThisMissionComplete)
        {
            m_MissionCompletedEvent.Occurred();
            m_Animator.SetTrigger(DrainLake);
        }
        else
        {
            m_MissionNoCompletedEvent.Occurred();
        }

    }


    private void CheckDependencies()
    {
       if(!m_Animator)
       {
           m_Animator = GetComponent<Animator>();
       }
        
    }
}