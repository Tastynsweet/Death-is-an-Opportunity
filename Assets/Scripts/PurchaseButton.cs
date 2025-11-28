using UnityEngine;
using UnityEngine.UI;

public class PurchaseButton : MonoBehaviour
{
    public int upgradeIndex;
    public ShopMenu shopMenu;

    private Button button;
    private Image buttonImage;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnPurchase);
        button = GetComponent<Button>();
        buttonImage = GetComponent<Image>();

    }

    public void OnPurchase()
    {
        bool purchased = shopMenu.PurchaseItem(upgradeIndex); 

        if (purchased)
        {
            audioManager.PlaySFX(audioManager.purchaseClip);
            buttonImage.color = new Color(0f, 0f, 0f);
            button.interactable = false;
        }
    }
}
