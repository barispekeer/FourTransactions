using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControl : MonoBehaviour
{
    public TMP_Text ilkSayi, islemIsareti, ikinciSayi, islemSonucu, cevap;
    public TMP_InputField islemInput;
    int sayi1, sayi2, isleminIsareti, isleminSonucu;
    void Start()
    {
        YeniSoru();
    }
    public void YeniSoru()
    {
        cevap.text = "";
        islemInput.text = "";
        sayi1 = Random.Range(1, 11);
        sayi2 = Random.Range(1, 11);
        isleminIsareti = Random.Range(1, 5);
        switch (isleminIsareti)
        {
            case 1:
                islemIsareti.text = "+";
                isleminSonucu = sayi1 + sayi2;
                break;
            case 2:
                islemIsareti.text = "-";
                isleminSonucu = sayi1 - sayi2;
                break;
            case 3:
                islemIsareti.text = "*";
                isleminSonucu = sayi1 * sayi2;
                break;
            case 4:
                islemIsareti.text = "/";
                isleminSonucu = sayi1 / sayi2;
                break;
        }
        ilkSayi.text = sayi1 + "";
        ikinciSayi.text = sayi2 + "";
    }
    public void CevapKontrol()
    {
        if (int.Parse(islemInput.text) == isleminSonucu)
        {
            cevap.color = Color.green;
            cevap.text = "DOGRU";
        }
        else
        {
            cevap.color = Color.red;
            cevap.text = "YANLIS";
        }
    }
}
