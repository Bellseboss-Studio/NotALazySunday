using System.Collections;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class DoorInteraction : Interactable
{
    [SerializeField] private Animator m_Animator;
    [SerializeField] private float m_HoldOpenTime = 4f;
    [SerializeField] private float m_Speed = 1;
    [SerializeField] private bool m_OpenOutwards =  false;
    private static readonly int m_OpenDoorInwards = Animator.StringToHash("OpenDoorInwards");
    private static readonly int m_CloseDoorInwards = Animator.StringToHash("CloseDoorInwards");
    private static readonly int m_OpenDoorOutwards = Animator.StringToHash("OpenDoorOutwards");
    private static readonly int m_CloseDoorDoorOutwards = Animator.StringToHash("CloseDoorOutwards");
    private int idOpen;
    private int idClose;

    private void Start()
    {
        CheckDependencies();
    }
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }

    protected override void OnTriggerExit(Collider other)
    {
        base.OnTriggerExit(other);
    }

    protected override void PerformInteraction()
    {
        StartCoroutine(OpeningDoorSequence());
    }

    IEnumerator OpeningDoorSequence()
    {
        if (m_OpenOutwards)
        {
            idOpen = m_OpenDoorOutwards;
            idClose = m_CloseDoorDoorOutwards;
        }
        
        m_Animator.speed = m_Speed;
        m_Animator.SetTrigger(idOpen);
        yield return new WaitForSeconds(m_HoldOpenTime);
        m_Animator.SetTrigger(idClose);
        yield return null;
    }

    private void CheckDependencies()
    {
        if (!m_Animator)
        {
            m_Animator = GetComponent<Animator>();
        }

        idOpen = m_OpenDoorInwards;
        idClose = m_CloseDoorInwards;
    }
        
}