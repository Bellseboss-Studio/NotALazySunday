using UnityEngine;

[System.Serializable]
[RequireComponent(typeof(BoxCollider))]
public abstract class Mission : Interactable
{
    [SerializeField] protected Event m_MissionNoCompletedEvent;
    [SerializeField] protected Event m_MissionCompletedEvent;
    
    [SerializeField] protected BoxCollider m_TriggerCollider;

    private bool m_IsPreviousMissionComplete = false;
    protected bool m_IsThisMissionComplete = false;
    
    
    private void Start()
    {
        CheckDependencies();
        m_TriggerCollider.isTrigger = true;
    }

    public bool IsMissionCompleted
    {
        get => m_IsThisMissionComplete;
        set => m_IsThisMissionComplete = value;
    }
    
    protected override void PerformInteraction()
    {
        if (!m_IsPreviousMissionComplete)
        {
            m_MissionNoCompletedEvent.Occurred();
        }
    }


    protected virtual void CheckDependencies()
    {
        if (!m_TriggerCollider)
        {
            m_TriggerCollider = GetComponent<BoxCollider>(); 
        }

        if (!m_MissionCompletedEvent)
        {
            Debug.Log($"{gameObject.name}: doesn't have an event assigned");
        }
        
    }
    
}