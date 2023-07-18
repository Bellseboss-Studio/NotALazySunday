using System.Collections;
using UnityEngine;

public class GeneratorMission : Mission
{
    [SerializeField] private Animator m_Animator;
    [SerializeField] private float m_GeneratorTime = 10;
    private bool m_IsGeneratorOn = false;
    private static readonly int m_StartGenerator = Animator.StringToHash("IsOn");
    
    protected override void PerformInteraction()
    {
        StartCoroutine(GeneratorSequence());
    }

    IEnumerator GeneratorSequence()
    {
        if (m_IsThisMissionComplete)
        {
            m_Animator.SetBool(m_StartGenerator, true);
            m_IsGeneratorOn = true;
            m_MissionCompletedEvent.Occurred();
        }
        else
        {
            m_MissionNoCompletedEvent.Occurred();
        }
        yield return new WaitForSeconds(m_GeneratorTime);

        if (m_IsGeneratorOn)
        {
            m_Animator.SetBool(m_StartGenerator, false);
        }
    }
    
    
}