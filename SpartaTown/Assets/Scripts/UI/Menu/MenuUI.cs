using UnityEngine;
using System.Collections;

public class MenuUI : MonoBehaviour
{
    private bool IsActive;
    protected virtual void Awake()
    {
        IsActive = true;
    }

    protected void AbleCanvas(GameObject canvas, bool b)
    {
        canvas.SetActive(b);
    }

    protected void AbleBtnCanvas(GameObject canvas, bool b)
    {
        if (b && IsActive)
        {
            Time.timeScale = 0;
            AbleCanvas(canvas, true);
            StartCoroutine(EnableButtonAfterDelay(0.5f));
        }
        else if (!b || !IsActive)
        {
            Time.timeScale = 1;
            AbleCanvas(canvas, false);
            IsActive = true;
        }
    }
    protected IEnumerator EnableButtonAfterDelay(float delay)
    {
        IsActive = false;
        yield return new WaitForSeconds(delay);
    }

    protected IEnumerator DisableCanvas(GameObject canvas, float delay)
    {
        canvas.SetActive(true);
        yield return new WaitForSeconds(delay);
        canvas.SetActive(false);
    }
}
