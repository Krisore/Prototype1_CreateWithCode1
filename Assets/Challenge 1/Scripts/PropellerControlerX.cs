using UnityEngine;

namespace Challenge_1.Scripts
{
    public class PropellerControlerX : MonoBehaviour
    {
        public float rotationSpeed;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }
    }
}
