using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class Animal_1 : MonoBehaviour
    {
        public float speed=5.0f;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += speed * Vector3.back* Time.deltaTime;
                    
        }

        // �浹���� ��
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("End"))
            {
                Debug.Log("���ӿ���");
            }
            
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.collider.CompareTag("End"))
            {
                Debug.Log("�浹 ��");
            }
          
        }

        private void OnCollisionStay(Collision collision)
        {
            if (collision.collider.CompareTag("End"))
            {
                Debug.Log("�浹 ���� ��");
            }
        }

    }
}
