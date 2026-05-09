using UnityEngine;

public class Kuru_kuru_Scripts : MonoBehaviour
{
    [SerializeField]float Xrotate = 2.0f;
    [SerializeField]float Yrotate = 2.0f;
    [SerializeField]float Zrotate = 2.0f;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Xrotate, Yrotate, Zrotate);
    }
}
