using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly float _speed  = 20.0f;
    private readonly float _turnSpeed = 25f;
    private float _horizontalInput;

    private float _forwardInput;
    // Update is called once per frame
    void FixedUpdate()
    {
        #region GetInputManager
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        #endregion

        #region Vehicle Position and rotation

        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * _turnSpeed * _horizontalInput);
                
        #endregion
    }
}
