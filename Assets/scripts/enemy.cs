using UnityEngine;


public class enemy : MonoBehaviour
{
    private Transform _target;


    void Start()
    {

    }

    public void SetTarget(Transform target)
    { 
        Vector3 pos = target.transform.position;
        target.transform.position += Vector3.left;
        _target = target; 
    }

    void Update()
    {
       

        
    }
}
