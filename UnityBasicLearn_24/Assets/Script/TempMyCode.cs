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
         * 개의 이름, string
         * 개의 나이, int
         * 개가 짖는 소리 void Bark()
        */

        // 컴포넌트 스스로 자기자신의 기능을 실행하도록 다룬다.
        // 유니티 이벤트 함수 -> life cycle 갖습니다.


        [System.Serializable]
        public class Dog
        {
            public string DogName;
            public int Age;


            public void Bark()
            {
                Debug.Log("왈왈!");
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
            Debug.Log($"나의 펫의 이름 : {myDog.DogName}, 펫의 나이 : {myDog.Age}");
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

        // Dog의 이름을 변경해주는 함수
        private void ChangeDogName()
        {
            myDog.DogName = ModifyName;
        }
        // Dog의 나이를 변경해주는 함수
        private void ChangeDogAge()
        {
            myDog.Age = ModifyAge;
        }


        #endregion
    }

}