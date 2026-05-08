using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]float TimeValue = 3.0f;
    void Start()
    {
       
    }

    void Update()
    {
        if (Time.time > TimeValue)   
        {
            Debug.Log("Time to drop the object");
        }
    }

}
