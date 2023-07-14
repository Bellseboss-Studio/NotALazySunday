using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    
    [SerializeField] private List<GameObject> m_TeleportationPoints = new List<GameObject>();
    [SerializeField] private GameObject m_Player;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            m_Player.transform.position = m_TeleportationPoints[0].transform.position;
        }
    }
}
