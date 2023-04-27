using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
	public string name;
	public int exp = 0;

	public Character()
	{
		name = "未設定";
	}
	public Character(string name)
	{
		this.name = name;
	}

	public virtual void PrintStatsInfo()
	{
		UnityEngine.Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
	}

	private void Reset()
	{
		this.name = "未設定";
		this.exp = 0;
	}
}// C#ではセミコロン不要.

public class Paladin : Character
{
	public Weapon weapon;

	public Paladin(string name, Weapon weapon) : base(name)
	{
		this.weapon = weapon;
	}

	public override void PrintStatsInfo()
	{
		UnityEngine.Debug.LogFormat("あっぱれ {0} - 汝の{1}を掲げよ！", name, weapon.name);
	}
}

// 構造体の定義.
public struct Weapon
{
	public string name;
	public int damage;

/*
	// 構造体ではパラメータのないコンストラクタ（デフォルトコンストラクタ）は定義出来ない.
	public Weapon()
	{
		name = "未設定";
		damage = 0;
	}
*/
	public Weapon(string name, int damage)
	{
		this.name = name;
		this.damage = damage;
	}
	public void PrintWeaponStats()
	{
		UnityEngine.Debug.LogFormat("Weapon: {0} - {1} DMB", name, damage);
	}
}// C#ではセミコロン不要.

/*
public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/