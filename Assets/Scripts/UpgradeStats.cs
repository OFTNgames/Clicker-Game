using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreAmount
{
    public static int Score;
}

public enum UPGRADETYPE
{
    CLICK = 0,
    AMOUNT = 1,
    RATE = 2
}

public static class UpgradeStats  
{
    public static int ClickPower = 1;
    public static int PassiveAmount = 1;
    public static float PassiveRate = 5f;

    public static int CurrentClickUpgradeLevel = 0;
    public static int CurrentPassiveAmountUpgradeLevel = 0;
    public static int CurrentPassiveRateUpgradeLevel = 0;

    public static int ClickPowerLevelOne = 2;
    public static int ClickPowerLevelTwo = 5;
    public static int ClickPowerLevelThree = 10;

    public static int PassiveAmountLevelOne = 2;
    public static int PassiveAmountLevelTwo = 5;
    public static int PassiveAmountLevelThree = 10;

    public static float PassiveRateLevelOne = 2.5f;
    public static float PassiveRateLevelTwo = 1f;
    public static float PassiveRateLevelThree = 0.5f;

    public static void UpgradeClickPower()
    {
        CurrentClickUpgradeLevel++;
        switch (CurrentClickUpgradeLevel)
        {
            case 1:
                ClickPower = ClickPowerLevelOne;
                Debug.Log(ClickPower);
                break;
            case 2:
                ClickPower = ClickPowerLevelTwo;
                Debug.Log(ClickPower);
                break;
            case 3:
                ClickPower = ClickPowerLevelThree;
                Debug.Log(ClickPower);
                break;
            default:
                break;
        }
    }

    public static void UpgradeAmount()
    {
        CurrentPassiveAmountUpgradeLevel++;
        switch (CurrentPassiveAmountUpgradeLevel)
        {
            case 1:
                PassiveAmount = PassiveAmountLevelOne;
                break;
            case 2:
                PassiveAmount = PassiveAmountLevelTwo;
                break;
            case 3:
                PassiveAmount = PassiveAmountLevelThree;
                break;
            default:
                break;
        }
    }

    public static void UpgradeRate()
    {
        CurrentPassiveRateUpgradeLevel++;
        switch (CurrentPassiveRateUpgradeLevel)
        {
            case 1:
                PassiveRate = PassiveRateLevelOne;
                break;
            case 2:
                PassiveRate = PassiveRateLevelTwo;
                break;
            case 3:
                PassiveRate = PassiveRateLevelThree;
                break;
            default:
                break;
        }
    }
}

public static class UpgradePrices
{
    public static int LevelOnePrice { get; private set; } = 50;
    public static int LevelTwoPrice { get; private set; } = 200;
    public static int LevelThreePrice { get; private set; } = 500;
   
    public static int GetPrice(int upgradeLevel)
    {
        switch (upgradeLevel)
        {
            case 0:
                return LevelOnePrice;
            case 1:
                return LevelTwoPrice;
            case 2:
                return LevelThreePrice;
            default:
                break;
        }
        return 0;
    }
}
