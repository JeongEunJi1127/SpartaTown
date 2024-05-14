using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    [SerializeField] private GameObject TalkingPopup;

    private CharacterUI characterUI;

    private void Start()
    {
        characterUI = GameManager.Instance.player.GetComponent<CharacterUI>();
    }

    private void Update()
    {
        if (characterUI != null)
        {
            if (characterUI.Character[(int)GameManager.Instance.playerSO.job].transform.position.y > 15)
            {
                TalkingPopup.SetActive(true);
            }
            else
            {
                TalkingPopup.SetActive(false);
            }
        }

    }
}

