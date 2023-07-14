using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDialogue : MonoBehaviour
{
   
    void OnEnable()
    {
        StartCoroutine(ActivateDialoguePopup());
    }


    IEnumerator ActivateDialoguePopup()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}
