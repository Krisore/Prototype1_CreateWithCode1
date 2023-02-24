using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public GameObject playerVehicle;

    private readonly Vector3 _offset = new (-0.11f, 5.15f, -10f);
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerVehicle.transform.position + _offset;
    }
}
