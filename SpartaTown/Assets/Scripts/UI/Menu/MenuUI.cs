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
        if (b)
        {
            Time.timeScale = 0;
            AbleCanvas(canvas, true);
        }
        else
        {
            Time.timeScale = 1;
            AbleCanvas(canvas, false);
        }
    }


    protected IEnumerator DisableCanvas(GameObject canvas, float delay)
    {
        canvas.SetActive(true);
        yield return new WaitForSeconds(delay);
        canvas.SetActive(false);
    }
}
