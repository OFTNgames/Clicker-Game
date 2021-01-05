using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeShop : MonoBehaviour
{
    [SerializeField] private TMP_Text clickPowerPriceText;
    [SerializeField] private TMP_Text amountPriceText;
    [SerializeField] private TMP_Text ratePriceText;
    private ScoreManager scoreManager;
    private int clickLevel;
    private int amountLevel;
    private int rateLevel;

    private void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
        clickLevel = UpgradeStats.CurrentClickUpgradeLevel;
        amountLevel = UpgradeStats.CurrentPassiveAmountUpgradeLevel;
        rateLevel = UpgradeStats.CurrentPassiveRateUpgradeLevel;

        clickPowerPriceText.text = UpgradePrices.GetPrice(clickLevel).ToString();
        amountPriceText.text = UpgradePrices.GetPrice(amountLevel).ToString();
        ratePriceText.text = UpgradePrices.GetPrice(rateLevel).ToString();
    }
    public void BuyUpgrade(int upgradeType)
    {
        int upgradeCurrentLevel = 0;
        switch (upgradeType)
        {
            case 0:
                upgradeCurrentLevel = clickLevel;
                clickLevel++;
                break;
            case 1:
                upgradeCurrentLevel = amountLevel;
                amountLevel++;
                break;
            case 2:
                upgradeCurrentLevel = rateLevel;
                rateLevel++;
                break;
            default:
                break;
        }

        if (upgradeCurrentLevel < 4 && ScoreAmount.Score >= UpgradePrices.GetPrice(upgradeCurrentLevel))
        {
            scoreManager.ChangeScore(-UpgradePrices.GetPrice(upgradeCurrentLevel));
            switch (upgradeType)
            {
                case 0:
                    UpgradeStats.UpgradeClickPower();
                    break;
                case 1:
                    UpgradeStats.UpgradeAmount();
                    break;
                case 2:
                    UpgradeStats.UpgradeRate();
                    break;
                default:
                    break;
            }
        }
        UpdatePrices();
    }

    private void UpdatePrices()
    {
        if (UpgradePrices.GetPrice(clickLevel) == 0)
            clickPowerPriceText.text = "Upgrade Complete!";
        else
            clickPowerPriceText.text = UpgradePrices.GetPrice(clickLevel).ToString();
        
        if (UpgradePrices.GetPrice(amountLevel) == 0)
            amountPriceText.text = "Upgrade Complete!";
        else
            amountPriceText.text = UpgradePrices.GetPrice(amountLevel).ToString();

        if (UpgradePrices.GetPrice(rateLevel) == 0)
            ratePriceText.text = "Upgrade Complete!";
        else
            ratePriceText.text = UpgradePrices.GetPrice(rateLevel).ToString();
    }
}
