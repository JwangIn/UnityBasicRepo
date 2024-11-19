using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic
{
    public class TempMyCode : MonoBehaviour
    {
        /*
         * dog
         * ���� �̸�, string
         * ���� ����, int
         * ���� ¢�� �Ҹ� void Bark()
        */

        // ������Ʈ ������ �ڱ��ڽ��� ����� �����ϵ��� �ٷ��.
        // ����Ƽ �̺�Ʈ �Լ� -> life cycle �����ϴ�.


        [System.Serializable]
        public class Dog
        {
            public string DogName;
            public int Age;


            public void Bark()
            {
                Debug.Log("�п�!");
            }
        }

        public Dog myDog;

        #region Unity Event Method

        public int ab;

        private void Awake()
        {
            ab = 3;

        }




        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(ab);
            ShowStatus();
        }

        private void ShowStatus()
        {
            Debug.Log($"���� ���� �̸� : {myDog.DogName}, ���� ���� : {myDog.Age}");
            myDog.Bark();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ChangeDogName();
                ShowStatus();
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                ChangeDogAge();
                ShowStatus();
            }
        }

        public string ModifyName;
        public int ModifyAge;

        // Dog�� �̸��� �������ִ� �Լ�
        private void ChangeDogName()
        {
            myDog.DogName = ModifyName;
        }
        // Dog�� ���̸� �������ִ� �Լ�
        private void ChangeDogAge()
        {
            myDog.Age = ModifyAge;
        }


        #endregion
    }

}