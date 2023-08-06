using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public Vector2 spawnArea; // область, в которой объект будет появляться

    void Start()
    {
        InvokeRepeating("SpawnObject", 2f, 0f); // вызываем функцию SpawnObject каждые 2 секунды
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    private void SpawnObject()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-spawnArea.x, spawnArea.x), Random.Range(-spawnArea.y, spawnArea.y)); //Считаем территорию спавна
        Instantiate(this.gameObject, spawnPosition, Quaternion.identity); //Спавн объекта
        Destroy(this.gameObject);
    }
}
