using UnityEngine;
using UnityEngine.UI;

public class NpcUI : MonoBehaviour
{
    [SerializeField] private Text nameTxt;
    [SerializeField] private string name;
    private void Awake()
    {
        SetText(nameTxt);
    }

    private void SetText(Text text)
    {
        nameTxt.text = name;
        nameTxt.color = Color.white;
        //nameTxt.rectTransform.localPosition = gameObject.transform.position;
        //nameTxt.rectTransform.sizeDelta = new Vector2(400, 200);
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        RectTransform canvasRect = nameTxt.canvas.GetComponent<RectTransform>();
        Vector2 uiPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, screenPos, Camera.main, out uiPos);
        nameTxt.rectTransform.localPosition = uiPos;
    }
}
