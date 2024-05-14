using UnityEngine;
using UnityEngine.UI;

public class NpcUI : MonoBehaviour
{
    [SerializeField] private TextMesh nameTxt;
    [SerializeField] private string name;
    private void Awake()
    {
        SetText(nameTxt);
    }

    private void SetText(TextMesh text)
    {
        nameTxt.text = name;
        nameTxt.color = Color.white;
    }
}
