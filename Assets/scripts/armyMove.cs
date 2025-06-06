using UnityEngine;

public class armyMove : MonoBehaviour
{
    private float _Speed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * Time.deltaTime * _Speed;
            transform.rotation = Quaternion.Euler(new Vector3(0, -270, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.left * Time.deltaTime * _Speed;
            transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
        }
    }
}
