using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // Игрок, за которым следует камера
    private Vector3 offset;   // Смещение камеры относительно игрока
    public float heightOffset = 2.0f; // Дополнительное поднятие камеры
    public float angle = 45f; // Угол наклона камеры

    // Start вызывается перед первым кадром
    void Start()
    {
        if (player != null)
        {
            offset = transform.position - player.transform.position;
            offset.y += heightOffset; // Поднимаем камеру выше
            transform.rotation = Quaternion.Euler(angle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z); // Наклоняем камеру
        }
        else
        {
            Debug.LogError("Player не назначен в CameraController!");
        }
    }

    // LateUpdate вызывается после всех обновлений кадров
    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}
