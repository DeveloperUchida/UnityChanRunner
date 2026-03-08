using UnityEngine;

public class MainControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //3DはZが存在するからそこを前進として考えよう
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, 0);
        }
        
    }
}
