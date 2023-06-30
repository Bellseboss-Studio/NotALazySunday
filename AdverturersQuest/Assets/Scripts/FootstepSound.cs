using System;
using UnityEngine;

[System.Serializable]
public abstract class FootstepSound : MonoBehaviour
{
     public string Name;
     public float Coordinates;
     public AudioClip[] AudioClips;
     [Range(0.0f, 1f)] public  float InitialVolume = 1f;
     [Range(0.0f, 0.5f)] public float VolumeVariation;
     [Range(0.5f, 1.5f)] public  float InitialPitch = 1f;
     [Range(0.0f, 0.5f)] public float PitchVariation;

}