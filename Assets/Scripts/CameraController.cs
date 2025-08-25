using UnityEngine;

public class CameraController : MonoBehaviour
{ 

    public Transform target;

    public Vector3 targetOffset = Vector3.zero;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //sets camera position to the target position + the offset while keeping the camera at its current depth
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z) + targetOffset;

    }
}