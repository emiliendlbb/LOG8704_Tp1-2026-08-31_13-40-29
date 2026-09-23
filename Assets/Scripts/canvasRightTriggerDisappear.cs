    
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class canvasRightTriggerDisappear : MonoBehaviour
{
    [SerializeField] private float thumbstickThreshold = 0.1f;
    [SerializeField] private float fadeDuration = 1.0f;
    private CanvasGroup canvasGroup;
    private bool hasTriggered = false;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Update()
    {
        if (hasTriggered) return;
        
        bool rightTriggerPressed = OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger);

        if (rightTriggerPressed)
        {
            hasTriggered = true;
            StartCoroutine(FadeOutAndHide());
        }
    }

    private IEnumerator FadeOutAndHide()
    {
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        float elapsed = 0f;
        float startAlpha = canvasGroup.alpha;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, 0f, elapsed / fadeDuration);
            yield return null;
        }

        canvasGroup.alpha = 0f;
        gameObject.SetActive(false);
    }
}