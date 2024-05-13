using UnityEngine;
using UnityEngine.UI;

public class ShowParticipantUI : MenuUI
{
    [SerializeField] private GameObject ShowParticipantCanvas;
    [SerializeField] private Button ShowParticipantBtn;
    [SerializeField] private Button DisableShowParticipantBtn;

    private bool IsShowParticipant = true;

    protected override void Awake()
    {
        base.Awake();
        ShowParticipantBtn.onClick.AddListener(delegate {
            AbleBtnCanvas(ShowParticipantCanvas, IsShowParticipant);
            IsShowParticipant = !IsShowParticipant;
        });
    }

}
