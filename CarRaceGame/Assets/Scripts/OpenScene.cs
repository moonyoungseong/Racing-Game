using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class OpenScene : MonoBehaviour
{
    // 비동기 방식으로 다른 씬을 로드하는 코루틴
    IEnumerator LoadSceneAsync(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // 씬 로드가 완료될 때까지 대기
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    // 예시: 다른 씬을 로드하는 버튼 클릭 이벤트 처리 메서드
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
