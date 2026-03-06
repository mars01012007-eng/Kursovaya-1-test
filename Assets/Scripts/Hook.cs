using UnityEngine;

public class Hook : MonoBehaviour
{
    public float speed; // скорость крючка
    public Collider2D collaider; // компонет коллайдера
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // Проверка нажатия на А
        {
            transform.position += Vector3.left * speed * Time.deltaTime; // двичение влево
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0)) // проверка надатия на ЛКМ
        {
            collaider.enabled = true;  // активация коллайдера крючка
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // взаимодействие с триггером
    {
        collaider.enabled = false; // отключение коллайдера

        if(collision.gameObject.TryGetComponent<Fish>(out Fish fish)) // проверка у объекта столкновения коллайдеров компанента "Fish"
        {
            PointControl.Instance.Addpoints(fish.points); // обращение к контроллеру очков и добавление
        }
    }
}
