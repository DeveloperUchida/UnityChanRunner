using UnityEngine;

public class UntiyFrameRateScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Application.targetFrameRate = 60; //フレームレート値を60へ
    }
}
