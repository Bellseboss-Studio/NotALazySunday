using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


[RequireComponent(typeof(AudioSource))]
public class PlayPlayerAudio : MonoBehaviour
{
    [SerializeField] private FootstepSound[] m_FootstepSurfaces;
    [SerializeField] private RaycastToPhysicMaterial m_RaycastToPhysicalMaterial;
    [SerializeField] private AudioSource m_AudioSource;
    private Dictionary<float, FootstepSound> m_FootstepsList = new Dictionary<float, FootstepSound>();
    private AudioClip m_AudioClip;
    private void Start()
    {
        if (m_AudioSource == null)
        {
            m_AudioSource = GetComponent<AudioSource>();
        }
        foreach (var footstepSound in m_FootstepSurfaces)
        {
            m_FootstepsList.Add(footstepSound.Coordinates,footstepSound);
        }
    }

    public void PlayFootstepSound()
    {
        float mat = m_RaycastToPhysicalMaterial.DetectSurface();
       
        try
        {
            FootstepSound footstepSound = m_FootstepsList[mat];
            int randomIndex = Random.Range(0, footstepSound.AudioClips.Length);
            m_AudioClip = footstepSound.AudioClips[randomIndex];
            m_AudioSource.volume = Random.Range(footstepSound.InitialVolume - footstepSound.VolumeVariation,
                footstepSound.InitialVolume + footstepSound.VolumeVariation);
            m_AudioSource.pitch = Random.Range(footstepSound.InitialPitch - footstepSound.PitchVariation,
                footstepSound.InitialPitch + footstepSound.PitchVariation);
            m_AudioSource.PlayOneShot(m_AudioClip);
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
       
       
    }
}