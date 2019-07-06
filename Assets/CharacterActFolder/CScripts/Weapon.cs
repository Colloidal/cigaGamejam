using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    /// <summary>
    /// 武器编号
    /// </summary>
    public int Number;
    /// <summary>
    /// 可能会显示给玩家的武器名称
    /// </summary>
    public string Name;
    /// <summary>
    /// 装弹量
    /// </summary>
    public int Amount;
    /// <summary>
    /// 伤害
    /// </summary>
    public int Damage;
    /// <summary>
    /// 攻击cd
    /// </summary>
    public float AttackCD;
    /// <summary>
    /// 换弹cd
    /// </summary>
    public float ReloadCD;
    /// <summary>
    /// 武器类型,1为普通2为霰弹3为光束
    /// </summary>
    public int Type;
    public float Speed;
    /// <summary>
    /// 武器攻击音效
    /// </summary>
    public string WeaponAttackSound;
    /// <summary>
    /// 武器装填音效
    /// </summary>
    public string WeaponReloadSound;
    /// <summary>
    /// 武器图标
    /// </summary>
    public string WeaponIcon;
}
