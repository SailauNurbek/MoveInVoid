using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemove2 : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Получаем ввод от клавиш WASD
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Вычисляем направление движения персонажа
        movement = new Vector2(moveHorizontal, moveVertical).normalized;

        // Поворачиваем персонаж в сторону мыши
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mousePosition - (Vector2)transform.position;
    }

    void FixedUpdate()
    {
        // Перемещаем персонаж
        rb.velocity = movement * speed;
    }
}
