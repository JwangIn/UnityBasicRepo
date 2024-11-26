using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    public class GameManager : MonoBehaviour
    {
        [Header("UiΩ√Ω∫≈€")]
        public TextMeshProUGUI Score;
        public int curScore;

        // Start is called before the first frame update
        void Start()
        {
            Score.text =$"Score : {curScore}";
        }

        // Update is called once per frame
        void Update()
        {
            Score.text = $"Score : {curScore}";
        }
    }
}
