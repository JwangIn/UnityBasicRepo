using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class PM_2 : MonoBehaviour
    {
        public float speed=5.0f;
        public GameObject food;
        public Vector3 offset;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            Move();
            Attack();
        }

        private void Attack()
        {
            if(Input.GetKeyDown(KeyCode.LeftControl)) 
            { 
                Vector3 foodPos = new Vector3(transform.position.x, transform.position.y, transform.position.z)+ offset;
                Instantiate(food, foodPos,Quaternion.identity);
            }
        }

        private void Move()
        {
            // 플레이어의 수평이동을 입력받아야 한다. Horizontal Input.GetAxis(A,D) <-,->

            // transform.postion += 수평이동 * 방향 * time.deltatime

            // 방향 얻어 오기위해서
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
