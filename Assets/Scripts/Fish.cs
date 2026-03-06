using UnityEngine;
using UnityEngine.UIElements;

public class Fish : MonoBehaviour
{
    public int points; // количество очков
    public float speed; // скорость
    public float time; // время смены движения
    public Vector3 direction; // направление движения
    void Start()
    {
        ChoseRandom(); // установка случайных параметров
    }
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime; // перемещение рыб
        time -= Time.deltaTime; // отсчет времени до изменения передвижения
        if (time <= 0) // проверка времени
        {
            ChoseRandom(); // изменение движения
        }
    }

    void ChoseRandom() {
        time = Random.Range(1, 3); // случайное время до изменения движения
        speed = Random.Range(2, 10); // случайная скорость
        direction.y = Random.Range(-1f, 1f); // случайное направление по вертикали
    }

    private void OnTriggerEnter2D(Collider2D collision) // Взаимодействие с триггером
    {
       Destroy(gameObject); // уничтожение вышедшего за границы объекта
    }

}
