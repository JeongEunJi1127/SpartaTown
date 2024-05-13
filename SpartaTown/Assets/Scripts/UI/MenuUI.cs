using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuUI : MonoBehaviour
{
    [Header("Menu Canvas")]
    [SerializeField] private GameObject SelectCharacterCanvas;
    [SerializeField] private GameObject ChangeNameCanvas;
    [SerializeField] private GameObject ShowParticipantCanvas;
    [SerializeField] private GameObject WarnNameCanvas;

    [Header("Menu Button")]
    [SerializeField] private Button SelectCharacterBtn;
    [SerializeField] private Button ChangeNameBtn;
    [SerializeField] private Button ShowParticipantBtn;
    [SerializeField] private Button DisableShowParticipantBtn;

    [Header("Menu Input")]
    [SerializeField] private InputField nameInputField;

    private bool isSelectCharacter = true;
    private bool isChangeName = true; 
    private bool isShowParticipant = true;

    private string newName;

    private void Start()
    {
        SelectCharacterBtn.onClick.AddListener(delegate{ AbleBtnCanvas(SelectCharacterCanvas, ref isSelectCharacter); });
        ChangeNameBtn.onClick.AddListener(delegate { AbleBtnCanvas(ChangeNameCanvas, ref isChangeName); });
        ShowParticipantBtn.onClick.AddListener(delegate { AbleBtnCanvas(ShowParticipantCanvas, ref isShowParticipant); });
    }

    private void AbleCanvas(GameObject canvas, bool b)
    {
        canvas.SetActive(b);
    }

    private void AbleBtnCanvas(GameObject canvas, ref bool b)
    {
        if (b)
        {
            AbleCanvas(canvas, true);
            b = false;
        }
        else
        {
            AbleCanvas(canvas, false);
            b = true;
        }
    }

    public void ChangeNameInput()
    {
        newName = nameInputField.text;
    }

    public void ChangeName()
    {
        if (newName.Length < 2 || newName.Length > 10)
        {
            StartCoroutine(DisableCanvas(WarnNameCanvas, 2f));
        }
        else if (newName != null)
        {
            GameManager.Instance.playerSO.name = newName;
        }
    }

    IEnumerator DisableCanvas(GameObject canvas, float delay)
    {
        canvas.SetActive(true);
        yield return new WaitForSeconds(delay);
        canvas.SetActive(false);
    }
}
