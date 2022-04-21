using UnityEngine;
using System.Collections;

/// <summary>
/// 敌人状态信息类
/// </summary>
public class EnemyStatusInfo : MonoBehaviour
{

    public HUDHp hp;
    /// <summary>
    /// 当前血量
    /// </summary>
    public float currentHP;
    /// <summary>
    /// 最大血量
    /// </summary>
    public float maxHP;

    public void Damage(float amount)
    {
        //如果敌人已经死亡 则退出(防止虐尸)
        if (currentHP <= 0) return;

        currentHP -= amount;

        if (currentHP <= 0)
            Death();
    }

    /// <summary>
    /// 死亡延迟时间
    /// </summary>
    public float deathDelay =10;


    private void Update()
    {
        hp.SetHp(currentHP);
    }
    /// <summary>
    /// 死亡
    /// </summary>
    public void Death()
    {
        PlayerStatusInfo.Instance.enemyNum--;
        //销毁当前游戏物体
        Destroy(gameObject, deathDelay);

        //播放动画
        var anim = GetComponent<EnemyAnimation>();
        anim.Play(anim.deathName);

        //修改状态
        GetComponent<EnemyAI>().state = EnemyAI.State.Death;

    }
}
