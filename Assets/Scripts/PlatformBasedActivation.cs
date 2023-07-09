using UnityEngine;

namespace Audio
{
    public class PlatformBasedActivation : MonoBehaviour
    {
        public GameObject editorObject;
        public GameObject androidObject;

        void Start()
        {
#if UNITY_EDITOR
            editorObject.SetActive(true);
#else
        androidObject.SetActive(true);
#endif
        }
    }
}
