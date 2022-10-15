using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject _gameMenuPanel;


    public void SetPause()
    {
        _gameMenuPanel.SetActive(!_gameMenuPanel.activeSelf);
    }
}
