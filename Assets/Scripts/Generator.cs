using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[]fish; // массив генерируемых объектов
    public Transform topPoint; // верхн€€ точка генерации
    public Transform bottomPoint; // нижн€€ точка генерации

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Generation", 0, Random.Range(3f, 5f)); // запуск генерации и повторени€
    }

    void Generation()
    {
        Vector3 randomPoint = topPoint.position; // координаты точки генерации
        randomPoint.y = Random.Range(bottomPoint.position.y, topPoint.position.y); // случайна€ позици€ по вертикали
        GameObject x = fish[Random.Range(0, fish.Length)]; // случайный объект дл€ генерации
        Instantiate(x, randomPoint, Quaternion.identity); // клонирование объекта
    }
}
