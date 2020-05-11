using UnityEngine;
public interface IHitBox
{
    void GetDamage(float damage, Vector3 direction, Stats damageOwner);
}
