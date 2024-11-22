using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.ProtoType2
{
    
    public class SpawnAnimals : MonoBehaviour
    {
        [Header("Spawn Monster Setting")]
        public GameObject animalPrefab;
        public float SpawnTime = 3f;
        private float CheckTime = 0f;

        public int limitX = 20;



        // Start is called before the first frame update
        void Start()
        {
            Instantiate(animalPrefab);
        }

        // Update is called once per frame
        void Update()
        {
            // 대기 시간
            AnimalSpawner();
        }
        void AnimalSpawner()
        {
            CheckTime += Time.deltaTime;

            if (CheckTime >= SpawnTime)
            {
                CheckTime = 0f;

                int randomX= Random.Range(-limitX, limitX);

                Vector3 spawnforce = new Vector3(randomX, 0, 20);

                Instantiate(animalPrefab,spawnforce, animalPrefab.transform.rotation);
            }
        }
    }
}
