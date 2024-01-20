using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
	[SerializeField] Image loadingBar;
	[SerializeField] Text loadingPercent;

    public static string loadScene;
	public static void LoadSceneHandle(string name)
	{
		loadScene = name;
		LoadScene();
	}

    public static void LoadArkScene()
    {
        LoadSceneHandle("Ark");
    }

    public static void LoadBattleMapScene()
    {
        LoadSceneHandle("BattleMap");
    }

	private void Start() 
	{
		loadingBar.fillAmount = 0;
		StartCoroutine(LoadAsyncScene());	
	}

	static void LoadScene()
	{
		SceneManager.LoadScene("Loading");
	}

	IEnumerator LoadAsyncScene()
	{
		yield return null;
		AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(loadScene);
		asyncOperation.allowSceneActivation = false;
		float timeC = 0;
		while (!asyncOperation.isDone)
		{
			yield return null;
			timeC += Time.deltaTime;
			if (asyncOperation.progress >= 0.9f)
			{
				loadingBar.fillAmount = Mathf.Lerp(loadingBar.fillAmount, 1, timeC);
				loadingPercent.text = string.Format($"{asyncOperation.progress:P1}%");
				if (loadingBar.fillAmount == 1.0f)
				{
					asyncOperation.allowSceneActivation = true;
				}
			}
			else
			{
				loadingBar.fillAmount = Mathf.Lerp(loadingBar.fillAmount, asyncOperation.progress, timeC);
				loadingPercent.text = string.Format($"{asyncOperation.progress:P1}%");
				if (loadingBar.fillAmount >= asyncOperation.progress)
				{
					timeC = 0f;
				}
			}
            loadingPercent.text = string.Format($"{asyncOperation.progress:P1}%");
		}
	}
}