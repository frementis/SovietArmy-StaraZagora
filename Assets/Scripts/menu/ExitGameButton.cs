using UnityEngine;

public class ExitGameButton : MonoBehaviour
{
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
//Если игра запущена в редакторе Unity, то устанавливается значение
//UnityEditor.EditorApplication.isPlaying в false, чтобы остановить игру в редакторе.
//Если игра запущена в приложении, то используется Application.Quit() для выхода из приложения.