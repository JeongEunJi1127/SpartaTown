using UnityEngine;
using UnityEngine.UI;

public class ChangeJobUI : MenuUI
{
    [SerializeField] private GameObject ChangeJobCanvas;
    [SerializeField] private Button ChangeJobBtn;

    private bool IsSelectCharacter = true;

    protected override void Awake()
    {
        base.Awake();
        ChangeJobBtn.onClick.AddListener(delegate {
            AbleBtnCanvas(ChangeJobCanvas, IsSelectCharacter);
            IsSelectCharacter = !IsSelectCharacter;
        });
    }

    public void OnKnightBtn()
    {
        Time.timeScale = 1;
        GameManager.Instance.playerSO.job = Character.JobType.Knight;
        GameManager.Instance.player.GetComponent<CharacterUI>().UpdateJob();
        AbleCanvas(ChangeJobCanvas, false);
    }

    public void OnWizardBtn()
    {
        Time.timeScale = 1;
        GameManager.Instance.playerSO.job = Character.JobType.Wizard;
        GameManager.Instance.player.GetComponent<CharacterUI>().UpdateJob();
        AbleCanvas(ChangeJobCanvas, false);
    }

    public void DisableCanvas()
    {
        AbleCanvas(ChangeJobCanvas, false);
        Time.timeScale = 1;
    }
}
