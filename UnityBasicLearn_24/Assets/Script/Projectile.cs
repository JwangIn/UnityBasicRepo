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

        private void OnCollisionEnter(Collision collision)
        {
            // tag의 Animal 대상이면 자기자신과 충돌한 대상의 게임 오브젝트를 파괴해라
            if(collision.collider.CompareTag("Animal"))
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
