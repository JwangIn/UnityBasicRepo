using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.ProtoType2
{  

    public interface IitemCollectable
    {
        public void Interact();
    }

    public class Banana : Item
    {
        public override void Interact()
        {
            base.Interact();
            Debug.Log("바나나 아이템이 사용됩니다.");
        }

    }
}
