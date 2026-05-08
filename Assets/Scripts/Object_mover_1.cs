using Unity.VisualScripting;
using UnityEngine;

public class Object_mover_1 : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float player_speed = Time.deltaTime * 10.0f;
        float xValue = Input.GetAxis("Horizontal") * player_speed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * player_speed;

        transform.Translate(xValue, yValue, zValue);
    }
}
