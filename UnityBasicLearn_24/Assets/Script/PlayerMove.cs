using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityBasic
{
    public class PlayerMove : MonoBehaviour
    {
        public float speed = 5f;
        public float speedModifier = 0.2f;
        public int turnSpeed = 45;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
           if(Input.GetKey(KeyCode.W))
            {
                if (speedModifier < 30)
                    speedModifier += 5f * Time.deltaTime; 
            }
           else if(!Input.GetKey(KeyCode.W))
            {
                if(speedModifier>0)
                    speedModifier -= 5f * Time.deltaTime;
            }


            float horizontal = Input.GetAxis("Horizontal"); // Horizontal
            float vertical= Input.GetAxis("Vertical");

            transform.Translate((speed+ speedModifier) * Time.deltaTime * vertical * Vector3.forward);
            transform.Rotate(Vector3.up,turnSpeed*horizontal*Time.deltaTime);


            // 컴포넌트 위치 변경
            //transform.position += speed* Vector3.forward * Time.deltaTime;

            


        }
    }
}
