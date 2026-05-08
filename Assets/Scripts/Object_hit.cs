using UnityEngine;

public class Object_hit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Renderer>().material.color = Color.red;

    }
}
