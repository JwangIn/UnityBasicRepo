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

        [Header("아이템 소환 세팅")]
        public GameObject bananaPrefab;
        public float ItemSpawnTime = 3f;
        private float ItemCheckTime = 0f;

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
            BananaSpawner();
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

        void BananaSpawner()
        {
            ItemCheckTime += Time.deltaTime;

            if (ItemCheckTime >= ItemSpawnTime)
            {
                ItemCheckTime = 0f;

                int randomX = Random.Range(-limitX, limitX);

                Vector3 spawnPos = new Vector3(randomX, 1, 0);

                Instantiate(bananaPrefab, spawnPos, animalPrefab.transform.rotation);
            }
        }
    }
}
