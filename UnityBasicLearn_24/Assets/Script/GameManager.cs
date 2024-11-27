using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityBasic.ProtoType2
{
    public class GameManager : MonoBehaviour
    {
        [Header("Singleton Pattern")]
        public static GameManager instance;

        [Header("Game Over")]
        public GameObject gameoverPanel;

        public TextMeshProUGUI curScoreText;
        public TextMeshProUGUI bestScoreText;

        public int score;
        public int bestscore;

        private void Awake()
        {
            if(instance == null) 
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
            DontDestroyOnLoad(gameObject);

        }

        private void Start()
        {
            curScoreText.text = $"���� ���� : {score}";
            bestScoreText.text = $"�ְ� ���� : {bestscore}";

            gameoverPanel.SetActive(false);
        }

        private void Update()
        {
            curScoreText.text = $"���� ���� : {score}";
            bestScoreText.text = $"�ְ� ���� : {bestscore}";
        }

        public void AddScore()
        {
            score += 100;
        }

        public void DecreaseScore()
        {
            if(score >0)
                score -= 100;
                       
        }

        public void GameOver()
        {
            gameoverPanel.SetActive(true);
        }

        public void GameQuit()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }

        public void GameRestart()
        {
            SceneManager.LoadScene(0);
        }

    }
}
