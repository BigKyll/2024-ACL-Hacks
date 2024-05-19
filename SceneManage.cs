using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    [SerializeField] RectTransform rectangle;

    private void Start() {
        LeanTween.init(800);
        rectangle.gameObject.SetActive(true);
        LeanTween.alpha(rectangle, 0f, 1f).setOnComplete (() => rectangle.gameObject.SetActive(false));
    }

    public void openScene(int x) {
        rectangle.gameObject.SetActive(true);
        LeanTween.alpha(rectangle, 1f, 1f).setOnComplete(() => SceneManager.LoadScene(x));
    }
}
