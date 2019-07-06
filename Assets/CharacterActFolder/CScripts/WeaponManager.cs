using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager:MonoBehaviour
{
    private static WeaponManager weaponManager = new WeaponManager();

    public static List<Weapon> PlayerWeapon = new List<Weapon> {new Weapon(), new Weapon(), new Weapon(), new Weapon()};
    public static List<int> PlayerBulletLeft = new List<int> { 0, 0, 0, 0 };
    public static int i = 0;

    /// <summary>
    /// 有点可爱的单例模式！
    /// </summary>
    public static WeaponManager GetInstance()
    {
        return weaponManager;
    }

    /// <summary>
    /// 玩家在菜单选择武器时使用。
    /// </summary>
    /// <param name="playernumber">玩家的编号，传入1,2,3,4</param>
    /// <param name="weaponnumber">武器的对应编号。</param>
    public void PlayerChooseWeapon(int playernumber,int weaponnumber) {
        PlayerWeapon[playernumber - 1] = GetWeapon(weaponnumber);
        PlayerBulletLeft[playernumber - 1] = PlayerWeapon[playernumber - 1].Amount;
    }
    /// <summary>
    /// 射一枪。
    /// </summary>
    /// <returns><c>true</c>, if shoot was playered, <c>false</c> otherwise.</returns>
    /// <param name="playernumber">需传入1，2，3，4</param>
    public bool PlayerShoot(int playernumber) { 
        if(PlayerBulletLeft[playernumber - 1] > 0) {
            PlayerBulletLeft[playernumber - 1]--;
            return true;
        }
        else {
            return false;
        }
    }
    /// <summary>
    /// 装子弹。
    /// </summary>
    /// <param name="playernumber">Playernumber.</param>
    public void FillBullet(int playernumber) {
        PlayerBulletLeft[playernumber - 1] = PlayerWeapon[playernumber - 1].Amount;
    }

    public Weapon GetPlayerWeapon(int playernumber) {
        return PlayerWeapon[playernumber - 1];
    }

    public void Shoot(int sourceplayer,Vector3 playerposition)
    {
        int weapontype = PlayerWeapon[sourceplayer - 1].Number;
        if (weapontype == 1)
        {
            GameObject test = Resources.Load("Bullet" + weapontype.ToString(), typeof(GameObject)) as GameObject;
            test.GetComponent<NormalBullet>().SourcePlayer = sourceplayer;
            test.GetComponent<NormalBullet>().speed = new Vector3(0.01f * PlayerWeapon[sourceplayer - 1].Speed, 0);
            test.transform.position = playerposition;
            Instantiate(test);
        }
        else if(weapontype == 3){
            Ray2D ray = new Ray2D(playerposition, Vector2.right);
            RaycastHit2D info = Physics2D.Raycast(ray.origin, ray.direction);
            if (info.collider != null)
            {
                if (info.transform.gameObject.CompareTag("player"))
                {
                    Debug.LogWarning("检测到玩家");
                }
                else
                {
                    Debug.Log("检测到墙");
                }
                GameObject.Find("Main Camera").AddComponent<LineRenderer>().SetPositions(new Vector3[] { ray.origin, info.point });
            }

        }
    }

    private void CreateHitRay(Vector3 rayorigin,Vector3 point) {
        GameObject game = new GameObject();
    }

    public Weapon GetWeapon(int number) {
        Weapon gun = new Weapon();
        if (number == 1)
        {
            gun.Number = 1;
            gun.Name = "第一把发子弹的枪";
            gun.Amount = 20;
            gun.Damage = 10;
            gun.Speed = 10;
            gun.ReloadCD = 1f;
            gun.AttackCD = 0.5f;
            gun.Type = 1;
            gun.WeaponAttackSound = null;
            gun.WeaponReloadSound = null;
            gun.WeaponIcon = null;
        }
        else if (number == 3)
        {
            gun.Number = 3;
            gun.Name = "激光枪一号机";
            gun.Amount = 20;
            gun.Damage = 10;
            gun.Speed = 10;
            gun.ReloadCD = 1f;
            gun.AttackCD = 0.5f;
            gun.Type = 3;
            gun.WeaponAttackSound = null;
            gun.WeaponReloadSound = null;
            gun.WeaponIcon = null;
        }
        return gun;
    }
}
