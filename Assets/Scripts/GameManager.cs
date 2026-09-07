using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalKoin;
    private int koinTerkumpul = 0;

    void Start()
    {
        // Otomatis menghitung total koin yang ada di Map saat game mulai
        totalKoin = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    public void AmbilKoin() 
    {
        koinTerkumpul++;
        
        // Jika koin yang terkumpul sudah sama dengan total di map artinya menang
        if (koinTerkumpul == totalKoin)
        {
            Menang();
        }
    }

    void Menang()
    {
        Debug.Log("KAMU MENANG!");
    }
}