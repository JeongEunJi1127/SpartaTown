using UnityEngine;
using System.Collections;

public class MenuUI : MonoBehaviour
{
    protected virtual void Awake()
    {

    }

    protected void AbleCanvas(GameObject canvas, bool b)
    {
        canvas.SetActive(b);
    }

    protected void AbleBtnCanvas(GameObject canvas, bool b)
    {
        bool IsActive = GameManager.Instance.IsActive;

        if (b && IsActive)
        {
            Time.timeScale = 0;
            AbleCanvas(canvas, true);
            GameManager.Instance.IsActive = false;
        }
        else
        {
            Time.timeScale = 1;
            AbleCanvas(canvas, false);
            GameManager.Instance.IsActive = true;
        }
    }

    protected IEnumerator DisableCanvas(GameObject canvas, float delay)
    {
        canvas.SetActive(true);
        yield return new WaitForSeconds(delay);
        canvas.SetActive(false);
    }
}
