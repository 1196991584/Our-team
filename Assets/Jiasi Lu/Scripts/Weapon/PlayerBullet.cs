using UnityEngine;
using System.Collections;
/// <summary>
/// 玩家子弹
/// </summary>
public class PlayerBullet : Bullet
{
    //提示：开枪 --》发射子弹 --》射线检测 --》调用敌人受伤方法
    private void Start()
    {
        //根据击中部位（受击物体的名称 hit.collider.name），调用敌人受伤方法
        if (hit.collider != null && hit.collider.tag == "Enemy")
        {
           
            if (hit.collider.GetComponentInParent<EnemyStatusInfo>())
                hit.collider.GetComponentInParent<EnemyStatusInfo>().Damage(30);

            if (hit.collider.GetComponentInParent<AI>())
                hit.collider.GetComponentInParent<AI>().Hp -= 30;
        }
    }
  

   
}
