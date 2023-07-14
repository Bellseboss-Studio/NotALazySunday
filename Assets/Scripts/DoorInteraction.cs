using System.Collections;
using UnityEngine;
public class DoorInteraction : Interactable
{
    [SerializeField] private Animator m_Anim;
    [SerializeField] private float m_HoldOpenTime = 4f;
    [SerializeField] private float speed = 1;
    private static readonly int m_OpenDoor = Animator.StringToHash("OpenDoor");
    private static readonly int m_CloseDoor = Animator.StringToHash("CloseDoor");

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
        m_Anim.speed = speed;
        m_Anim.SetTrigger(m_OpenDoor);
        yield return new WaitForSeconds(m_HoldOpenTime);
        m_Anim.SetTrigger(m_CloseDoor);
        yield return null;
    }

    private void CheckDependencies()
    {
        if (!m_Anim)
        {
            m_Anim = GetComponent<Animator>();
        }
    }
        
}