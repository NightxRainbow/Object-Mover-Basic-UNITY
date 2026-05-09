using UnityEngine;

public class Object_hit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
        GetComponent<Renderer>().material.color = Color.red;
        gameObject.tag = "Hit";
        }
    }
}
