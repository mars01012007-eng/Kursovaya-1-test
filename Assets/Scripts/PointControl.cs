using TMPro;
using UnityEngine;

public class PointControl : MonoBehaviour
{
    public static PointControl Instance; // паттерн одиночка "Singletone"

    public int points; // количество очков
    public TextMeshProUGUI pointsText; // UI (интерфейс) очков

    private void Start()
    {
        Instance = this; // паттерн одиночка "Singletone"
    }

    public void Addpoints(int value)
    {
        points += value; // добавление очков
        pointsText.text = $"Ваши очки: {points.ToString()}" ; // вывод сообщений в UI

        if(points >= 100) // проверка на окончание игры
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // выход в редакторе
#else
            Application.Quit(); // выход в приложении
#endif
        }
    }

}
