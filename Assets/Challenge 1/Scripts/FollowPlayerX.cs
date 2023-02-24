using UnityEngine;

namespace Challenge_1.Scripts
{
    public class FollowPlayerX : MonoBehaviour
    {
        public GameObject plane;
        private Vector3 offset = new Vector3(30, 0, 0);

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.position = plane.transform.position + offset;
        }
    }
}
