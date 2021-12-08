using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GachaFade : MonoBehaviour
{

	float fadeSpeed = 0.02f;
	float red, green, blue, alpha;

	public bool IsFadeIn = true;
	public bool isFadeOut = false;
	public bool isLoading = false;

	[SerializeField] private GameObject[] beforeGameObjects;
	[SerializeField] private GameObject[] afterGameObjects;

	Image fadeImage;
	void Start()
	{
		fadeImage = GetComponent<Image>();
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alpha = fadeImage.color.a;
		alpha = 0;

		StartCoroutine(fadeManager());
	}

	void Update()
	{
		if (IsFadeIn)
		{
			StartFadeIn();
		}
		if (isFadeOut)
		{
			StartFadeOut();
		}
	}

	private IEnumerator fadeManager()
    {
		yield return null;

		yield return new WaitForSeconds(3.5f);
		isFadeOut = true;
		IsFadeIn = false;

		yield return new WaitForSeconds(2.0f);

		foreach (GameObject obj in beforeGameObjects)
        {
			obj.SetActive(false);
        }
		foreach (GameObject obj in afterGameObjects)
		{
			obj.SetActive(true);
		}

		IsFadeIn = true;
		isFadeOut = false;
	}

	void StartFadeIn()
	{
		fadeImage.enabled = true;  // a)�p�l���̕\�����I���ɂ���
		alpha -= fadeSpeed;         // b)�s�����x�����X�ɂ�����
		SetAlpha();               // c)�ύX���������x���p�l���ɔ��f����
		if (alpha <= 0)
		{             // d)���S�ɕs�����ɂȂ����珈���𔲂���
			IsFadeIn = false;
			fadeImage.enabled = false;
		}
	}
	void StartFadeOut()
	{
		fadeImage.enabled = true;  // a)�p�l���̕\�����I���ɂ���
		alpha += fadeSpeed;         // b)�s�����x�����X�ɂ�����
		SetAlpha();               // c)�ύX���������x���p�l���ɔ��f����
		if (alpha >= 1)
		{
			// d)���S�ɕs�����ɂȂ����珈���𔲂���
			isFadeOut = false;
		}
	}

	void SetAlpha()
	{
		fadeImage.color = new Color(red, green, blue, alpha);
	}
}
