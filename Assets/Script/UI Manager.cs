using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    int PlayerCoins = 0;
    public TextMeshProUGUI Punteggio;


    public void AddCoin(int value)
    {
        PlayerCoins += value;
        Punteggio.text = PlayerCoins.ToString();
        
    }
}
