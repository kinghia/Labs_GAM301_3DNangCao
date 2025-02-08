using UnityEngine;
using Unity.Cinemachine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] CinemachineCamera cm1;
    [SerializeField] CinemachineCamera cm2;

    void Start()
    {
        cm1.Priority = 1;
        cm2.Priority = 0;
        Invoke("CCmera", 5f);
        
    }
    void CCmera()
    {
        cm1.Priority = 0;
        cm2.Priority = 1;
    }
    void Update()
    {
        
    }
}
