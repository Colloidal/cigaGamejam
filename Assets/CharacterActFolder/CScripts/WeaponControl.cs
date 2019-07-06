using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    public GameObject player;
    GameObject rayy;


    private List<bool> IsPlayerInCD = new List<bool> { false, false, false, false };

    private void Start()
    {
        rayy = new GameObject();
        player = GameObject.Find("player");
        WeaponManager.GetInstance().PlayerChooseWeapon(1,3);
        WeaponManager.GetInstance().PlayerChooseWeapon(2, 1);
        WeaponManager.GetInstance().PlayerChooseWeapon(3, 1);
        WeaponManager.GetInstance().PlayerChooseWeapon(4, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsPlayerInCD[0]&& Input.GetKey(KeyCode.C))//玩家1按下且不在cd
        {
            if (WeaponManager.GetInstance().PlayerShoot(1))
            {
                Shoot(1,GameObject.Find("firePos").transform.position,characterMovement2D.forwardPointer);
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(1).AttackCD, 1));
            }
            else
            {
                Debug.Log("装弹！");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(1).ReloadCD, 1));
                WeaponManager.GetInstance().FillBullet(1);
            }
            IsPlayerInCD[0] = true;
        }
        else if (!IsPlayerInCD[1] && Input.GetKey(KeyCode.Return))//玩家2按下且不在cd
        {
            if (WeaponManager.GetInstance().PlayerShoot(1))
            {
                Shoot(2, GameObject.Find("firePos").transform.position, characterMovement2D.forwardPointer);
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(2).AttackCD, 2));
            }
            else
            {
                Debug.Log("装弹！2");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(2).ReloadCD, 2));
                WeaponManager.GetInstance().FillBullet(2);
            }
            IsPlayerInCD[1] = true;
        }
        else if (!IsPlayerInCD[2] && Input.GetKey(KeyCode.M))//玩家3按下且不在cd
        {
            if (WeaponManager.GetInstance().PlayerShoot(3))
            {
                Shoot(3, GameObject.Find("firePos").transform.position, characterMovement2D.forwardPointer);
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(3).AttackCD, 3));
            }
            else
            {
                Debug.Log("装弹！3");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(3).ReloadCD, 3));
                WeaponManager.GetInstance().FillBullet(3);
            }
            IsPlayerInCD[2] = true;
        }
        else if (!IsPlayerInCD[3] && Input.GetKey(KeyCode.Slash))//玩家4按下且不在cd
        {
            if (WeaponManager.GetInstance().PlayerShoot(4))
            {
                Shoot(4, GameObject.Find("firePos").transform.position, characterMovement2D.forwardPointer);
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(4).AttackCD, 4));
            }
            else
            {
                Debug.Log("装弹！4");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(4).ReloadCD, 4));
                WeaponManager.GetInstance().FillBullet(4);
            }
            IsPlayerInCD[3] = true;
        }
    }
    public void Shoot(int sourceplayer, Vector3 playerposition, Vector3 pointer)
    {
        int weapontype = WeaponManager.GetInstance().GetPlayerWeapon(sourceplayer).Number;
        if (weapontype == 1)
        {
            GameObject test = Resources.Load("Bullet" + weapontype.ToString(), typeof(GameObject)) as GameObject;
            test.GetComponent<NormalBullet>().SourcePlayer = sourceplayer;
            test.GetComponent<NormalBullet>().speed = new Vector3(pointer.x * 0.01f * WeaponManager.GetInstance().GetPlayerWeapon(sourceplayer).Speed,
             pointer.y * 0.01f * WeaponManager.GetInstance().GetPlayerWeapon(sourceplayer).Speed);
            test.transform.position = playerposition;
            Instantiate(test);
        }
        else if(weapontype == 2) {
            Ray2D ray = new Ray2D(playerposition, pointer);
            RaycastHit2D info = Physics2D.Raycast(ray.origin, ray.direction);
            
        }
        else if (weapontype == 3)
        {
            Ray2D ray = new Ray2D(playerposition, pointer);
            RaycastHit2D info = Physics2D.Raycast(ray.origin, ray.direction);
            if (info.collider != null)
            {
                if (info.transform.gameObject.CompareTag("Player"))
                {
                    Debug.LogWarning("检测到玩家");
                }
                else
                {
                    Debug.Log("检测到墙");
                }
                Debug.Log(rayy);
                GameObject rayer = Instantiate(rayy);
                LineRenderer lineRenderer = rayer.AddComponent<LineRenderer>();
                lineRenderer.material = Resources.Load("rayMaterial", typeof(Material)) as Material;
                lineRenderer.endColor = new Color(1, 1, 1);
                lineRenderer.startWidth = 0.07f;
                lineRenderer.endWidth = 0.07f;
                lineRenderer.startColor = new Color(1, 0, 0);
                lineRenderer.SetPositions(new Vector3[] { ray.origin, info.point });
                StartCoroutine("Raydisappear", rayer);
                if (sourceplayer == 1) { GlobalValues.Player1Stop = !GlobalValues.Player1Stop; StartCoroutine(PlayerStop(GlobalValues.Player1Stop));  }
                else if (sourceplayer == 2)
                {
                    GlobalValues.Player2Stop = !GlobalValues.Player2Stop;
                    StartCoroutine(PlayerStop(GlobalValues.Player2Stop));
                }
                else if (sourceplayer == 3) { GlobalValues.Player3Stop = !GlobalValues.Player3Stop; StartCoroutine(PlayerStop(GlobalValues.Player3Stop));}
                else if (sourceplayer == 4) { GlobalValues.Player4Stop = !GlobalValues.Player4Stop; 
                StartCoroutine(PlayerStop(GlobalValues.Player4Stop));}
                    //GameObject.Find("Main Camera").AddComponent<LineRenderer>().SetPositions(new Vector3[] { ray.origin, info.point });
                }

        }
    }
    IEnumerator Raydisappear(GameObject gamObject)
    {
        for (float ii = 0.3f; ii >= 0; ii -= Time.deltaTime)
            yield return 0;
        Destroy(gamObject);
    }
    //public GameObject getray() {
    //    return rayy;
    //}
    IEnumerator EnterCD(float cd,int playernumber) {
        for (float i = cd; i >= 0; i -= Time.deltaTime) yield return 0;
        IsPlayerInCD[playernumber - 1] = false;
    }
    IEnumerator PlayerStop(bool playerstop) {
        for (float ii = 1f; ii >= 0; ii -= Time.deltaTime)
            yield return 0;
        GlobalValues.Player1Stop = !GlobalValues.Player1Stop;
    }
}
