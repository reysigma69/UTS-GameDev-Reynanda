using UnityEngine;
using UnityEngine.InputSystem; 
using TMPro;

public class PlayerMovement : MonoBehaviour
{
private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created  
public float kecepatan = 5f;
private Vector2 arahGerak; 
public int skor = 0;
public TextMeshProUGUI text;
 // ... kode gerak dari Tugas 1 ...
 // nilai dari action "Move"
 // Dipanggil OTOMATIS oleh komponen Player Input
 // saat action "Move" pada asset InputSystem_Actions aktif.
 // Nama method WAJIB: On + nama action -> OnMove

    void Start()
{
    gameManager = FindFirstObjectByType<GameManager>();
}

 void OnMove(InputValue value)
 {
 // TODO: ambil nilai Vector2 dari input, simpan ke arahGerak
 arahGerak = value.Get<Vector2>();
 }


    // Update is called once per frame
    void Update()
    {
        Vector3 arah = new Vector3(arahGerak.x, arahGerak.y, 0);
 transform.position += arah * kecepatan * Time.deltaTime;
    }


void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Coin"))
    {
        Destroy(other.gameObject);
        
        // 1. Tambah skor
        skor += 1;
        
        // 2. Panggil fungsi bawaan GameManager-mu
        gameManager.AmbilKoin();

        // 3. Cek sisa koin di dalam game
        // Kita pakai [GameObject.FindGameObjectsWithTag] untuk menghitung koin yang tersisa.
        // Dikurangi 1 karena objek koin ini baru akan benar-benar hancur di akhir frame setelah Destroy().
        int sisaKoin = GameObject.FindGameObjectsWithTag("Coin").Length - 1;

        if (sisaKoin <= 0)
        {
            
            text.text = "You Collected The Coins!!";
            Debug.Log("Kamu Menang (Semua koin terkumpul)!");
        }
        else
        {
            
            text.text = "Your Score: " + skor;
            Debug.Log("Your Score: " + skor);
        }
    }
}
}