using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public interface IitemCollectable
    {
        public void Interact();
    }

    public class Banana : MonoBehaviour,IitemCollectable
    {
       public void Interact()
        {
            Debug.Log("�ٳ��� �������� ����� ����˴ϴ�.");
           
        }
    }
}
