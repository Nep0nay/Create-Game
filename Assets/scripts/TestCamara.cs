using UnityEngine;
using Unity.Cinemachine;
public class TestCamara : MonoBehaviour
{
    [SerializeField]
    CinemachineCamera[] _camera;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            for(int i = 0; i < _camera.Length; i++)
            {
                _camera[i].Priority = 0;
            }
            _camera[0].Priority = 10;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < _camera.Length; i++)
            {
                _camera[i].Priority = 0;
            }
            _camera[1].Priority = 10;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < _camera.Length; i++)
            {
                _camera[i].Priority = 0;
            }
            _camera[2].Priority = 10;
        }
    }
}
