using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class Apple :Item
    {
        public override void Interact()
        {
            base.Interact();
            GameManager.instance.AddScore();
            Debug.Log("사과 아이템이 사용됩니다.");

        }
    }
}
