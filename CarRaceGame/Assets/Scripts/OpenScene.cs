using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class OpenScene : MonoBehaviour
{
    // �񵿱� ������� �ٸ� ���� �ε��ϴ� �ڷ�ƾ
    IEnumerator LoadSceneAsync(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // �� �ε尡 �Ϸ�� ������ ���
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    // ����: �ٸ� ���� �ε��ϴ� ��ư Ŭ�� �̺�Ʈ ó�� �޼���
    public void OnTutorialButtonClick()
    {
        StartCoroutine(LoadSceneAsync("Tutorial_Scene"));
    }

    public void OnSingleButtonClick()
    {
        StartCoroutine(LoadSceneAsync("Single_Scene"));
    }

    public void OnMultipleButtonClick()
    {
        StartCoroutine(LoadSceneAsync("Multiple_Scene"));
    }
}
