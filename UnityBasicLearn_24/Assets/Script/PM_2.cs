using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class PM_2 : MonoBehaviour
    {
        public float speed=5.0f;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            // �÷��̾��� �����̵��� �Է¹޾ƾ� �Ѵ�. Horizontal Input.GetAxis(A,D) <-,->

            // transform.postion += �����̵� * ���� * time.deltatime

            // ���� ��� �������ؼ�
            float horizontalInput = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 moveInput = new Vector3(horizontalInput, 0, vertical);

            //Debug.Log($"{horizontalInput}");
            if (transform.position.x < -20)
                transform.position = new Vector3(-20, transform.position.y, transform.position.z);
            else if (transform.position.x > 20)
                transform.position = new Vector3(20, transform.position.y, transform.position.z);


            transform.position += moveInput * speed * Time.deltaTime;
            
        }
    }
}
