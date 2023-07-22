using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomMusicFragmentPlay : MonoBehaviour
{
    [SerializeField] private List<AudioClip> m_PartA = new List<AudioClip>();
    [SerializeField] private List<AudioClip> m_PartB = new List<AudioClip>();
    [SerializeField] private AudioSource m_AudioSource1;
    [SerializeField] private AudioSource m_AudioSource2;
    [SerializeField] private float m_TempoBPM;
    [SerializeField] private float m_MeterIn4;
    [SerializeField] private float m_Measures;
    [SerializeField] private float m_LengthInSecs;

    private void Awake()
    {
        CheckDependencies();
        CalculateLengthInSeconds();
        StartCoroutine(PlayMusic());
    }

    private void CheckDependencies()
    {
        if (!m_AudioSource2)
        {
            m_AudioSource1 = GetComponent<AudioSource>();
        }
        if (!m_AudioSource2)
        {
            m_AudioSource1 = GetComponent<AudioSource>();
        }
    }

    private float CalculateLengthInSeconds()
    {
        m_LengthInSecs = (m_Measures * m_MeterIn4) * (60f / m_TempoBPM);
        return m_LengthInSecs;
    }

    private void SelectAudioClip(AudioSource audioSource, List<AudioClip> clips)
    {
        int index = Random.Range(0, clips.Count);
        audioSource.clip = clips[index];
    }

    private IEnumerator PlayMusic()
    {
        int m_Silence = Random.Range(0, 10);
        SelectAudioClip(m_AudioSource1, m_PartA);
        m_AudioSource1.Play();
        yield return new WaitForSeconds(m_LengthInSecs);
        SelectAudioClip(m_AudioSource2, m_PartB);
        m_AudioSource2.Play();
        yield return new WaitForSeconds(m_LengthInSecs);
        if (m_Silence > 7)
        {
            float waitTime = Random.Range(m_LengthInSecs, 60f);
            yield return new WaitForSeconds(m_LengthInSecs);
        }
        StartCoroutine(PlayMusic());
       
            
    }
}
