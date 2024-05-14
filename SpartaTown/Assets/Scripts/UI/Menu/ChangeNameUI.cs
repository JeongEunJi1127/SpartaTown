using UnityEngine;
using UnityEngine.UI;

public class ChangeNameUI : MenuUI
{
    [SerializeField] private GameObject ChangeNameCanvas;
    [SerializeField] private GameObject WarnNameCanvas;

    [SerializeField] private Button ChangeNameBtn;
    [SerializeField] private InputField nameInputField;
    [SerializeField] private Text PlayerTxt;

    private string newName;
    private bool IsChangeName = true;

    protected override void Awake()
    {
        base.Awake();
        ChangeNameBtn.onClick.AddListener(delegate {
            AbleBtnCanvas(ChangeNameCanvas, IsChangeName);
            IsChangeName = !IsChangeName;
        });
        PlayerTxt.text = GameManager.Instance.playerSO.name;
    }

    public void ChangeNameInput()
    {
        newName = nameInputField.text;
    }

    public void ChangeName()
    {
        Time.timeScale = 1;
        if (string.IsNullOrEmpty(newName) || newName.Length < 2 || newName.Length > 10)
        {
            StartCoroutine(DisableCanvas(WarnNameCanvas, 1.5f));
            nameInputField.text = "";
        }
        else
        {
            GameManager.Instance.playerSO.name = newName;
            GameManager.Instance.player.GetComponent<CharacterUI>().UpdateName();
            PlayerTxt.text = GameManager.Instance.playerSO.name;
            AbleCanvas(ChangeNameCanvas, false);
        }
    }
}
