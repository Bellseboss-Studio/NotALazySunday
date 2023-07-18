using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDialogue : MonoBehaviour
{
    [SerializeField] private Event m_CloseOtherDialogue;
    [SerializeField] private bool m_ClearUIOnEnable;
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
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}
