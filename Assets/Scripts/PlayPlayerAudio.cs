using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


[RequireComponent(typeof(AudioSource))]
public class PlayPlayerAudio : MonoBehaviour
{ 
    [SerializeField] private FootstepSurface[] m_Surfaces;
    [SerializeField] private RaycastToPhysicMaterial m_RaycastToPhysicalMaterial;
    [SerializeField] private AudioSource m_AudioSource;
    private Dictionary<float, FootstepSurface> m_FootstepsList = new Dictionary<float, FootstepSurface>();
    private AudioClip m_AudioClip;
    private void Start()
    {
        if (m_AudioSource == null)
        {
            m_AudioSource = GetComponent<AudioSource>();
        }
        foreach (var surface in m_Surfaces)
        {
            m_FootstepsList.Add(surface.Coordinates,surface);
        }
    }

    public void PlayFootstepSound()
    {
        float mat = m_RaycastToPhysicalMaterial.DetectSurface();
       
        try
        {
            FootstepSurface surface = m_FootstepsList[mat];
            int randomIndex = Random.Range(0, surface.AudioClips.Length);
            m_AudioClip = surface.AudioClips[randomIndex];
            m_AudioSource.volume = Random.Range(surface.InitialVolume - surface.VolumeVariation,
                surface.InitialVolume + surface.VolumeVariation);
            m_AudioSource.pitch = Random.Range(surface.InitialPitch - surface.PitchVariation,
                surface.InitialPitch + surface.PitchVariation);
            m_AudioSource.PlayOneShot(m_AudioClip);
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
       
       
    }
}