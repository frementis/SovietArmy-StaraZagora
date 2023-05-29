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
//���� ���� �������� � ��������� Unity, �� ��������������� ��������
//UnityEditor.EditorApplication.isPlaying � false, ����� ���������� ���� � ���������.
//���� ���� �������� � ����������, �� ������������ Application.Quit() ��� ������ �� ����������.