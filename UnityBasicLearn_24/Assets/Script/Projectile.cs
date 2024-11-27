using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class Projectile : MonoBehaviour
    {
        public float speed;
        public float turnSpeed;

        

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            // 방향 * 속력 * 시간
            transform.position += Vector3.forward * speed * Time.deltaTime;
            
            Destroy(gameObject, 10);
            
        }

      

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Animal"))
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }

    }
}
