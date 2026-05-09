using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]float TimeValue = 2.0f;
    MeshRenderer myMeshRenderer;

    Rigidbody myRigidbody;
    void Start()
    {
    
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;

    }

    void Update()
    {
        if (Time.time > TimeValue)   
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
            Debug.Log("Time to drop the object");
        }
    }

}
