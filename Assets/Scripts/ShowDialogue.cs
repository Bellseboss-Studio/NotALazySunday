using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDialogue : MonoBehaviour
{
    [SerializeField] private Event m_CloseOtherDialogue;
    [SerializeField] private bool m_ClearUIOnEnable;
    [SerializeField] private float m_Length = 5;
    void OnEnable()
    {
        StartCoroutine(ActivateDialoguePopup());
    }


    IEnumerator ActivateDialoguePopup()
    {
        if (m_ClearUIOnEnable)
        {
            m_CloseOtherDialogue.Occurred();
        }
        yield return new WaitForSeconds(m_Length);
        gameObject.SetActive(false);
    }
}
