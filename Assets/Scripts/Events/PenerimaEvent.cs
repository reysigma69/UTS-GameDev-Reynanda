using UnityEngine;

public class PenerimaEvent : MonoBehaviour
{
    private void OnEnabled()
    {
        PemancarEvent.SaatTombolDitekan += Respon;
    }

    private void OnDisabled()
    {
        PemancarEvent.SaatTombolDitekan -= Respon;
    }

    void Respon()
    {
        Debug.Log("Tombol ditekann");
    }
}
