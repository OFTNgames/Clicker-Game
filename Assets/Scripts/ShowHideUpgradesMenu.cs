using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideUpgradesMenu : MonoBehaviour
{
    [SerializeField] private GameObject upgradeMenu;

    public void ShowUpgradeMenu()
    {
        upgradeMenu.SetActive(true);
    }

    public void HideUpgradeMenu()
    {
        upgradeMenu.SetActive(false);
    }
}
