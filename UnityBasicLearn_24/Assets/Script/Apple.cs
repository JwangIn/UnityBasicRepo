using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class Apple : MonoBehaviour,IitemCollectable
    {
        

        public void Interact()
        {
            Debug.Log("사과 아이템의 기능이 실행됩니다.");
            AddScore();
        }

        private void AddScore()
        {
            
        }
    }
}
