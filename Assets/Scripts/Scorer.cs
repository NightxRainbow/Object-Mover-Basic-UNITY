using UnityEngine;

public class Scorer : MonoBehaviour
{
    int HitCounter = 0;
        private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            HitCounter++;
            Debug.Log("You hit this for: " + HitCounter + " times");
        }
    }
}
