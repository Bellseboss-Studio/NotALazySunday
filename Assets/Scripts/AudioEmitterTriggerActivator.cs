using UnityEngine;

namespace GameAudio
{
    public class AudioEmitterTriggerActivator : MonoBehaviour
    {
        [SerializeField] private GameObject[] m_EmittersToActivate;
        
        private void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("Player") && m_EmittersToActivate.Length > 0)
            {
                foreach (GameObject emitter in m_EmittersToActivate)
                {
                    emitter.SetActive(true);
                }

            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                foreach (GameObject emitter in m_EmittersToActivate)
                {
                    emitter.SetActive(false);
                }
            }
        }

    }
}