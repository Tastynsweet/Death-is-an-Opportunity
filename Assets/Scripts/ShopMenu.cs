using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public static bool onMenu = false;
    public GameObject shopMenuUI;
    public ScoreCount scoreCount;
    public Unlockables unlockables;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (onMenu)
            {
                offShop();
            }
            else
            {
                InShop();
            }
        }
    }

    void offShop()
    {
        shopMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        onMenu = false;
    }

    void InShop()
    {
        shopMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        onMenu = true;
    }

    public bool PurchaseItem(int upgradeIndex)
    {
        Upgrades upgrade = unlockables.upgradeLists[upgradeIndex];

        if (!upgrade.isUnlocked && scoreCount.GetFaithScore() >= upgrade.faithRequired)
        {
            scoreCount.RemoveFaith(upgrade.faithRequired);

            upgrade.isUnlocked = true;

            upgrade.Appear();

            FaithProducer faithProducer = upgrade.instance.AddComponent<FaithProducer>();
            faithProducer.unlocks = upgrade;
            faithProducer.scoreCount = scoreCount;

            return true;
        }

        return false;
    }
}
