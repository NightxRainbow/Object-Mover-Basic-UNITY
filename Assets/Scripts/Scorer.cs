using UnityEngine;

public class Scorer : MonoBehaviour
{
    int HitCounter = 0;
        private void OnCollisionEnter(Collision other)
    {
        HitCounter++;
        Debug.Log("You bum this for: "+HitCounter+" times");
    }
}
