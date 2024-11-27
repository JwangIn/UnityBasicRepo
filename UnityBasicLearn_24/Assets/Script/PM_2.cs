using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class PM_2 : MonoBehaviour
    {
        public float speed=5.0f;
        public GameObject food;
        public Vector3 offset;

        // ���� �ӵ��� A�� �ϸ� 
     
        public float timer;
        public float waitingTime;


        // Start is called before the first frame update
        void Start()
        {
            timer = 0;
                   
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;

            Move();
            if (timer > waitingTime)
            {
                Attack();
                timer = 0;
            }
          
        }

        private void Attack()
        {            
            if (Input.GetKey(KeyCode.LeftControl)) 
            { 
                Vector3 foodPos = new Vector3(transform.position.x, transform.position.y, transform.position.z)+ offset;
                Instantiate(food, foodPos,Quaternion.identity);
            }
        }

        private void Move()
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

        private void OnCollisionEnter(Collision collision)
        {
            
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Item"))
            {
                IitemCollectable item = other.GetComponent<IitemCollectable>();
                item.Interact();

                Destroy(other.gameObject);
            }
            if (other.CompareTag("Animal"))
            {
                GameManager.instance.DecreaseScore();
            }
        }

        public void speedUp()
        {
            speed += 5f;
        }

    }
}
