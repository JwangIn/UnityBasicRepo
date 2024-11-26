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
            Debug.Log("바나나 아이템의 기능이 실행됩니다.");
           
        }
    }
}
