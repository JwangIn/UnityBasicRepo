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
            Debug.Log("��� �������� ����� ����˴ϴ�.");
            AddScore();
        }

        private void AddScore()
        {
            
        }
    }
}
