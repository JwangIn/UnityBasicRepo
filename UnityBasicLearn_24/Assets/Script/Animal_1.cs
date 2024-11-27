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

        // 충돌했을 때
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("End"))
            {
                GameManager.instance.GameOver();
                Debug.Log("게임오버");
            }
        }

    }
}
