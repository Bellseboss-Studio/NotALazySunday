using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

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

    protected override void PerformInteraction()
    {
        StartCoroutine(BreakPumpkin());
    }

    IEnumerator BreakPumpkin()
    {
        transform.localScale = Vector3.zero;
        m_Anim.enabled = true;
        yield return new WaitForSeconds(m_Grow.length);
        Debug.Log(Grow);
        m_Anim.enabled = false;
    }
}
    