using UnityEngine;

public class FLagZombie : Enemy
{
    public bool flag = true;

    public override void Serang()
    {
        Debug.Log("FlagZombie Gigit");
    }
}
