using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class Projectile : MonoBehaviour
    {
        public float speed;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            // ���� * �ӷ� * �ð�
            transform.position += Vector3.forward * speed * Time.deltaTime;
            
        }

        private void OnCollisionEnter(Collision collision)
        {
            // tag�� Animal ����̸� �ڱ��ڽŰ� �浹�� ����� ���� ������Ʈ�� �ı��ض�
            if(collision.collider.CompareTag("Animal"))
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
