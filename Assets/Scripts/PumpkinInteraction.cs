using System.Collections;
using UnityEngine;

public class PumpkinInteraction : Interactable
{
    [SerializeField] private AnimationClip m_Grow;
    private Animator m_Anim;
    private static readonly int Grow = Animator.StringToHash("Grow");

    private void Start()
    {
        m_Anim = GetComponent<Animator>();
        m_Anim.enabled = false;
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
        StartCoroutine(BreakPumpkin());
    }

    IEnumerator BreakPumpkin()
    {
        transform.localScale = Vector3.zero;
        m_Anim.enabled = true;
        yield return new WaitForSeconds(m_Grow.length);
        Debug.Log("Pumpkin is ready");
        m_Anim.enabled = false;
    }
}