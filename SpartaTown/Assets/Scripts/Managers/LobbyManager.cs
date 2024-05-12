using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{
    [Header("Name")]
    [SerializeField] private InputField nameInputField;

    [Header("Job")]
    [SerializeField] private GameObject characterCreateCanvas;
    [SerializeField] private GameObject characterCreateBtn;
    [SerializeField] private GameObject selectedCharacterCreateBtn;
    [SerializeField] private Image selectedCharacterImage;
    [SerializeField] private Sprite[] jobImage;

    [Header("Warn Canvas")]
    [SerializeField] private GameObject warnNameCanvas;
    [SerializeField] private GameObject warnJobCanvas;
    [SerializeField] private GameObject warnNameLengthCanvas;

    private bool isSelectedJob = false;
    private bool isSelectedName = false;

    private bool chooseJobTwice = false;
    public void EnableCharCreateCanvas()
    {
        characterCreateCanvas.SetActive(true);
    }
    public void DisableCharCreateCanvas()
    {
        characterCreateCanvas.SetActive(false);
        if (chooseJobTwice)
        {
            Character.JobType jobType = GameManager.Instance.Job;

            characterCreateBtn.SetActive(false);
            selectedCharacterCreateBtn.SetActive(true);
            selectedCharacterImage.GetComponent<Image>().sprite = jobImage[(int)jobType];
        }
    }

    public void OnKnightBtn()
    {
        GameManager.Instance.Job = Character.JobType.Knight;
        isSelectedJob = true;
        chooseJobTwice = true;
        DisableCharCreateCanvas();
    }

    public void OnWizardBtn()
    {
        GameManager.Instance.Job = Character.JobType.Wizard;
        isSelectedJob = true;
        chooseJobTwice = true;
        DisableCharCreateCanvas();
    }

    public void GetNameInput()
    {
        if (nameInputField.text != null)
        {
            GameManager.Instance.Name = nameInputField.text;
        }
        isSelectedName = true;
    }

    public void LoadMainScene()
    {
        if (!isSelectedJob)
        {
            StartCoroutine(DisableCanvas(warnJobCanvas, 2f));
        }
        else if (!isSelectedName)
        {
            StartCoroutine(DisableCanvas(warnNameCanvas, 2f));
        }
        else if (GameManager.Instance.Name.Length < 2 || GameManager.Instance.Name.Length > 10)
        {
            StartCoroutine(DisableCanvas(warnNameLengthCanvas, 2f));
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    IEnumerator DisableCanvas(GameObject canvas, float delay)
    {
        canvas.SetActive(true);
        yield return new WaitForSeconds(delay);
        canvas.SetActive(false);
    }
}
